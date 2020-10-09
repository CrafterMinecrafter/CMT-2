using CMT_2.BS;
using CMT_2.Dialogs;
using CMT_2.Engine;
using CMT_2.Tools;
using CMT_2.Tools.Chat;
using CMT_2.Tools.Code_Tools;
using CMT_2.Tools.Hashs;
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

        public static List<string[]> WebData = new List<string[]>();
        public static bool IsPro;
        public static string CMTFolder = Path.GetPathRoot(Environment.SystemDirectory) + "/CrafterMinecrafter Tool/" + Environment.UserName + '/';
        private string[] dlls = new string[3]; //3-1 is selected file in StringMode
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
                    var str = wb.DownloadString("https://ideone.com/plain/h42QvK");
                    WebData.Add(str.Trim('\n').Split('|'));
                    WebData.Add(wb.DownloadString("https://ideone.com/plain/bAROiC").Split('|'));
                    if (str.Contains(IDsManager.id[3]))
                    {
                        IsPro = true;
                        Text = "CrafterMinecrafter Tool Pro";
                    }
                    else
                    {
                        IsPro = false;
                        Text = "CrafterMinecrafter Tool Community";
                    }
                    if (WebData[1][2] == "1" && !str.Contains(IDsManager.id[3]))
                    {
                        IsPro = true;
                        Text = "CrafterMinecrafter Tool Pro(demo)";
                    }
                    if (WebData[1][0] != ProductVersion)
                    {
                        this.Controls.Clear();
                        Process.Start(Utils.FromBase64(WebData[1][1]));
                        MessageBox.Show("PLS Update Version\nUpdate link opened in browser");
                        Application.Exit();
                        return;
                    }
                    
                }
                #endregion
                #region проверка на нужные файлы настроек
                if (!File.Exists(CMTFolder + "RememberedXORKeys.cmt") || !File.Exists(CMTFolder + "RememberedAESKeys.cmt"))
                {
                    File.CreateText(Directory.CreateDirectory(CMTFolder).FullName + "/RememberedXORKeys.cmt").Close();
                    File.CreateText(Directory.CreateDirectory(CMTFolder).FullName + "/RememberedAESKeys.cmt").Close();
                }
                CMT_2.Properties.Settings.Default.Reload();
                #endregion
            }
            catch
            {
                this.Controls.Clear();
                Application.Exit();
            }
            #region загружаем настройки темы.
            if (IsPro)
            {
                try
                {
                    if(!string.IsNullOrEmpty(Properties.Settings.Default.customSettings))
                    ThemeSettings.ToSettings();
                }
                catch
                {
                    MessageBox.Show("Error in saved theme");
                }
            }
            #endregion
            #region Загрузка ключей XOR
            try
            {
                string[] KeysConfigs = new string[] {
                File.ReadAllText(CMTFolder + "RememberedXORKeys.cmt"),
                File.ReadAllText(CMTFolder + "RememberedAESKeys.cmt")
                    };
                if (!string.IsNullOrEmpty(KeysConfigs[0]))
                {
                    string[] XORKeys = KeysConfigs[0].Split('§');
                    for (int i = XORKeys.Length - 1; i >= 0; i--)
                    {
                        Tools.XOR.Keys.Add(XORKeys[i]);
                    }
                }
                if (!string.IsNullOrEmpty(KeysConfigs[1]))
                {
                    string[] AESKeys = KeysConfigs[1].Split('§');
                    for (int i = AESKeys.Length - 1; i >= 0; i--)
                    {
                        Tools.AES.Keys.Add(AESKeys[i]);
                    }
                }
            }
            catch
            {
                File.Delete(CMTFolder + "RememberedXORKeys.cmt");
                File.Delete(CMTFolder + "RememberedAESKeys.cmt");
                MessageBox.Show("Failed to load XOR/AES deleted\nRestart program");
                Application.Exit();
            }
            #endregion
            ThemeEngine.InitTheme(this);

        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string buffer = "";
            for (int i = Tools.XOR.Keys.Count - 1; i >= 0; i--)
                if (!string.IsNullOrWhiteSpace(Tools.XOR.Keys[i]))
                    buffer += Tools.XOR.Keys[i] + "§";
            File.WriteAllText(CMTFolder + "RememberedXORKeys.cmt", buffer);
            buffer = "";
            for (int i = Tools.AES.Keys.Count - 1; i >= 0; i--)
                if (!string.IsNullOrWhiteSpace(Tools.AES.Keys[i]))
                    buffer += Tools.AES.Keys[i] + "§";
            File.WriteAllText(CMTFolder + "RememberedAESKeys.cmt", buffer);
        }
        #endregion
        #region Open Buttons  
        private void OpenAes_button_Click(object sender, EventArgs e)
        {
            new AES().Show();
        }  
        private void OpenInfo_Button_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }
        private void OpenChangelog_button_Click(object sender, EventArgs e)
        {
            using (var web = new WebClient())
            {
                new TextBoxDialog(BS.Utils.FromBase64(web.DownloadString("https://ideone.com/plain/4ZGclz")), "Changelog").ShowDialog();
            }
        }
        private void OpenMD5_button_Click(object sender, EventArgs e)
        {
            new Hashs().Show();
        }
        private void OpenSettings_button_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void OpenXOR_Click(object sender, EventArgs e)
        {
            new XOR().Show();
        }
        private void OpenChat_button_Click(object sender, EventArgs e)
        {
            new Chat().Show();
        }
        private void OpenCodeTools_Button_Click(object sender, EventArgs e)
        {
            new CodeTools().Show();
        }
        #endregion
        #region File Regions
        #region File
        private void File_Click(object sender, MouseEventArgs e, Label File_label, int dll)
        {
            #region правая Кнопка мышки
            if (e.Button == MouseButtons.Right && dlls[dll] != null)
            {
                new CMT_2.Dialogs.FileInfo(dlls[dll]).Show();
            }
            #endregion
            #region Левая Кнопка Мышки
            if (e.Button == MouseButtons.Left)
            {
                string f = FileTools.OpenFile();
                if (f == null) return;
                dlls[dll] = f;
                (sender as PictureBox).Image = FileTools.FileToImage(f);
                File_label.Text = Path.GetFileName(f);
                if (checkBox1.Checked && dlls[0] != null & dlls[1] != null)
                    BytesCount_Label.Text = "Sum:" + (FileTools.GetLength(dlls[0]) - FileTools.GetLength(dlls[1]));
            }
            #endregion

        }
        #endregion
        #region File Panel       
        private void File1_Click(object sender, MouseEventArgs e)
        {
            File_Click(sender, e, File1_label, 0);
        }
        private void File2_Click(object sender, MouseEventArgs e)
        {
            File_Click(sender, e, File2_label, 1);
        }
        private void AddBytesFile_button_Click(object sender, EventArgs e)
        {

            if (dlls[0] == null && dlls[1] == null)
            {
                MessageBox.Show("Pls select files");
                return;
            }
            try
            {
                FileTools.AddBytes(dlls[0], FileTools.GetLength(dlls[0]) - FileTools.GetLength(dlls[1]));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
            MessageBox.Show(FileTools.GetLength(dlls[0]) - FileTools.GetLength(dlls[1]) + " Bytes added to file \"" + Path.GetFileName(dlls[2]) + '"');
        }

        #endregion
        #region String Panel
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FileMode.Visible = checkBox1.Checked;
            StringMode.Visible = !checkBox1.Checked;
        }
        private void File3_Click(object sender, MouseEventArgs e)
        {
            File_Click(sender, e, File3_label, 2);
        }
        private void Value_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OutputValue.Text = "" + (int.Parse(OneValue.Text.Replace(" ", "")) - int.Parse(TwoValue.Text.Replace(" ", "")));
            }
            catch { }
        }
        private void AddBytes_StringMode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dlls[2]))
            {
                MessageBox.Show("Error!\nFile not selected");
                return;
            }
            if (string.IsNullOrEmpty(OutputValue.Text))
            {
                MessageBox.Show("Error!\nNothing to write");
                return;
            }
            long result;
            if (!long.TryParse(OutputValue.Text.Trim(' '), out result))
            {
                MessageBox.Show("Parsing error");
                return;
            }
            try
            {
                FileTools.AddBytes(dlls[2], result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
                return;
            }
            MessageBox.Show(result + " Bytes added to file \"" + Path.GetFileName(dlls[2]) + '"');
        }

        #endregion
        #endregion
        #region trash cleaner
        private void TrashCleaner_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        #endregion

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox2.Checked;
        }

        #region DateTool
        private void SetDateInFile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                FileTools.SetDate(FileTools.OpenFile(), dateTimePicker1.Value);
            }
            catch
            {
            }
        }
        private void SetDateInFolder_button_Click(object sender, EventArgs e)
        {
            string[] dirFiles;
            try
            {
                dirFiles = Directory.GetFiles(FileTools.OpenFolder());
            }
            catch
            {
                return;
            }
            for (int i = dirFiles.Length - 1; i >= 0; i--)
            {
                FileTools.SetDate(dirFiles[i], dateTimePicker1.Value);
            }
        }

        private void SelectedTool_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).SelectedIndex)
            {
                case 0:
                    {
                        ByteTool.Visible = true;
                        DateTool.Visible = false;
                        break;
                    }
                case 1:
                    {
                        ByteTool.Visible = false;
                        DateTool.Visible = true;
                        break;
                    }
            }
            label_SelectedTool.Text = SelectedTool.Text + ':';
        }

      
    }

    #endregion


}