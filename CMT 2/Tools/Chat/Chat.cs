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

namespace CMT_2.Tools.Chat
{
   
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }
        private static WebClient web;

        private void Chat_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
            web.DownloadStringCompleted += Web_DownloadStringCompleted;
            web = new WebClient();
        }

        private void Web_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                web.Headers.Add("f", "1");
                web.Headers.Add("id", UHWID.IDsManager.id[3]);
                web.Headers.Add("cm", InputBox.Text);
                web.DownloadString("https://us-central1-api-project-912345123.cloudfunctions.net/functions");
            }
        }
        private string buffer = "";
        private async Task UpdateMSGS()
        {
            web.DownloadStringAsync(new Uri("https://api-project-912345123.firebaseio.com/Chat.json"));
        }

        

        public async void send()
        {
            
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            await UpdateMSGS();
        }
    }
}
