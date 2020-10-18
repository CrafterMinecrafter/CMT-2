namespace CMT_2.Tools
{
    partial class AES
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
            this.RememberedSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DropDown_remove = new System.Windows.Forms.Button();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dec_button = new System.Windows.Forms.Button();
            this.Enc_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecBox = new System.Windows.Forms.TextBox();
            this.EncBox = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RememberedSelector
            // 
            this.RememberedSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RememberedSelector.FormattingEnabled = true;
            this.RememberedSelector.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.RememberedSelector.Location = new System.Drawing.Point(82, 15);
            this.RememberedSelector.Name = "RememberedSelector";
            this.RememberedSelector.Size = new System.Drawing.Size(183, 21);
            this.RememberedSelector.TabIndex = 0;
            this.RememberedSelector.DropDown += new System.EventHandler(this.RememberedSelector_DropDown);
            this.RememberedSelector.SelectedIndexChanged += new System.EventHandler(this.RememberedSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remembered:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KeyBox
            // 
            this.KeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyBox.Location = new System.Drawing.Point(340, 12);
            this.KeyBox.Multiline = true;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(156, 88);
            this.KeyBox.TabIndex = 2;
            this.KeyBox.Text = "defaultKeyString";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DropDown_remove);
            this.panel1.Controls.Add(this.Submit_Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.KeyBox);
            this.panel1.Controls.Add(this.RememberedSelector);
            this.panel1.Location = new System.Drawing.Point(4, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 116);
            this.panel1.TabIndex = 4;
            // 
            // DropDown_remove
            // 
            this.DropDown_remove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DropDown_remove.BackColor = System.Drawing.Color.White;
            this.DropDown_remove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DropDown_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDown_remove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DropDown_remove.Location = new System.Drawing.Point(82, 44);
            this.DropDown_remove.Name = "DropDown_remove";
            this.DropDown_remove.Size = new System.Drawing.Size(185, 23);
            this.DropDown_remove.TabIndex = 7;
            this.DropDown_remove.Text = "Remove Selected Key";
            this.DropDown_remove.UseVisualStyleBackColor = false;
            this.DropDown_remove.Click += new System.EventHandler(this.DropDown_remove_Click);
            // 
            // Submit_Button
            // 
            this.Submit_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Submit_Button.BackColor = System.Drawing.Color.White;
            this.Submit_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Submit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Submit_Button.Location = new System.Drawing.Point(502, 44);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(73, 23);
            this.Submit_Button.TabIndex = 6;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = false;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Dec_button);
            this.panel2.Controls.Add(this.Enc_Button);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.DecBox);
            this.panel2.Controls.Add(this.EncBox);
            this.panel2.Location = new System.Drawing.Point(4, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 209);
            this.panel2.TabIndex = 6;
            // 
            // Dec_button
            // 
            this.Dec_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dec_button.BackColor = System.Drawing.Color.White;
            this.Dec_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Dec_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dec_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dec_button.Location = new System.Drawing.Point(249, 121);
            this.Dec_button.Name = "Dec_button";
            this.Dec_button.Size = new System.Drawing.Size(81, 23);
            this.Dec_button.TabIndex = 11;
            this.Dec_button.Text = "<----";
            this.Dec_button.UseVisualStyleBackColor = false;
            this.Dec_button.Click += new System.EventHandler(this.Dec_button_Click);
            // 
            // Enc_Button
            // 
            this.Enc_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Enc_Button.BackColor = System.Drawing.Color.White;
            this.Enc_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Enc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enc_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Enc_Button.Location = new System.Drawing.Point(249, 72);
            this.Enc_Button.Name = "Enc_Button";
            this.Enc_Button.Size = new System.Drawing.Size(81, 23);
            this.Enc_Button.TabIndex = 7;
            this.Enc_Button.Text = "---->";
            this.Enc_Button.UseVisualStyleBackColor = false;
            this.Enc_Button.Click += new System.EventHandler(this.Enc_Button_Click);
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Encrypt:";
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
            this.EncBox.Location = new System.Drawing.Point(340, 21);
            this.EncBox.Multiline = true;
            this.EncBox.Name = "EncBox";
            this.EncBox.Size = new System.Drawing.Size(237, 175);
            this.EncBox.TabIndex = 7;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 9);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Top Most";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // AES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 382);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AES";
            this.Text = "AES Tool";
            this.Load += new System.EventHandler(this.AES_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RememberedSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox DecBox;
        private System.Windows.Forms.TextBox EncBox;
        private System.Windows.Forms.Button Dec_button;
        private System.Windows.Forms.Button Enc_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DropDown_remove;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}