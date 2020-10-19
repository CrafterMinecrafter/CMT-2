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
            this.components = new System.ComponentModel.Container();
            this.HeadersList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearAllHeadersButton = new System.Windows.Forms.Button();
            this.HeaderRemoveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddHeaderButton = new System.Windows.Forms.Button();
            this.HeaderBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TimerControlButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MSIntervalBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.SendRequestButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LogsEnabled = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ClearAllHeadersButton);
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
            // ClearAllHeadersButton
            // 
            this.ClearAllHeadersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllHeadersButton.BackColor = System.Drawing.Color.White;
            this.ClearAllHeadersButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearAllHeadersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllHeadersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearAllHeadersButton.Location = new System.Drawing.Point(157, 14);
            this.ClearAllHeadersButton.Name = "ClearAllHeadersButton";
            this.ClearAllHeadersButton.Size = new System.Drawing.Size(110, 25);
            this.ClearAllHeadersButton.TabIndex = 17;
            this.ClearAllHeadersButton.Text = "Remove all";
            this.ClearAllHeadersButton.UseVisualStyleBackColor = false;
            this.ClearAllHeadersButton.Click += new System.EventHandler(this.ClearAllHeadersButton_Click);
            // 
            // HeaderRemoveButton
            // 
            this.HeaderRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderRemoveButton.BackColor = System.Drawing.Color.White;
            this.HeaderRemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HeaderRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderRemoveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HeaderRemoveButton.Location = new System.Drawing.Point(157, 45);
            this.HeaderRemoveButton.Name = "HeaderRemoveButton";
            this.HeaderRemoveButton.Size = new System.Drawing.Size(110, 25);
            this.HeaderRemoveButton.TabIndex = 16;
            this.HeaderRemoveButton.Text = "Remove Selected";
            this.HeaderRemoveButton.UseVisualStyleBackColor = false;
            this.HeaderRemoveButton.Click += new System.EventHandler(this.HeaderRemoveButton_Click);
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
            // AddHeaderButton
            // 
            this.AddHeaderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddHeaderButton.BackColor = System.Drawing.Color.White;
            this.AddHeaderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddHeaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddHeaderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddHeaderButton.Location = new System.Drawing.Point(243, 89);
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
            this.HeaderBox.Location = new System.Drawing.Point(6, 76);
            this.HeaderBox.Multiline = true;
            this.HeaderBox.Name = "HeaderBox";
            this.HeaderBox.Size = new System.Drawing.Size(231, 53);
            this.HeaderBox.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TimerControlButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.MSIntervalBox);
            this.panel2.Location = new System.Drawing.Point(629, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 139);
            this.panel2.TabIndex = 4;
            // 
            // TimerControlButton
            // 
            this.TimerControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerControlButton.BackColor = System.Drawing.Color.White;
            this.TimerControlButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TimerControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimerControlButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimerControlButton.Location = new System.Drawing.Point(5, 93);
            this.TimerControlButton.Name = "TimerControlButton";
            this.TimerControlButton.Size = new System.Drawing.Size(106, 27);
            this.TimerControlButton.TabIndex = 17;
            this.TimerControlButton.Text = "Start";
            this.TimerControlButton.UseVisualStyleBackColor = false;
            this.TimerControlButton.Click += new System.EventHandler(this.TimerControlButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Interval(MS):";
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
            this.MSIntervalBox.Location = new System.Drawing.Point(4, 31);
            this.MSIntervalBox.Name = "MSIntervalBox";
            this.MSIntervalBox.Size = new System.Drawing.Size(105, 13);
            this.MSIntervalBox.TabIndex = 13;
            this.MSIntervalBox.Text = "1000";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Timer:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SendRequestButton);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(381, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 139);
            this.panel3.TabIndex = 5;
            // 
            // SendRequestButton
            // 
            this.SendRequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendRequestButton.BackColor = System.Drawing.Color.White;
            this.SendRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SendRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendRequestButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SendRequestButton.Location = new System.Drawing.Point(130, 90);
            this.SendRequestButton.Name = "SendRequestButton";
            this.SendRequestButton.Size = new System.Drawing.Size(106, 27);
            this.SendRequestButton.TabIndex = 17;
            this.SendRequestButton.Text = "Send Request";
            this.SendRequestButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "URL:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "test",
            "lol",
            "tron"});
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 56);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "1000";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Web Client:";
            // 
            // LogsEnabled
            // 
            this.LogsEnabled.AutoSize = true;
            this.LogsEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogsEnabled.Location = new System.Drawing.Point(502, 189);
            this.LogsEnabled.Name = "LogsEnabled";
            this.LogsEnabled.Size = new System.Drawing.Size(68, 17);
            this.LogsEnabled.TabIndex = 17;
            this.LogsEnabled.Text = "Use Logs";
            this.LogsEnabled.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "test",
            "lol",
            "tron"});
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 189);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 137);
            this.textBox2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Logs:";
            // 
            // WBClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 338);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LogsEnabled);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "WBClient";
            this.Text = "WBClient";
            this.Load += new System.EventHandler(this.WBClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button ClearAllHeadersButton;
        private System.Windows.Forms.Button HeaderRemoveButton;
        private System.Windows.Forms.Button TimerControlButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SendRequestButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox LogsEnabled;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
    }
}