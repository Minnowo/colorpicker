namespace nsColorPicker
{
    partial class ColorComboBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.DownButtonPanel = new System.Windows.Forms.Panel();
            this.UpButtonPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.Location = new System.Drawing.Point(0, 10);
            this.MainTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(130, 20);
            this.MainTextBox.TabIndex = 0;
            this.MainTextBox.Text = "255 255 255";
            this.MainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DownButtonPanel
            // 
            this.DownButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownButtonPanel.AutoSize = true;
            this.DownButtonPanel.Location = new System.Drawing.Point(0, 30);
            this.DownButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DownButtonPanel.Name = "DownButtonPanel";
            this.DownButtonPanel.Size = new System.Drawing.Size(130, 11);
            this.DownButtonPanel.TabIndex = 4;
            // 
            // UpButtonPanel
            // 
            this.UpButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpButtonPanel.AutoSize = true;
            this.UpButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.UpButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UpButtonPanel.Name = "UpButtonPanel";
            this.UpButtonPanel.Size = new System.Drawing.Size(130, 11);
            this.UpButtonPanel.TabIndex = 5;
            // 
            // ColorComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpButtonPanel);
            this.Controls.Add(this.DownButtonPanel);
            this.Controls.Add(this.MainTextBox);
            this.Name = "ColorComboBox";
            this.Size = new System.Drawing.Size(136, 61);
            this.ClientSizeChanged += new System.EventHandler(this.ColorComboBox_ClientSizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.Panel DownButtonPanel;
        private System.Windows.Forms.Panel UpButtonPanel;
    }
}
