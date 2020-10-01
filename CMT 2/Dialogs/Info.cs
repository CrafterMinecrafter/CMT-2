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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
            IDbox.Text = IDsManager.id[3];
            label2.Text = Application.OpenForms[0].Text + ' ' + Application.ProductVersion;
            GetPro_button.Visible = !Main.IsPro;
        }

        private void GetPro_button_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/o_privet_t");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCyJfMzp4DSty_O--W4ezHKw");
        }
    }
}
