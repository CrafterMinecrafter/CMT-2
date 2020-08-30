namespace CMT_2.Dialogs
{
    partial class Info
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
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetPro_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDbox
            // 
            this.IDbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IDbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDbox.Location = new System.Drawing.Point(12, 25);
            this.IDbox.Multiline = true;
            this.IDbox.Name = "IDbox";
            this.IDbox.ReadOnly = true;
            this.IDbox.Size = new System.Drawing.Size(420, 38);
            this.IDbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "...";
            // 
            // GetPro_button
            // 
            this.GetPro_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GetPro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetPro_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPro_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GetPro_button.Location = new System.Drawing.Point(163, 242);
            this.GetPro_button.Name = "GetPro_button";
            this.GetPro_button.Size = new System.Drawing.Size(145, 23);
            this.GetPro_button.TabIndex = 6;
            this.GetPro_button.Text = "Get pro version!";
            this.GetPro_button.UseVisualStyleBackColor = true;
            this.GetPro_button.Click += new System.EventHandler(this.GetPro_button_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 277);
            this.Controls.Add(this.GetPro_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetPro_button;
    }
}