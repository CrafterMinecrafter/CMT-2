namespace CMT_2.Dialogs
{
    partial class FileInfo
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
            this.FName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FCreateData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FMD5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FPath = new System.Windows.Forms.TextBox();
            this.FPicture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FName.Location = new System.Drawing.Point(15, 25);
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Size = new System.Drawing.Size(291, 13);
            this.FName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size:";
            // 
            // FSize
            // 
            this.FSize.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FSize.Location = new System.Drawing.Point(15, 56);
            this.FSize.Name = "FSize";
            this.FSize.ReadOnly = true;
            this.FSize.Size = new System.Drawing.Size(291, 13);
            this.FSize.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Creation Data:";
            // 
            // FCreateData
            // 
            this.FCreateData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FCreateData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FCreateData.Location = new System.Drawing.Point(15, 88);
            this.FCreateData.Name = "FCreateData";
            this.FCreateData.ReadOnly = true;
            this.FCreateData.Size = new System.Drawing.Size(291, 13);
            this.FCreateData.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MD5";
            // 
            // FMD5
            // 
            this.FMD5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FMD5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FMD5.Location = new System.Drawing.Point(15, 122);
            this.FMD5.Name = "FMD5";
            this.FMD5.ReadOnly = true;
            this.FMD5.Size = new System.Drawing.Size(291, 13);
            this.FMD5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Full Path:";
            // 
            // FPath
            // 
            this.FPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FPath.Location = new System.Drawing.Point(15, 151);
            this.FPath.Name = "FPath";
            this.FPath.ReadOnly = true;
            this.FPath.Size = new System.Drawing.Size(291, 13);
            this.FPath.TabIndex = 8;
            // 
            // FPicture
            // 
            this.FPicture.Location = new System.Drawing.Point(111, 191);
            this.FPicture.Name = "FPicture";
            this.FPicture.Size = new System.Drawing.Size(74, 74);
            this.FPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FPicture.TabIndex = 10;
            this.FPicture.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unique image:";
            // 
            // FileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 277);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FMD5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FCreateData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FileInfo";
            this.Text = "FileInfo";
            this.Load += new System.EventHandler(this.FileInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FCreateData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FMD5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FPath;
        private System.Windows.Forms.PictureBox FPicture;
        private System.Windows.Forms.Label label6;
    }
}