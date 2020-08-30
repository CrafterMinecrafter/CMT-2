using CMT_2.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
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
                DefaultFont = new Font("Arial",  8f, GraphicsUnit.Point);
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
        /// 0 is white theme ||| 1 is dark theme
        /// </summary>
        public static void SetTheme(bool ISdark)
        {
            Control.ControlCollection control;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                #region form
                Application.OpenForms[i].Font = settingsClass.DefaultFont;
                if (ISdark)
                    Application.OpenForms[i].BackColor = settingsClass.Dark_Form_BackColor;
                else
                    Application.OpenForms[i].BackColor = settingsClass.Light_Form_BackColor;
                #endregion
                control = Application.OpenForms[i].Controls;
                for (int CI = 0; CI < control.Count; CI++)
                {
                    #region button
                    if (control[CI].GetType() == new Button().GetType())
                    {
                        (control[CI] as Button).Font = settingsClass.DefaultFont;
                        if (ISdark)
                        {
                            (control[CI] as Button).BackColor = settingsClass.Dark_Button_BackColor;
                            (control[CI] as Button).FlatAppearance.BorderColor = settingsClass.Dark_Button_BorderColor;
                            (control[CI] as Button).ForeColor = settingsClass.Light_Label_ForeColor;
                        }
                        else
                        {

                            (control[CI] as Button).BackColor = Color.White;
                            (control[CI] as Button).FlatAppearance.BorderColor = Color.Black;
                            (control[CI] as Button).ForeColor = settingsClass.Dark_Label_ForeColor;
                        }
                    }
                    #endregion
                    #region label
                    if (control[CI].GetType() == new Label().GetType())
                    {
                        (control[CI] as Label).Font = settingsClass.DefaultFont;
                        if (ISdark)
                            (control[CI] as Label).ForeColor = settingsClass.Light_Label_ForeColor;
                        else
                            (control[CI] as Label).ForeColor = settingsClass.Dark_Label_ForeColor;
                    }
                    #endregion
                    #region textbox
                    if (control[CI].GetType() == new TextBox().GetType())
                    {
                        (control[CI] as TextBox).Font = settingsClass.DefaultFont;
                        if (Settings.ThemeIsDark)
                        {
                            (control[CI] as TextBox).BackColor = settingsClass.Dark_textbox_BackColor;
                            (control[CI] as TextBox).ForeColor = settingsClass.Light_Label_ForeColor;
                        }
                        else
                        {
                            (control[CI] as TextBox).BackColor = settingsClass.Light_textbox_BackColor;
                            (control[CI] as TextBox).ForeColor = settingsClass.Dark_Label_ForeColor;
                        }
                    }
                    #endregion
                }
            }
        }

        public static void InitTheme(Form form)
        {

            #region form

            form.Font = settingsClass.DefaultFont;
            if (Settings.ThemeIsDark)
                form.BackColor = settingsClass.Dark_Form_BackColor;
            else
                form.BackColor = settingsClass.Light_Form_BackColor;
            #endregion
            var control = form.Controls;
            for (int CI = 0; CI < control.Count; CI++)
            {

                #region button
                if (control[CI].GetType() == new Button().GetType())
                {
                    (control[CI] as Button).Font = settingsClass.DefaultFont;
                    if (Settings.ThemeIsDark)
                    {
                        (control[CI] as Button).BackColor = settingsClass.Dark_Button_BackColor;
                        (control[CI] as Button).FlatAppearance.BorderColor = settingsClass.Dark_Button_BorderColor;
                        (control[CI] as Button).ForeColor = settingsClass.Light_Label_ForeColor;
                    }
                    else
                    {
                        (control[CI] as Button).BackColor = Color.White;
                        (control[CI] as Button).FlatAppearance.BorderColor = Color.Black;
                        (control[CI] as Button).ForeColor = settingsClass.Dark_Label_ForeColor;
                    }
                }
                #endregion
                #region label
                if (control[CI].GetType() == new Label().GetType())
                {
                    (control[CI] as Label).Font = settingsClass.DefaultFont;
                    if (Settings.ThemeIsDark)
                        (control[CI] as Label).ForeColor = settingsClass.Light_Label_ForeColor;
                    else
                        (control[CI] as Label).ForeColor = settingsClass.Dark_Label_ForeColor;
                }
                #endregion
                #region textbox
                if (control[CI].GetType() == new TextBox().GetType())
                {
                    (control[CI] as TextBox).Font = settingsClass.DefaultFont;
                    if (Settings.ThemeIsDark)
                    {
                        (control[CI] as TextBox).BackColor = settingsClass.Dark_textbox_BackColor;
                        (control[CI] as TextBox).ForeColor = settingsClass.Light_Label_ForeColor;
                    }
                    else
                    {
                        (control[CI] as TextBox).BackColor = settingsClass.Light_textbox_BackColor;
                        (control[CI] as TextBox).ForeColor = settingsClass.Dark_Label_ForeColor;
                    }
                }
                #endregion

            }
        }
    }

}
