﻿namespace CMT_2
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
            this.components = new System.ComponentModel.Container();
            this.Info_Button = new System.Windows.Forms.Button();
            this.OpenSettings_button = new System.Windows.Forms.Button();
            this.XOR = new System.Windows.Forms.Button();
            this.ByteTool = new System.Windows.Forms.Panel();
            this.StringMode = new System.Windows.Forms.Panel();
            this.Sum_label = new System.Windows.Forms.Label();
            this.AddBytes_NoFIleMode = new System.Windows.Forms.Button();
            this.File3_label = new System.Windows.Forms.Label();
            this.File3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OutputValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TwoValue = new System.Windows.Forms.TextBox();
            this.OneValue = new System.Windows.Forms.TextBox();
            this.FileMode = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.File2_label = new System.Windows.Forms.Label();
            this.File1_label = new System.Windows.Forms.Label();
            this.File2 = new System.Windows.Forms.PictureBox();
            this.File1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_ByteTool = new System.Windows.Forms.Label();
            this.Chat_button = new System.Windows.Forms.Button();
            this.TrashCleaner = new System.Windows.Forms.Timer(this.components);
            this.BytesCount_Label = new System.Windows.Forms.Label();
            this.AddBytesFile_button = new System.Windows.Forms.Button();
            this.ByteTool.SuspendLayout();
            this.StringMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.File3)).BeginInit();
            this.FileMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.File2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.File1)).BeginInit();
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
            this.ByteTool.Controls.Add(this.StringMode);
            this.ByteTool.Controls.Add(this.FileMode);
            this.ByteTool.Controls.Add(this.checkBox1);
            this.ByteTool.Location = new System.Drawing.Point(12, 41);
            this.ByteTool.Name = "ByteTool";
            this.ByteTool.Size = new System.Drawing.Size(491, 308);
            this.ByteTool.TabIndex = 5;
            // 
            // StringMode
            // 
            this.StringMode.Controls.Add(this.Sum_label);
            this.StringMode.Controls.Add(this.AddBytes_NoFIleMode);
            this.StringMode.Controls.Add(this.File3_label);
            this.StringMode.Controls.Add(this.File3);
            this.StringMode.Controls.Add(this.label6);
            this.StringMode.Controls.Add(this.label5);
            this.StringMode.Controls.Add(this.OutputValue);
            this.StringMode.Controls.Add(this.label4);
            this.StringMode.Controls.Add(this.label3);
            this.StringMode.Controls.Add(this.TwoValue);
            this.StringMode.Controls.Add(this.OneValue);
            this.StringMode.Location = new System.Drawing.Point(427, 19);
            this.StringMode.Name = "StringMode";
            this.StringMode.Size = new System.Drawing.Size(302, 184);
            this.StringMode.TabIndex = 6;
            // 
            // Sum_label
            // 
            this.Sum_label.AutoSize = true;
            this.Sum_label.Location = new System.Drawing.Point(145, 111);
            this.Sum_label.Name = "Sum_label";
            this.Sum_label.Size = new System.Drawing.Size(101, 13);
            this.Sum_label.TabIndex = 17;
            this.Sum_label.Text = "Sum or bytes count:";
            // 
            // AddBytes_NoFIleMode
            // 
            this.AddBytes_NoFIleMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBytes_NoFIleMode.BackColor = System.Drawing.Color.White;
            this.AddBytes_NoFIleMode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddBytes_NoFIleMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBytes_NoFIleMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBytes_NoFIleMode.Location = new System.Drawing.Point(148, 13);
            this.AddBytes_NoFIleMode.Name = "AddBytes_NoFIleMode";
            this.AddBytes_NoFIleMode.Size = new System.Drawing.Size(120, 23);
            this.AddBytes_NoFIleMode.TabIndex = 8;
            this.AddBytes_NoFIleMode.Text = "Add To File";
            this.AddBytes_NoFIleMode.UseVisualStyleBackColor = false;
            this.AddBytes_NoFIleMode.Click += new System.EventHandler(this.AddBytes_NoFIleMode_Click);
            // 
            // File3_label
            // 
            this.File3_label.AutoSize = true;
            this.File3_label.Location = new System.Drawing.Point(164, 39);
            this.File3_label.Name = "File3_label";
            this.File3_label.Size = new System.Drawing.Size(84, 13);
            this.File3_label.TabIndex = 16;
            this.File3_label.Text = "File not selected";
            this.File3_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // File3
            // 
            this.File3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.File3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.File3.Location = new System.Drawing.Point(178, 55);
            this.File3.Name = "File3";
            this.File3.Size = new System.Drawing.Size(49, 50);
            this.File3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.File3.TabIndex = 15;
            this.File3.TabStop = false;
            this.File3.Click += new System.EventHandler(this.File3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Your:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Original:";
            // 
            // OutputValue
            // 
            this.OutputValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputValue.Location = new System.Drawing.Point(148, 127);
            this.OutputValue.Name = "OutputValue";
            this.OutputValue.Size = new System.Drawing.Size(122, 13);
            this.OutputValue.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "-";
            // 
            // TwoValue
            // 
            this.TwoValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TwoValue.Location = new System.Drawing.Point(10, 143);
            this.TwoValue.Name = "TwoValue";
            this.TwoValue.Size = new System.Drawing.Size(122, 13);
            this.TwoValue.TabIndex = 9;
            this.TwoValue.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // OneValue
            // 
            this.OneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OneValue.Location = new System.Drawing.Point(10, 111);
            this.OneValue.Name = "OneValue";
            this.OneValue.Size = new System.Drawing.Size(122, 13);
            this.OneValue.TabIndex = 8;
            this.OneValue.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // FileMode
            // 
            this.FileMode.Controls.Add(this.AddBytesFile_button);
            this.FileMode.Controls.Add(this.BytesCount_Label);
            this.FileMode.Controls.Add(this.label2);
            this.FileMode.Controls.Add(this.label1);
            this.FileMode.Controls.Add(this.File2_label);
            this.FileMode.Controls.Add(this.File1_label);
            this.FileMode.Controls.Add(this.File2);
            this.FileMode.Controls.Add(this.File1);
            this.FileMode.Location = new System.Drawing.Point(74, 65);
            this.FileMode.Name = "FileMode";
            this.FileMode.Size = new System.Drawing.Size(302, 156);
            this.FileMode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Original";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your";
            // 
            // File2_label
            // 
            this.File2_label.AutoSize = true;
            this.File2_label.Location = new System.Drawing.Point(204, 14);
            this.File2_label.Name = "File2_label";
            this.File2_label.Size = new System.Drawing.Size(84, 13);
            this.File2_label.TabIndex = 4;
            this.File2_label.Text = "File not selected";
            this.File2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // File1_label
            // 
            this.File1_label.AutoSize = true;
            this.File1_label.Location = new System.Drawing.Point(14, 14);
            this.File1_label.Name = "File1_label";
            this.File1_label.Size = new System.Drawing.Size(84, 13);
            this.File1_label.TabIndex = 3;
            this.File1_label.Text = "File not selected";
            this.File1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // File2
            // 
            this.File2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.File2.Location = new System.Drawing.Point(221, 30);
            this.File2.Name = "File2";
            this.File2.Size = new System.Drawing.Size(49, 50);
            this.File2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.File2.TabIndex = 2;
            this.File2.TabStop = false;
            this.File2.Click += new System.EventHandler(this.File2_Click);
            // 
            // File1
            // 
            this.File1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.File1.Location = new System.Drawing.Point(28, 30);
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(49, 50);
            this.File1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.File1.TabIndex = 1;
            this.File1.TabStop = false;
            this.File1.Click += new System.EventHandler(this.File1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(192, 227);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "File Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // Chat_button
            // 
            this.Chat_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Chat_button.BackColor = System.Drawing.Color.White;
            this.Chat_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Chat_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chat_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Chat_button.Location = new System.Drawing.Point(550, 41);
            this.Chat_button.Name = "Chat_button";
            this.Chat_button.Size = new System.Drawing.Size(67, 23);
            this.Chat_button.TabIndex = 7;
            this.Chat_button.Text = "Chat";
            this.Chat_button.UseVisualStyleBackColor = false;
            this.Chat_button.Visible = false;
            this.Chat_button.Click += new System.EventHandler(this.Chat_button_Click);
            // 
            // TrashCleaner
            // 
            this.TrashCleaner.Enabled = true;
            this.TrashCleaner.Interval = 20000;
            this.TrashCleaner.Tick += new System.EventHandler(this.TrashCleaner_Tick);
            // 
            // BytesCount_Label
            // 
            this.BytesCount_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BytesCount_Label.AutoSize = true;
            this.BytesCount_Label.Location = new System.Drawing.Point(115, 81);
            this.BytesCount_Label.Name = "BytesCount_Label";
            this.BytesCount_Label.Size = new System.Drawing.Size(58, 13);
            this.BytesCount_Label.TabIndex = 7;
            this.BytesCount_Label.Text = "Select files";
            // 
            // AddBytesFile_button
            // 
            this.AddBytesFile_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddBytesFile_button.BackColor = System.Drawing.Color.White;
            this.AddBytesFile_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddBytesFile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBytesFile_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBytesFile_button.Location = new System.Drawing.Point(91, 115);
            this.AddBytesFile_button.Name = "AddBytesFile_button";
            this.AddBytesFile_button.Size = new System.Drawing.Size(132, 23);
            this.AddBytesFile_button.TabIndex = 8;
            this.AddBytesFile_button.Text = "Add Bytes";
            this.AddBytesFile_button.UseVisualStyleBackColor = false;
            this.AddBytesFile_button.Click += new System.EventHandler(this.AddBytesFile_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.Chat_button);
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
            this.StringMode.ResumeLayout(false);
            this.StringMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.File3)).EndInit();
            this.FileMode.ResumeLayout(false);
            this.FileMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.File2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.File1)).EndInit();
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
        private System.Windows.Forms.Button Chat_button;
        private System.Windows.Forms.Label File1_label;
        private System.Windows.Forms.PictureBox File2;
        private System.Windows.Forms.PictureBox File1;
        private System.Windows.Forms.Label File2_label;
        private System.Windows.Forms.Panel FileMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel StringMode;
        private System.Windows.Forms.TextBox OutputValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TwoValue;
        private System.Windows.Forms.TextBox OneValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label File3_label;
        private System.Windows.Forms.PictureBox File3;
        private System.Windows.Forms.Label Sum_label;
        private System.Windows.Forms.Button AddBytes_NoFIleMode;
        private System.Windows.Forms.Timer TrashCleaner;
        private System.Windows.Forms.Label BytesCount_Label;
        private System.Windows.Forms.Button AddBytesFile_button;
    }
}

