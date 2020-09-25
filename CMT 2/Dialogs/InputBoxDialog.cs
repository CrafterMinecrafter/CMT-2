using System.Windows.Forms;

namespace CMT_2.Dialogs
{
    public partial class TextBoxDialog : Form
    {
        public TextBoxDialog()
        {
            InitializeComponent();
        }
        public TextBoxDialog(string Text, string Name)
        {
            InitializeComponent();
            this.Name = Name;
            Box.Text = Text;
        }
    }
} 
