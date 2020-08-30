namespace CMT_2.Dialogs
{
    partial class ThemeSettings
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.FormColor = new System.Windows.Forms.PictureBox();
            this.FormColor_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonColor_label = new System.Windows.Forms.Label();
            this.ButtonColor = new System.Windows.Forms.PictureBox();
            this.ButtonLine_label = new System.Windows.Forms.Label();
            this.ButtonLineColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelColor = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FormColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonLineColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelColor)).BeginInit();
            this.SuspendLayout();
            // 
            // FormColor
            // 
            this.FormColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormColor.Location = new System.Drawing.Point(12, 34);
            this.FormColor.Name = "FormColor";
            this.FormColor.Size = new System.Drawing.Size(46, 50);
            this.FormColor.TabIndex = 0;
            this.FormColor.TabStop = false;
            this.FormColor.Click += new System.EventHandler(this.SetIS);
            // 
            // FormColor_label
            // 
            this.FormColor_label.AutoSize = true;
            this.FormColor_label.Location = new System.Drawing.Point(9, 18);
            this.FormColor_label.Name = "FormColor_label";
            this.FormColor_label.Size = new System.Drawing.Size(65, 13);
            this.FormColor_label.TabIndex = 1;
            this.FormColor_label.Text = "Background";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(133, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "test theme!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ButtonColor_label
            // 
            this.ButtonColor_label.AutoSize = true;
            this.ButtonColor_label.Location = new System.Drawing.Point(81, 18);
            this.ButtonColor_label.Name = "ButtonColor_label";
            this.ButtonColor_label.Size = new System.Drawing.Size(38, 13);
            this.ButtonColor_label.TabIndex = 4;
            this.ButtonColor_label.Text = "Button";
            // 
            // ButtonColor
            // 
            this.ButtonColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonColor.Location = new System.Drawing.Point(81, 34);
            this.ButtonColor.Name = "ButtonColor";
            this.ButtonColor.Size = new System.Drawing.Size(46, 50);
            this.ButtonColor.TabIndex = 3;
            this.ButtonColor.TabStop = false;
            this.ButtonColor.Click += new System.EventHandler(this.SetIS);
            // 
            // ButtonLine_label
            // 
            this.ButtonLine_label.AutoSize = true;
            this.ButtonLine_label.Location = new System.Drawing.Point(147, 18);
            this.ButtonLine_label.Name = "ButtonLine_label";
            this.ButtonLine_label.Size = new System.Drawing.Size(57, 13);
            this.ButtonLine_label.TabIndex = 6;
            this.ButtonLine_label.Text = "Button line";
            this.ButtonLine_label.Click += new System.EventHandler(this.c);
            // 
            // ButtonLineColor
            // 
            this.ButtonLineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonLineColor.Location = new System.Drawing.Point(150, 34);
            this.ButtonLineColor.Name = "ButtonLineColor";
            this.ButtonLineColor.Size = new System.Drawing.Size(46, 50);
            this.ButtonLineColor.TabIndex = 5;
            this.ButtonLineColor.TabStop = false;
            this.ButtonLineColor.Click += new System.EventHandler(this.SetIS);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Text";
            // 
            // LabelColor
            // 
            this.LabelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelColor.Location = new System.Drawing.Point(223, 34);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(46, 50);
            this.LabelColor.TabIndex = 7;
            this.LabelColor.TabStop = false;
            this.LabelColor.Click += new System.EventHandler(this.SetIS);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(133, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "set theme!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThemeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelColor);
            this.Controls.Add(this.ButtonLine_label);
            this.Controls.Add(this.ButtonLineColor);
            this.Controls.Add(this.ButtonColor_label);
            this.Controls.Add(this.ButtonColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FormColor_label);
            this.Controls.Add(this.FormColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThemeSettings";
            this.Text = "Theme Settings";
            this.Load += new System.EventHandler(this.ThemeSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonLineColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox FormColor;
        private System.Windows.Forms.Label FormColor_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ButtonColor_label;
        private System.Windows.Forms.PictureBox ButtonColor;
        private System.Windows.Forms.Label ButtonLine_label;
        private System.Windows.Forms.PictureBox ButtonLineColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LabelColor;
        private System.Windows.Forms.Button button2;
    }
}