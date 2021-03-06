/* All content in this sample is �AS IS� with with no warranties, and confer no rights. 
 * Any code on this blog is subject to the terms specified at http://www.microsoft.com/info/cpyright.mspx. 
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RDPCOMAPILib;
using System.Threading;

namespace WinSharer
{
    public partial class ScreenXSharePane : Form
    {

        protected RDPSession m_pRdpSession = null;
        protected bool ongoingSession = false;

        public ScreenXSharePane()
        {
            InitializeComponent();
        }

        private void WinSharer_Load(object sender, EventArgs e)
        {
            m_pRdpSession = new RDPSession();
            SharingModeComboBox.Items.Add("Desktop");
            SharingModeComboBox.SelectedIndex = 0;
            var applications = m_pRdpSession.ApplicationFilter.Applications;

            foreach (var appObj in applications)
            {
                RDPSRAPIApplication app = appObj as RDPSRAPIApplication;
                if(!string.IsNullOrEmpty(app.Name)) SharingModeComboBox.Items.Add(app.Name);
            }
        }

        void OnAttendeeDisconnected(object pDisconnectInfo)
        {
            IRDPSRAPIAttendeeDisconnectInfo pDiscInfo = pDisconnectInfo as IRDPSRAPIAttendeeDisconnectInfo;
            LogTextBox.Text += ("Attendee Disconnected: " + pDiscInfo.Attendee.RemoteName + Environment.NewLine);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
			if (!ongoingSession)
			{
                try
                {
                    if (m_pRdpSession == null)
                    {
                        m_pRdpSession = new RDPSession();
                    }

                    m_pRdpSession.OnAttendeeConnected += new _IRDPSessionEvents_OnAttendeeConnectedEventHandler(OnAttendeeConnected);
                    m_pRdpSession.OnAttendeeDisconnected += new _IRDPSessionEvents_OnAttendeeDisconnectedEventHandler(OnAttendeeDisconnected);
                    m_pRdpSession.OnControlLevelChangeRequest += new _IRDPSessionEvents_OnControlLevelChangeRequestEventHandler(OnControlLevelChangeRequest);
                    var properties = m_pRdpSession.Properties;
                    properties["EnableClipboardRedirect"] = true;
                    SetSharingMode();

                    m_pRdpSession.Open();
                    IRDPSRAPIInvitation pInvitation = m_pRdpSession.Invitations.CreateInvitation("WinPresenter", "PresentationGroup", "", 5);
                    string invitationString = pInvitation.ConnectionString;
                    WriteToFile(invitationString);
                    LogTextBox.Text += $"Presentation Started. {this.SharingModeComboBox.GetItemText(this.SharingModeComboBox.SelectedItem)} is being shared." + Environment.NewLine;
                    ongoingSession = true;
                }
                catch (Exception ex)
                {
                    LogTextBox.Text += "Error occured while starting presentation. Error: " + ex.ToString() + Environment.NewLine;
                }
            }
        }

        void OnControlLevelChangeRequest(object pObjAttendee, CTRL_LEVEL RequestedLevel)
        {
            IRDPSRAPIAttendee pAttendee = pObjAttendee as IRDPSRAPIAttendee;
            pAttendee.ControlLevel = RequestedLevel;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_pRdpSession.Close();
                LogTextBox.Text += "Presentation Stopped." + Environment.NewLine;
                Marshal.ReleaseComObject(m_pRdpSession);
                m_pRdpSession = null;
                ongoingSession = false;
            }
            catch (Exception ex)
            {
                LogTextBox.Text += "Error occured while stopping presentation. Error: " + ex.ToString();
            }
        }

        private void OnAttendeeConnected(object pObjAttendee)
        {
            IRDPSRAPIAttendee pAttendee = pObjAttendee as IRDPSRAPIAttendee;
            pAttendee.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_VIEW;
            LogTextBox.Text += ("Attendee Connected: " + pAttendee.RemoteName + Environment.NewLine);
        }

        public void WriteToFile(string InviteString)
        {
            File.WriteAllText("inv.xml", InviteString);
        }

        public void SetSharingMode()
        {
            string selected = this.SharingModeComboBox.GetItemText(this.SharingModeComboBox.SelectedItem);

            if (selected.Equals("Desktop"))
            {
                Screen screen = Screen.FromControl(this);
                m_pRdpSession.SetDesktopSharedRect(screen.Bounds.Left, screen.Bounds.Top, screen.Bounds.Right, screen.Bounds.Bottom);
                LogTextBox.Text += ($"Sharing desktop: {this.LogicalToDeviceUnits(screen.Bounds.Left)}, {this.LogicalToDeviceUnits(screen.Bounds.Top)}, {this.LogicalToDeviceUnits(screen.Bounds.Right)}, {this.LogicalToDeviceUnits(screen.Bounds.Bottom)}" + Environment.NewLine);
            }
            else
            {
                m_pRdpSession.ApplicationFilter.Enabled = true;

                var applications = m_pRdpSession.ApplicationFilter.Applications;
                foreach (var appObj in applications)
                {
                    RDPSRAPIApplication app = appObj as RDPSRAPIApplication;
                    if (!string.IsNullOrEmpty(app.Name) && app.Name.Equals(selected))
                    {
                        app.Shared = true;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}