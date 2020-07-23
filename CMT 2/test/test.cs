using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMT_2.test
{
    public partial class test : Form
    {
        public test(Color formcol, Color buttoncol, Color buttonbordcol, Color textboxcol, Color labelcol)
        {
            InitializeComponent(formcol, buttoncol, buttonbordcol, textboxcol, labelcol);
        }

        private void test_Load(object sender, EventArgs e)
        {

        }
    }
}
