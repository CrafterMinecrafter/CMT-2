namespace CMT_2.Dialogs
{
    partial class Settings
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
            this.Theme_Button = new System.Windows.Forms.Button();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Theme_Button
            // 
            this.Theme_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Theme_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Theme_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Theme_Button.Location = new System.Drawing.Point(12, 12);
            this.Theme_Button.Name = "Theme_Button";
            this.Theme_Button.Size = new System.Drawing.Size(73, 23);
            this.Theme_Button.TabIndex = 3;
            this.Theme_Button.Text = "Theme";
            this.Theme_Button.UseVisualStyleBackColor = true;
            this.Theme_Button.Click += new System.EventHandler(this.Theme_Button_Click);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Location = new System.Drawing.Point(91, 17);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(10, 13);
            this.ThemeLabel.TabIndex = 4;
            this.ThemeLabel.Text = ":";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 293);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.Theme_Button);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Theme_Button;
        private System.Windows.Forms.Label ThemeLabel;
    }
}