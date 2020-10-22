using CMT_2.BS;
using CMT_2.Engine;
using System;
using System.Windows.Forms;

namespace CMT_2.Dialogs
{
    public partial class FileInfo : Form
    {
        private FileInfo()
        {
            InitializeComponent();
        }
        readonly string F;
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
            FMD5.Text = Utils.MD5File(F);
            FPath.Text = FInfo.FullName;
            FPicture.Image = FileTools.FileToImage(F);
        }


    }
}
