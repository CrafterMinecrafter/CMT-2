namespace CMT_2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Info_Button = new System.Windows.Forms.Button();
            this.OpenSettings_button = new System.Windows.Forms.Button();
            this.XOR = new System.Windows.Forms.Button();
            this.ByteTool = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_ByteTool = new System.Windows.Forms.Label();
            this.ByteTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info_Button
            // 
            this.Info_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Info_Button.BackColor = System.Drawing.Color.White;
            this.Info_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Info_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Info_Button.Location = new System.Drawing.Point(507, 12);
            this.Info_Button.Name = "Info_Button";
            this.Info_Button.Size = new System.Drawing.Size(73, 23);
            this.Info_Button.TabIndex = 2;
            this.Info_Button.Text = "Info";
            this.Info_Button.UseVisualStyleBackColor = false;
            this.Info_Button.Click += new System.EventHandler(this.Info_Button_Click);
            // 
            // OpenSettings_button
            // 
            this.OpenSettings_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSettings_button.BackColor = System.Drawing.Color.White;
            this.OpenSettings_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OpenSettings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSettings_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenSettings_button.Location = new System.Drawing.Point(586, 12);
            this.OpenSettings_button.Name = "OpenSettings_button";
            this.OpenSettings_button.Size = new System.Drawing.Size(94, 23);
            this.OpenSettings_button.TabIndex = 3;
            this.OpenSettings_button.Text = "Settings";
            this.OpenSettings_button.UseVisualStyleBackColor = false;
            this.OpenSettings_button.Click += new System.EventHandler(this.OpenSettings_button_Click);
            // 
            // XOR
            // 
            this.XOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XOR.BackColor = System.Drawing.Color.White;
            this.XOR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.XOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XOR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.XOR.Location = new System.Drawing.Point(607, 355);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(73, 23);
            this.XOR.TabIndex = 4;
            this.XOR.Text = "XOR";
            this.XOR.UseVisualStyleBackColor = false;
            this.XOR.Click += new System.EventHandler(this.XOR_Click);
            // 
            // ByteTool
            // 
            this.ByteTool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ByteTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ByteTool.Controls.Add(this.checkBox1);
            this.ByteTool.Location = new System.Drawing.Point(12, 41);
            this.ByteTool.Name = "ByteTool";
            this.ByteTool.Size = new System.Drawing.Size(491, 308);
            this.ByteTool.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(85, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "File Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_ByteTool
            // 
            this.label_ByteTool.AutoSize = true;
            this.label_ByteTool.Location = new System.Drawing.Point(225, 17);
            this.label_ByteTool.Name = "label_ByteTool";
            this.label_ByteTool.Size = new System.Drawing.Size(52, 13);
            this.label_ByteTool.TabIndex = 6;
            this.label_ByteTool.Text = "ByteTool:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label_ByteTool);
            this.Controls.Add(this.ByteTool);
            this.Controls.Add(this.XOR);
            this.Controls.Add(this.OpenSettings_button);
            this.Controls.Add(this.Info_Button);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ByteTool.ResumeLayout(false);
            this.ByteTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Info_Button;
        private System.Windows.Forms.Button OpenSettings_button;
        private System.Windows.Forms.Button XOR;
        private System.Windows.Forms.Panel ByteTool;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_ByteTool;
    }
}

