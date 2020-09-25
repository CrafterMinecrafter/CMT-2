using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMT_2.BS;
namespace CMT_2.Tools.MD5
{
    public partial class Hashs : Form
    {
        public Hashs()
        {
            InitializeComponent();
        }

        private void Hashs_Load(object sender, EventArgs e)
        {
            Engine.ThemeEngine.InitTheme(this);
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            switch (SelectedHash.SelectedIndex)
            {
                //MD5
                case 0:
                    {
                        hashBox.Text = Utils.MD5(textBox.Text);
                        break;
                    }
            }
        }
    }
}
