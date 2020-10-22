using System;
using System.Drawing;
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
