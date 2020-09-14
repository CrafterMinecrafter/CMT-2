using CMT_2.Dialogs;
using CMT_2.Engine;
using CMT_2.Tools;
using CMT_2.Tools.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using UHWID;

namespace CMT_2
{
    public partial class Main : Form
    {
        public static bool IsPro;
        public static string CMTFolder = Path.GetPathRoot(Environment.SystemDirectory) + "/CrafterMinecrafter Tool/";
        private string[] dlls = new string[2];
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                #region Проверка ID на про версию
                using (WebClient wb = new WebClient())
                {
                    if (wb.DownloadString("https://ideone.com/plain/bAROiC").Contains(IDsManager.id[3]))
                    {
                        IsPro = true;
                        Text = "CrafterMinecrafter Tool Pro";
                    }
                    else
                    {
                        IsPro = false;
                        Text = "CrafterMinecrafter Tool Community";
                    }
                }
                #endregion
                #region проверка на нужные файлы настроек
                if (!File.Exists(CMTFolder + "RememberedXORKeys.cmt") || File.Exists(CMTFolder + "RememberedAESKeys.cmt"))
                {
                    File.CreateText(Directory.CreateDirectory(CMTFolder).FullName + "/RememberedXORKeys.cmt").Close();
                    File.CreateText(Directory.CreateDirectory(CMTFolder).FullName + "/RememberedAESKeys.cmt").Close();
                }
                CMT_2.Properties.Settings.Default.Reload();
                #endregion
            }
            catch
            {
                Application.Exit();
            }
            #region загружаем настройки темы.
            if (IsPro)
            {
                try
                {
                    ThemeSettings.ToSettings();
                }
                catch
                {

                }
            }
            #endregion
            #region Загрузка ключей XOR
            string KeysConfig = File.ReadAllText(CMTFolder + "RememberedXORKeys.cmt");
            if (!string.IsNullOrEmpty(KeysConfig))
            {
                string[] XORKeys = KeysConfig.Split('\n');
                for (int i = XORKeys.Length - 1; i >= 0; i--)
                {
                    Tools.XOR.Keys.Add(XORKeys[i]);
                }
            }
            #endregion
            ThemeEngine.InitTheme(this);

        }

        private void Info_Button_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }

        private void OpenSettings_button_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void XOR_Click(object sender, EventArgs e)
        {
            new XOR().Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string buffer = "";
            for (int i = Tools.XOR.Keys.Count - 1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(Tools.XOR.Keys[i]))
                    buffer += Tools.XOR.Keys[i] + "\n";
            }
            File.WriteAllText(CMTFolder + "RememberedXORKeys.cmt", buffer);
        }

        private void Chat_button_Click(object sender, EventArgs e)
        {
            new Chat().Show();
        }

        private void File2_Click(object sender, EventArgs e)
        {
            string f = FileTools.OpenFile();
            if (f == null) return;
            dlls[1] = f;
            File1.Image = FileTools.FileToImage(f);
            File1_label.Text = Path.GetFileName(f);
        }

        private void File1_Click(object sender, EventArgs e)
        {
            string f = FileTools.OpenFile();
            if (f == null) return;
            dlls[0] = f;
            File1.Image = FileTools.FileToImage(f);
            File1_label.Text = Path.GetFileName(f);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
