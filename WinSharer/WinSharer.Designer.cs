namespace WinSharer
{
    partial class ScreenXSharePane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenXSharePane));
			this.StartButton = new System.Windows.Forms.Button();
			this.StopButton = new System.Windows.Forms.Button();
			this.LogTextBox = new System.Windows.Forms.TextBox();
			this.SharingModeComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.StartButton.Location = new System.Drawing.Point(41, 61);
			this.StartButton.Margin = new System.Windows.Forms.Padding(4);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(283, 33);
			this.StartButton.TabIndex = 0;
			this.StartButton.Text = "Begin ScreenX Share";
			this.StartButton.UseVisualStyleBackColor = false;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// StopButton
			// 
			this.StopButton.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.StopButton.Location = new System.Drawing.Point(335, 61);
			this.StopButton.Margin = new System.Windows.Forms.Padding(4);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(283, 33);
			this.StopButton.TabIndex = 1;
			this.StopButton.Text = "Stop Sharing";
			this.StopButton.UseVisualStyleBackColor = false;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// LogTextBox
			// 
			this.LogTextBox.Location = new System.Drawing.Point(41, 101);
			this.LogTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.LogTextBox.Multiline = true;
			this.LogTextBox.Name = "LogTextBox";
			this.LogTextBox.ReadOnly = true;
			this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.LogTextBox.Size = new System.Drawing.Size(579, 227);
			this.LogTextBox.TabIndex = 3;
			// 
			// SharingModeComboBox
			// 
			this.SharingModeComboBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.SharingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SharingModeComboBox.FormattingEnabled = true;
			this.SharingModeComboBox.Location = new System.Drawing.Point(238, 0);
			this.SharingModeComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.SharingModeComboBox.Name = "SharingModeComboBox";
			this.SharingModeComboBox.Size = new System.Drawing.Size(341, 24);
			this.SharingModeComboBox.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Select an application to share:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.Controls.Add(this.SharingModeComboBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(41, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(579, 28);
			this.panel1.TabIndex = 6;
			// 
			// ScreenXSharePane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(665, 346);
			this.Controls.Add(this.LogTextBox);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ScreenXSharePane";
			this.Text = "ScreenX Share Pane";
			this.Load += new System.EventHandler(this.WinSharer_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox LogTextBox;
		private System.Windows.Forms.ComboBox SharingModeComboBox;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}

