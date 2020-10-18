namespace CMT_2.Tools.WebClientUI
{
    partial class WBClient
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
            this.HeadersList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddHeaderButton = new System.Windows.Forms.Button();
            this.HeaderBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MSIntervalBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HeaderRemoveButton = new System.Windows.Forms.Button();
            this.ClearHeadersButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadersList
            // 
            this.HeadersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeadersList.FormattingEnabled = true;
            this.HeadersList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.HeadersList.Location = new System.Drawing.Point(6, 25);
            this.HeadersList.Name = "HeadersList";
            this.HeadersList.Size = new System.Drawing.Size(147, 21);
            this.HeadersList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Headers:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearHeadersButton);
            this.panel1.Controls.Add(this.HeaderRemoveButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddHeaderButton);
            this.panel1.Controls.Add(this.HeaderBox);
            this.panel1.Controls.Add(this.HeadersList);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 139);
            this.panel1.TabIndex = 3;
            // 
            // AddHeaderButton
            // 
            this.AddHeaderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddHeaderButton.BackColor = System.Drawing.Color.White;
            this.AddHeaderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddHeaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddHeaderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddHeaderButton.Location = new System.Drawing.Point(245, 76);
            this.AddHeaderButton.Name = "AddHeaderButton";
            this.AddHeaderButton.Size = new System.Drawing.Size(101, 27);
            this.AddHeaderButton.TabIndex = 14;
            this.AddHeaderButton.Text = "Add";
            this.AddHeaderButton.UseVisualStyleBackColor = false;
            this.AddHeaderButton.Click += new System.EventHandler(this.AddHeaderButton_Click);
            // 
            // HeaderBox
            // 
            this.HeaderBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderBox.AutoCompleteCustomSource.AddRange(new string[] {
            "test",
            "lol",
            "tron"});
            this.HeaderBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeaderBox.Location = new System.Drawing.Point(6, 67);
            this.HeaderBox.Multiline = true;
            this.HeaderBox.Name = "HeaderBox";
            this.HeaderBox.Size = new System.Drawing.Size(233, 64);
            this.HeaderBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "List:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.MSIntervalBox);
            this.panel2.Location = new System.Drawing.Point(381, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 139);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Timer:";
            // 
            // MSIntervalBox
            // 
            this.MSIntervalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MSIntervalBox.AutoCompleteCustomSource.AddRange(new string[] {
            "test",
            "lol",
            "tron"});
            this.MSIntervalBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MSIntervalBox.Location = new System.Drawing.Point(22, 28);
            this.MSIntervalBox.Name = "MSIntervalBox";
            this.MSIntervalBox.Size = new System.Drawing.Size(108, 13);
            this.MSIntervalBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Interval(MS):";
            // 
            // HeaderRemoveButton
            // 
            this.HeaderRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderRemoveButton.BackColor = System.Drawing.Color.White;
            this.HeaderRemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HeaderRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderRemoveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HeaderRemoveButton.Location = new System.Drawing.Point(159, 36);
            this.HeaderRemoveButton.Name = "HeaderRemoveButton";
            this.HeaderRemoveButton.Size = new System.Drawing.Size(110, 25);
            this.HeaderRemoveButton.TabIndex = 16;
            this.HeaderRemoveButton.Text = "Remove Selected";
            this.HeaderRemoveButton.UseVisualStyleBackColor = false;
            // 
            // ClearHeadersButton
            // 
            this.ClearHeadersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearHeadersButton.BackColor = System.Drawing.Color.White;
            this.ClearHeadersButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearHeadersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearHeadersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearHeadersButton.Location = new System.Drawing.Point(159, 3);
            this.ClearHeadersButton.Name = "ClearHeadersButton";
            this.ClearHeadersButton.Size = new System.Drawing.Size(110, 25);
            this.ClearHeadersButton.TabIndex = 17;
            this.ClearHeadersButton.Text = "Remove Selected";
            this.ClearHeadersButton.UseVisualStyleBackColor = false;
            // 
            // WBClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "WBClient";
            this.Text = "WBClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HeadersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox HeaderBox;
        private System.Windows.Forms.Button AddHeaderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MSIntervalBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearHeadersButton;
        private System.Windows.Forms.Button HeaderRemoveButton;
    }
}