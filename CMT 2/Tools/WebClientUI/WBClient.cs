using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMT_2.Tools.WebClientUI
{
    public partial class WBClient : Form
    {
        public WBClient()
        {
            InitializeComponent();
        }

        private void AddHeaderButton_Click(object sender, EventArgs e)
        {
            HeadersList.Items.Add(HeaderBox.Text);
        }
    }
}
