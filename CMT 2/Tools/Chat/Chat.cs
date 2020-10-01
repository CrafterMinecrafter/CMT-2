using CMT_2.Engine;
using System;
using System.Net;
using System.Windows.Forms;

namespace CMT_2.Tools.Chat
{

    public partial class Chat : Form
    { 
        private WebClient web;

        public Chat()
        {
            InitializeComponent();
            web = new WebClient(); 
        }
      
        private void Chat_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
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
        
        private async void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
