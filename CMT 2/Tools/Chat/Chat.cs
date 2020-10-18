using CMT_2.BS;
using CMT_2.Engine;
using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CMT_2.Tools.Chat
{
    public partial class Chat : Form
    {
        public JsonCore core = new JsonCore();
        public string Name;
        private static readonly Uri FuncUrl = new Uri("https://us-central1-crafterminecraftertool.cloudfunctions.net/funcs");
        private static readonly Uri ChatUrl = new Uri("https://crafterminecraftertool.firebaseio.com/Chat.json");
        private WebClient webRead;
        private WebClient webWrite;
        public Chat()
        {
            InitializeComponent();
            webRead = new WebClient();
            webWrite = new WebClient();
            this.ChatBox.TextChanged += (sender, e) =>
            {
                if (ChatBox.Visible)
                {
                    ChatBox.SelectionStart = ChatBox.TextLength;
                    ChatBox.ScrollToCaret();
                }
            };
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
            try
            {
                if (InputBox.Text.Contains("|"))
                {
                    InputBox.Clear();
                    return;
                }
                if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(InputBox.Text))
                {
                    webWrite.Headers.Clear();
                    webWrite.Headers.Add("req", "1" + '|' + Name + '|' + InputBox.Text.Replace("\"", "\\\"") + '|' + UHWID.IDsManager.id[3]);
                    webWrite.DownloadStringAsync(FuncUrl);
                    InputBox.Clear();
                }
            } catch
            {
                InputBox.Clear();
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ChatBox.Text = core.JsonToText(await webRead.DownloadStringTaskAsync(ChatUrl));
            }
            catch
            {
            }
        }

    }
}
