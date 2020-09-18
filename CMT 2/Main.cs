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
        #region *******Vars*******
        public static bool IsPro;
        public static string CMTFolder = Path.GetPathRoot(Environment.SystemDirectory) + "/CrafterMinecrafter Tool/" + Environment.UserName + '/';
        private string[] dlls = new string[3]; //3-1 is selected file in no file mode
        #endregion

        public Main()
        {
            InitializeComponent();
        }
        #region Main
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
            new CMT_2.Dialogs.FileInfo(Main.CMTFolder + "/RememberedXORKeys.cmt").ShowDialog();


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
        #endregion
        #region Open Buttons
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
        private void Chat_button_Click(object sender, EventArgs e)
        {
            new Chat().Show();
        }

        #endregion


        #region File Panel       
        private void File1_Click(object sender, EventArgs e)
        {
            string f = FileTools.OpenFile();
            if (f == null) return;
            dlls[0] = f;
            File1.Image = FileTools.FileToImage(f);
            File1_label.Text = Path.GetFileName(f);
            if (dlls[0] != null & dlls[1] != null)
                BytesCount_Label.Text = "Sum:" + (FileTools.GetLength(dlls[0]) - FileTools.GetLength(dlls[1]));

        }
        private void File2_Click(object sender, EventArgs e)
        {
            string f = FileTools.OpenFile();
            if (f == null) return;
            dlls[1] = f;
            File2.Image = FileTools.FileToImage(f);
            File2_label.Text = Path.GetFileName(f);
            if (dlls[0] != null & dlls[1] != null)
                BytesCount_Label.Text = "Sum:" + (FileTools.GetLength(dlls[0]) - FileTools.GetLength(dlls[1]));

        }
        private void AddBytesFile_button_Click(object sender, EventArgs e)
        {

            if (dlls[0] == null && dlls[1] == null)
            {
                MessageBox.Show("Pls select files");
                return;
            }
                FileTools.AddBytes(dlls[0], FileTools.GetLength(dlls[0]) - FileTools.GetLength(dlls[1]));
        }

        #endregion
        #region No File Panel
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FileMode.Visible = checkBox1.Checked;
            StringMode.Visible = !checkBox1.Checked;
        }
        private void File3_Click(object sender, EventArgs e)
        {
            string f = FileTools.OpenFile();
            if (f == null) return;
            dlls[2] = f;
            File3.Image = FileTools.FileToImage(f);
            File3_label.Text = Path.GetFileName(f);
        }
        private void Value_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OutputValue.Text = "" + (int.Parse(OneValue.Text.Replace(" ", "")) - int.Parse(TwoValue.Text.Replace(" ", "")));
            }
            catch { }
        }
        private void AddBytes_NoFIleMode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dlls[2])){
                MessageBox.Show("Error!\nFile not selected");
                return;
            }
            if (string.IsNullOrEmpty(OutputValue.Text))
            {
                MessageBox.Show("Error!\nNothing to write");
                return;
            }
            FileTools.AddBytes(dlls[2], long.Parse(OutputValue.Text.Trim(' ')));
        }

        #endregion

        #region trash cleaner
        private void TrashCleaner_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }
        #endregion


    }
}
