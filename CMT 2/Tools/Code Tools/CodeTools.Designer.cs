namespace CMT_2.Tools.Code_Tools
{
    partial class CodeTools
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VarName = new System.Windows.Forms.TextBox();
            this.FileToBase64 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DecBox = new System.Windows.Forms.TextBox();
            this.EncBox = new System.Windows.Forms.TextBox();
            this.Enc_Button = new System.Windows.Forms.Button();
            this.Dec_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SelectFile);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.OutputBox);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 160);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Settings:";
            // 
            // SelectFile
            // 
            this.SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFile.BackColor = System.Drawing.Color.White;
            this.SelectFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectFile.Location = new System.Drawing.Point(162, 29);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(101, 23);
            this.SelectFile.TabIndex = 7;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = false;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output code:";
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.AutoCompleteCustomSource.AddRange(new string[] {
            "test",
            "lol",
            "tron"});
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputBox.Location = new System.Drawing.Point(345, 25);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(237, 120);
            this.OutputBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VarName);
            this.panel1.Controls.Add(this.FileToBase64);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(27, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 58);
            this.panel1.TabIndex = 17;
            // 
            // VarName
            // 
            this.VarName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VarName.AutoCompleteCustomSource.AddRange(new string[] {
            "test",
            "lol",
            "tron"});
            this.VarName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VarName.Location = new System.Drawing.Point(16, 16);
            this.VarName.Name = "VarName";
            this.VarName.Size = new System.Drawing.Size(95, 13);
            this.VarName.TabIndex = 12;
            // 
            // FileToBase64
            // 
            this.FileToBase64.AutoSize = true;
            this.FileToBase64.Location = new System.Drawing.Point(16, 35);
            this.FileToBase64.Name = "FileToBase64";
            this.FileToBase64.Size = new System.Drawing.Size(97, 17);
            this.FileToBase64.TabIndex = 10;
            this.FileToBase64.Text = "File To Base64";
            this.FileToBase64.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "variable name:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.DecBox);
            this.panel3.Controls.Add(this.EncBox);
            this.panel3.Controls.Add(this.Enc_Button);
            this.panel3.Controls.Add(this.Dec_button);
            this.panel3.Location = new System.Drawing.Point(12, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 209);
            this.panel3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Decrypt:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Encrypt:";
            // 
            // DecBox
            // 
            this.DecBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DecBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecBox.Location = new System.Drawing.Point(6, 21);
            this.DecBox.Multiline = true;
            this.DecBox.Name = "DecBox";
            this.DecBox.Size = new System.Drawing.Size(237, 175);
            this.DecBox.TabIndex = 8;
            // 
            // EncBox
            // 
            this.EncBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncBox.Location = new System.Drawing.Point(374, 21);
            this.EncBox.Multiline = true;
            this.EncBox.Name = "EncBox";
            this.EncBox.Size = new System.Drawing.Size(237, 175);
            this.EncBox.TabIndex = 7;
            // 
            // Enc_Button
            // 
            this.Enc_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Enc_Button.BackColor = System.Drawing.Color.White;
            this.Enc_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Enc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enc_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Enc_Button.Location = new System.Drawing.Point(266, 72);
            this.Enc_Button.Name = "Enc_Button";
            this.Enc_Button.Size = new System.Drawing.Size(81, 23);
            this.Enc_Button.TabIndex = 7;
            this.Enc_Button.Text = "---->";
            this.Enc_Button.UseVisualStyleBackColor = false;
            this.Enc_Button.Click += new System.EventHandler(this.Enc_Button_Click);
            // 
            // Dec_button
            // 
            this.Dec_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dec_button.BackColor = System.Drawing.Color.White;
            this.Dec_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Dec_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dec_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dec_button.Location = new System.Drawing.Point(266, 121);
            this.Dec_button.Name = "Dec_button";
            this.Dec_button.Size = new System.Drawing.Size(81, 23);
            this.Dec_button.TabIndex = 11;
            this.Dec_button.Text = "<----";
            this.Dec_button.UseVisualStyleBackColor = false;
            this.Dec_button.Click += new System.EventHandler(this.Dec_button_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Base64:";
            // 
            // CodeTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 447);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "CodeTools";
            this.Text = "Code  Tools";
            this.Load += new System.EventHandler(this.CodeTools_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.CheckBox FileToBase64;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VarName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Dec_button;
        private System.Windows.Forms.Button Enc_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DecBox;
        private System.Windows.Forms.TextBox EncBox;
        private System.Windows.Forms.Label label6;
    }
}