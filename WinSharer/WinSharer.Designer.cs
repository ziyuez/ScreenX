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
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(62, 50);
            this.StartButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(420, 44);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start Presentation";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(546, 50);
            this.StopButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(386, 44);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop Presentation";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(62, 158);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.SharingModeComboBox.Location = new System.Drawing.Point(62, 106);
            this.SharingModeComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SharingModeComboBox.Name = "SharingModeComboBox";
            this.SharingModeComboBox.Size = new System.Drawing.Size(416, 33);
            this.SharingModeComboBox.TabIndex = 4;
            this.SharingModeComboBox.SelectedIndexChanged += new System.EventHandler(this.SharingModeComboBox_SelectedIndexChanged);
            // 
            // ScreenXSharePane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 540);
            this.Controls.Add(this.SharingModeComboBox);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
	}
}

