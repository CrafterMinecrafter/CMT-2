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
            this.Text = Name;
            Box.Text = Text;
        }

        private void TextBoxDialog_Load(object sender, System.EventArgs e)
        {
            Engine.ThemeEngine.InitTheme(this);
        }
    }
} 
