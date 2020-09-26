namespace CMT_2.Dialogs
{
    partial class TextBoxDialog
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
            this.Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box.Location = new System.Drawing.Point(4, 3);
            this.Box.Multiline = true;
            this.Box.Name = "Box";
            this.Box.ReadOnly = true;
            this.Box.Size = new System.Drawing.Size(491, 269);
            this.Box.TabIndex = 9;
            // 
            // TextBoxDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 277);
            this.Controls.Add(this.Box);
            this.Name = "TextBoxDialog";
            this.Text = "ReadBox Dialog";
            this.Load += new System.EventHandler(this.TextBoxDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box;
    }
}