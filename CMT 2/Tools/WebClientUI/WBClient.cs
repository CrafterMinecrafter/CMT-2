using CMT_2.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMT_2.Tools.WebClientUI
{
    public partial class WBClient : Form
    {
        public WBClient()
        {
            InitializeComponent();
        }

        private void AddHeaderButton_Click(object sender, EventArgs e)
        {
            HeadersList.Items.Add(HeaderBox.Text);
        }

        private void TimerControlButton_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = int.Parse(MSIntervalBox.Text);
            }
            catch
            {
                MessageBox.Show("Error, enter time in miliseconds");
                return;
            }
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                (sender as Button).Text = "Stop";
             else
                (sender as Button).Text = "Start";
        }

        private void ClearAllHeadersButton_Click(object sender, EventArgs e)
        {
            HeadersList.Items.Clear();
        }

        private void HeaderRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                HeadersList.Items.RemoveAt(HeadersList.SelectedIndex);
            }
            catch {
                MessageBox.Show("Pls, select item");
            }
        }

        private void WBClient_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
        }
        public void SenfRequest()
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
