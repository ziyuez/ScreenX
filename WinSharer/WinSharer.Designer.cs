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
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.StartButton.Location = new System.Drawing.Point(62, 102);
            this.StartButton.Margin = new System.Windows.Forms.Padding(6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(425, 44);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Begin ScreenX Share";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StopButton.Location = new System.Drawing.Point(503, 102);
            this.StopButton.Margin = new System.Windows.Forms.Padding(6);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(425, 44);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop Sharing";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(62, 158);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(866, 352);
            this.LogTextBox.TabIndex = 3;
            // 
            // SharingModeComboBox
            // 
            this.SharingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SharingModeComboBox.FormattingEnabled = true;
            this.SharingModeComboBox.Location = new System.Drawing.Point(368, 50);
            this.SharingModeComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.SharingModeComboBox.Name = "SharingModeComboBox";
            this.SharingModeComboBox.Size = new System.Drawing.Size(560, 33);
            this.SharingModeComboBox.TabIndex = 4;
            this.SharingModeComboBox.SelectedIndexChanged += new System.EventHandler(this.SharingModeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select an application to share:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScreenXSharePane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SharingModeComboBox);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ScreenXSharePane";
            this.Text = "ScreenX Share Pane";
            this.Load += new System.EventHandler(this.WinSharer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox LogTextBox;
		private System.Windows.Forms.ComboBox SharingModeComboBox;
        private System.Windows.Forms.Label label1;
    }
}

