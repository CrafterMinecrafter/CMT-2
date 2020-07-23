using System.Drawing;

namespace CMT_2.test
{
    partial class test
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
        private void InitializeComponent(Color form, Color button,Color ButtonBorder, Color textbox,Color label)
        {
            this.IDbox = new System.Windows.Forms.TextBox();
            this.Theme_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDbox
            // 
            this.IDbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IDbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDbox.Location = new System.Drawing.Point(12, 114);
            this.IDbox.Multiline = true;
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(420, 38);
            this.IDbox.TabIndex = 1;
            // 
            // Theme_Button
            // 
            this.Theme_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Theme_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Theme_Button.ForeColor = label;
            this.Theme_Button.Location = new System.Drawing.Point(12, 64);
            this.Theme_Button.Name = "Theme_Button";
            this.Theme_Button.Size = new System.Drawing.Size(73, 23);
            this.Theme_Button.TabIndex = 4;
            this.Theme_Button.Text = "Theme";
            this.Theme_Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = label;
            this.label1.Location = new System.Drawing.Point(193, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hey!, im text!";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Theme_Button);
            this.Controls.Add(this.IDbox);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Button Theme_Button;
        private System.Windows.Forms.Label label1;
    }
}