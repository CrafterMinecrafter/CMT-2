using CMT_2.BS;
using CMT_2.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMT_2.Tools.Code_Tools
{
    public partial class CodeTools : Form
    {
        public CodeTools()
        {
            InitializeComponent();
        }
        #region Base64buttons
        private void Enc_Button_Click(object sender, EventArgs e)
        {
            try
            {
                EncBox.Text = Utils.ToBase64(DecBox.Text);
            }
            catch
            {
                MessageBox.Show("Is not base64 string");
            }
        }

        private void Dec_button_Click(object sender, EventArgs e)
        {
            try
            {
                DecBox.Text = Utils.FromBase64(EncBox.Text);
            }
            catch
            {
                MessageBox.Show("Unkown Error");
            }
        }
        #endregion. 
        private void SelectFile_Click(object sender, EventArgs e)
        {  
            if(string.IsNullOrEmpty(VarName.Text))
            {
                MessageBox.Show("Enter variable name");
                return;
            }
            var File = FileTools.OpenFile();
            if(File == null)
            {
                return;
            }
          
            if (FileToBase64.Checked)
                OutputBox.Text = $"public static string {VarName.Text} = \"{Utils.ToBase64File(File)}\";";
            else
                OutputBox.Text = $"public static byte[] {VarName.Text} = new byte[]\n {Utils.FileToCodeArray(File)};";
        }

        private void CodeTools_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
        }

    }
}
