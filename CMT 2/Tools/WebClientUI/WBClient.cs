using CMT_2.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMT_2.Tools.WebClientUI
{
    public partial class WBClient : Form
    {
        private WebClient Web = new WebClient();
        private Uri URL;
        private int RequestsInOneSecond;
        private WebHeaderCollection webHeaders = new WebHeaderCollection();
        public WBClient()
        {
            InitializeComponent();
            URLBox_TextChanged(URLBox, null);
            LogBox.TextChanged += (sender, e) =>
            {
                (sender as TextBox).SelectionStart = (sender as TextBox).TextLength;
                (sender as TextBox).ScrollToCaret();
            };
        }

        private void AddHeaderButton_Click(object sender, EventArgs e)
        {
            HeadersList.Items.Add(KeyHeaderBox.Text);
            webHeaders.Add(KeyHeaderBox.Text, ValueHeaderBox.Text);
        }

        private void TimerControlButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Val = int.Parse(MSIntervalBox.Text);
                if (Val < 1)
                {
                    MessageBox.Show("Minimal value 1");
                    return;
                }
                timer1.Interval = int.Parse(MSIntervalBox.Text);
            }
            catch
            {
                MessageBox.Show("Error, enter time in miliseconds");
                return;
            }
            timer1.Enabled = !timer1.Enabled;
            //RequestAnalitics.Enabled = timer1.Enabled && LogsEnabled.Checked;
            if (timer1.Enabled)
                (sender as Button).Text = "Stop";
            else
                (sender as Button).Text = "Start";

        }

        private void ClearAllHeadersButton_Click(object sender, EventArgs e)
        {
            HeadersList.Items.Clear();
            webHeaders.Clear();
        }

        private void HeaderRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                webHeaders.Remove(HeadersList.Text);
            }
            catch
            {
                MessageBox.Show("Pls, select item");
            }
        }

        private void WBClient_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
            Web = new WebClient();
        }
        private async void SendRequest()
        {
            var log = "";
            if (Web.IsBusy) return;
            try
            {
                Web.Headers = webHeaders;
                log = await Web.DownloadStringTaskAsync(URL);
            }
            catch (Exception ex)
            {
                log = ex.Message;
            }
            if (LogsEnabled.Checked)
             LogBox.Text += log + Environment.NewLine;
            RequestsInOneSecond++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SendRequest();
        }

        private void SendRequestButton_Click(object sender, EventArgs e)
        {
            SendRequest();
        }

        private void URLBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                URL = new Uri((sender as TextBox).Text);
            }
            catch { }
        }

        private void ClearLogs_Click(object sender, EventArgs e)
        {
            LogBox.Clear();
        }

        private void RequestAnalitics_Tick(object sender, EventArgs e)
        {
            RequestsInSec_label.Text = "Requests In Second:" + Environment.NewLine + RequestsInOneSecond;
            RequestsInOneSecond = 0;
        }
    }
}
