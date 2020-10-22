using CMT_2.Dialogs;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMT_2.Engine
{
    class ThemeEngine
    {

        public static class settingsClass
        {
            static settingsClass()
            {
                #region font
                DefaultFont = new Font("Arial", 8f, GraphicsUnit.Point);
                #endregion
                #region button
                Dark_Button_BackColor = Color.Black;
                Dark_Button_BorderColor = Color.DarkKhaki;
                #endregion
                #region label
                Light_Label_ForeColor = Color.White;
                Dark_Label_ForeColor = Color.Black;
                #endregion
                #region form
                Dark_Form_BackColor = Color.FromArgb(35, 39, 42);
                Light_Form_BackColor = SystemColors.Control;
                #endregion
                #region textbox
                Dark_textbox_BackColor = Color.FromArgb(79, 84, 92);
                Light_textbox_BackColor = SystemColors.ControlLight;
                #endregion
            }
            public static void Reset()
            {
                #region font
                DefaultFont = new Font("Arial", 8f, GraphicsUnit.Point);
                #endregion
                #region button
                Dark_Button_BackColor = Color.Black;
                Dark_Button_BorderColor = Color.DarkKhaki;
                #endregion
                #region label
                Light_Label_ForeColor = Color.White;
                Dark_Label_ForeColor = Color.Black;
                #endregion
                #region form
                Dark_Form_BackColor = Color.FromArgb(35, 39, 42);
                Light_Form_BackColor = SystemColors.Control;
                #endregion
                #region textbox
                Dark_textbox_BackColor = Color.FromArgb(79, 84, 92);
                Light_textbox_BackColor = SystemColors.ControlLight;
                #endregion
            }
            #region form
            public static Color Dark_Form_BackColor;
            public static Color Light_Form_BackColor;
            #endregion
            #region font
            public static Font DefaultFont;
            #endregion
            #region button
            public static Color Dark_Button_BackColor;
            public static Color Dark_Button_BorderColor;
            #endregion
            #region label
            public static Color Dark_Label_ForeColor;
            public static Color Light_Label_ForeColor;
            #endregion
            #region textbox
            public static Color Dark_textbox_BackColor;
            public static Color Light_textbox_BackColor;
            #endregion
        }

        /// <summary>
        /// set theme in all forms
        /// </summary>
        public static async void SetTheme()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Settings.ThemeIsDark)
                    Application.OpenForms[i].BackColor = settingsClass.Dark_Form_BackColor;
                else
                    Application.OpenForms[i].BackColor = settingsClass.Light_Form_BackColor;
                await InitTheme(Application.OpenForms[i].Controls);
            }
        }

        private static async Task<bool> InitTheme(Control.ControlCollection control)
        {
            if (Settings.ThemeIsDark)
                for (int CI = control.Count - 1; CI >= 0; CI--)
                {
                    #region button
                    if (control[CI].GetType() == typeof(Button))
                    {
                        (control[CI] as Button).Font = settingsClass.DefaultFont;
                        (control[CI] as Button).BackColor = settingsClass.Dark_Button_BackColor;
                        (control[CI] as Button).FlatAppearance.BorderColor = settingsClass.Dark_Button_BorderColor;
                        (control[CI] as Button).ForeColor = settingsClass.Light_Label_ForeColor;
                    }
                    #endregion
                    #region label
                    if (control[CI].GetType() == typeof(Label))
                    {
                        (control[CI] as Label).Font = settingsClass.DefaultFont;
                        (control[CI] as Label).ForeColor = settingsClass.Light_Label_ForeColor;
                    }
                    #endregion
                    #region textbox
                    if (control[CI].GetType() == typeof(TextBox))
                    {
                        (control[CI] as TextBox).Font = settingsClass.DefaultFont;
                        (control[CI] as TextBox).BackColor = settingsClass.Dark_textbox_BackColor;
                        (control[CI] as TextBox).ForeColor = settingsClass.Light_Label_ForeColor;
                    }
                    #endregion
                    #region Panel
                    if (control[CI].GetType() == typeof(Panel))
                    {
                        (control[CI] as Panel).Font = settingsClass.DefaultFont;
                        (control[CI] as Panel).BackColor = settingsClass.Dark_Form_BackColor;
                        (control[CI] as Panel).ForeColor = settingsClass.Light_Label_ForeColor;
                        await InitTheme((control[CI] as Panel).Controls);
                    }
                    #endregion
                    #region ComboBox
                    if (control[CI].GetType() == typeof(ComboBox))
                    {
                        (control[CI] as ComboBox).Font = settingsClass.DefaultFont;
                        (control[CI] as ComboBox).BackColor = settingsClass.Dark_textbox_BackColor;
                        (control[CI] as ComboBox).ForeColor = settingsClass.Light_Label_ForeColor;
                        InitTheme((control[CI] as ComboBox).Controls);
                    }
                    #endregion
                    #region CheckBox
                    if (control[CI].GetType() == typeof(CheckBox))
                    {
                        (control[CI] as CheckBox).Font = settingsClass.DefaultFont;
                        (control[CI] as CheckBox).ForeColor = settingsClass.Light_Label_ForeColor;
                    }
                    #endregion
                }
            else
                for (int CI = control.Count - 1; CI >= 0; CI--)
                {
                    #region button
                    if (control[CI].GetType() == typeof(Button))
                    {
                        (control[CI] as Button).Font = settingsClass.DefaultFont;
                        (control[CI] as Button).BackColor = Color.White;
                        (control[CI] as Button).FlatAppearance.BorderColor = Color.Black;
                        (control[CI] as Button).ForeColor = settingsClass.Dark_Label_ForeColor;
                    }
                    #endregion
                    #region label
                    if (control[CI].GetType() == typeof(Label))
                    {
                        (control[CI] as Label).Font = settingsClass.DefaultFont;
                        (control[CI] as Label).ForeColor = settingsClass.Dark_Label_ForeColor;
                    }
                    #endregion
                    #region textbox
                    if (control[CI].GetType() == typeof(TextBox))
                    {
                        (control[CI] as TextBox).Font = settingsClass.DefaultFont;
                        (control[CI] as TextBox).BackColor = settingsClass.Light_textbox_BackColor;
                        (control[CI] as TextBox).ForeColor = settingsClass.Dark_Label_ForeColor;

                    }
                    #endregion
                    #region Panel
                    if (control[CI].GetType() == typeof(Panel))
                    {
                        (control[CI] as Panel).BackColor = settingsClass.Light_Form_BackColor;
                        (control[CI] as Panel).ForeColor = settingsClass.Dark_Label_ForeColor;
                        await InitTheme((control[CI] as Panel).Controls);
                    }
                    #endregion
                    #region ComboBox
                    if (control[CI].GetType() == typeof(ComboBox))
                    {
                        (control[CI] as ComboBox).Font = settingsClass.DefaultFont;
                        (control[CI] as ComboBox).BackColor = settingsClass.Light_textbox_BackColor;
                        (control[CI] as ComboBox).ForeColor = settingsClass.Dark_Label_ForeColor;
                        InitTheme((control[CI] as ComboBox).Controls);
                    }
                    #endregion
                    #region CheckBox
                    if (control[CI].GetType() == typeof(CheckBox))
                    {
                        (control[CI] as CheckBox).Font = settingsClass.DefaultFont;
                        (control[CI] as CheckBox).ForeColor = settingsClass.Dark_Label_ForeColor;

                    }
                    #endregion
                }
            return true;
        }



        /// <summary>
        /// set theme in form
        /// </summary>
        public static async Task<bool> InitTheme(Form form)
        {
            #region form
            if (form.Name != "Main")
            {
                form.Text = Application.OpenForms[0].Text + " | " + form.Text;
                form.Icon = Application.OpenForms[0].Icon;
            }
            form.Font = settingsClass.DefaultFont;
            if (Settings.ThemeIsDark)
                form.BackColor = settingsClass.Dark_Form_BackColor;
            else
                form.BackColor = settingsClass.Light_Form_BackColor;
            #endregion
            await InitTheme(form.Controls);
            return true;
        }
    }
}
