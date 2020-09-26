namespace CMT_2.Tools.Hashs
{
    partial class Hashs
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
            this.SelectedHash = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Hash_Label = new System.Windows.Forms.Label();
            this.Text_Label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.hashBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetCodeForFiles_Button = new System.Windows.Forms.Button();
            this.GetCode_Button = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedHash
            // 
            this.SelectedHash.DisplayMember = "1";
            this.SelectedHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectedHash.FormattingEnabled = true;
            this.SelectedHash.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SelectedHash.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.SelectedHash.Location = new System.Drawing.Point(3, 3);
            this.SelectedHash.Name = "SelectedHash";
            this.SelectedHash.Size = new System.Drawing.Size(183, 21);
            this.SelectedHash.TabIndex = 1;
            this.SelectedHash.SelectedIndexChanged += new System.EventHandler(this.SelectedHash_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SelectFile);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Hash_Label);
            this.panel2.Controls.Add(this.Text_Label);
            this.panel2.Controls.Add(this.textBox);
            this.panel2.Controls.Add(this.hashBox);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 143);
            this.panel2.TabIndex = 7;
            // 
            // SelectFile
            // 
            this.SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectFile.BackColor = System.Drawing.Color.White;
            this.SelectFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectFile.Location = new System.Drawing.Point(78, 115);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(103, 23);
            this.SelectFile.TabIndex = 14;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = false;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Or";
            // 
            // Hash_Label
            // 
            this.Hash_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Hash_Label.AutoSize = true;
            this.Hash_Label.Location = new System.Drawing.Point(341, 5);
            this.Hash_Label.Name = "Hash_Label";
            this.Hash_Label.Size = new System.Drawing.Size(35, 13);
            this.Hash_Label.TabIndex = 11;
            this.Hash_Label.Text = "Hash:";
            // 
            // Text_Label
            // 
            this.Text_Label.AutoSize = true;
            this.Text_Label.Location = new System.Drawing.Point(3, 5);
            this.Text_Label.Name = "Text_Label";
            this.Text_Label.Size = new System.Drawing.Size(31, 13);
            this.Text_Label.TabIndex = 10;
            this.Text_Label.Text = "Text:";
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(3, 21);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(237, 88);
            this.textBox.TabIndex = 8;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // hashBox
            // 
            this.hashBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hashBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hashBox.Location = new System.Drawing.Point(344, 21);
            this.hashBox.Multiline = true;
            this.hashBox.Name = "hashBox";
            this.hashBox.Size = new System.Drawing.Size(237, 88);
            this.hashBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GetCodeForFiles_Button);
            this.panel1.Controls.Add(this.GetCode_Button);
            this.panel1.Controls.Add(this.SelectedHash);
            this.panel1.Location = new System.Drawing.Point(87, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 70);
            this.panel1.TabIndex = 8;
            // 
            // GetCodeForFiles_Button
            // 
            this.GetCodeForFiles_Button.BackColor = System.Drawing.Color.White;
            this.GetCodeForFiles_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GetCodeForFiles_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetCodeForFiles_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GetCodeForFiles_Button.Location = new System.Drawing.Point(112, 30);
            this.GetCodeForFiles_Button.Name = "GetCodeForFiles_Button";
            this.GetCodeForFiles_Button.Size = new System.Drawing.Size(113, 23);
            this.GetCodeForFiles_Button.TabIndex = 9;
            this.GetCodeForFiles_Button.Text = "Get Code for files";
            this.GetCodeForFiles_Button.UseVisualStyleBackColor = false;
            this.GetCodeForFiles_Button.Click += new System.EventHandler(this.GetCodeForFiles_Button_Click);
            // 
            // GetCode_Button
            // 
            this.GetCode_Button.BackColor = System.Drawing.Color.White;
            this.GetCode_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GetCode_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetCode_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GetCode_Button.Location = new System.Drawing.Point(3, 30);
            this.GetCode_Button.Name = "GetCode_Button";
            this.GetCode_Button.Size = new System.Drawing.Size(103, 23);
            this.GetCode_Button.TabIndex = 8;
            this.GetCode_Button.Text = "Get Code";
            this.GetCode_Button.UseVisualStyleBackColor = false;
            this.GetCode_Button.Click += new System.EventHandler(this.GetCode_Button_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Top Most";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Hashs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 245);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Hashs";
            this.Text = "Hashs";
            this.Load += new System.EventHandler(this.Hashs_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectedHash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Text_Label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox hashBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GetCode_Button;
        private System.Windows.Forms.Label Hash_Label;
        private System.Windows.Forms.Button GetCodeForFiles_Button;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}