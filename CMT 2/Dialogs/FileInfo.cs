using CMT_2.BS;
using CMT_2.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UHWID;

namespace CMT_2.Dialogs
{
    public partial class FileInfo : Form
    {
        private FileInfo()
        {
            InitializeComponent();
        }
        string F;
        public FileInfo(string path)
        {
            InitializeComponent();
            F = path;
        }

        private void FileInfo_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
            var FInfo = new System.IO.FileInfo(F);
            FName.Text = FInfo.Name;
            FSize.Text = "" + FInfo.Length;
            FCreateData.Text = FInfo.CreationTime.ToString();
            FMD5.Text = new Utils().MD5File(F);
            FPath.Text = FInfo.FullName;
            FPicture.Image = FileTools.FileToImage(F);
        }


    }
}
