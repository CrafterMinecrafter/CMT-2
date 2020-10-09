using CMT_2.BS;
using CMT_2.Engine;
using System;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMT_2.Tools.Chat
{

    public partial class Chat : Form
    {
        public string Name;
        private static readonly Uri url = new Uri("https://us-central1-crafterminecraftertool.cloudfunctions.net/funcs");
        private WebClient web;

        public Chat()
        {
            InitializeComponent();
            web = new WebClient();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
            bool IsActive = false;
            for (int i = Main.WebData[0].Length - 1; i >= 0; i--)
            {
                if (Main.WebData[0][i].Contains(UHWID.IDsManager.id[3]))
                {
                    IsActive = true;
                    Name = Main.WebData[0][i - 1];
                }
            }
            if (!IsActive)
            {
                InputBox.Enabled = false;
                InputBox.Text = "To send messages needed pro version (not trial)";
            }
        }

        private async void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (InputBox.Text.Contains("|"))
            {
                InputBox.Clear();
                return;
            }
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(InputBox.Text))
            {
                web.Headers.Clear();
                web.Headers.Add("req", "1" + '|' + Name + '|' + InputBox.Text + '|' + UHWID.IDsManager.id[3]);
                MessageBox.Show(web.DownloadString(url));
                InputBox.Clear();
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            // web.DownloadStringAsync()
        }
    }
}
