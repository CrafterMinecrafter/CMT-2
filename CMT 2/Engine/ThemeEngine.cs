using CMT_2.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            }
            #region form
            public static Color Dark_Form_BackColor;
            public static Color Light_Form_BackColor;
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
            
            #endregion
        }

        /// <summary>
        /// 0 is white theme ||| 1 is dark theme
        /// </summary>
        /// <param name="black"></param>
        public static void SetTheme(bool ISdark)
        {
            Control.ControlCollection control;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (ISdark)
                    Application.OpenForms[i].BackColor = settingsClass.Dark_Form_BackColor;
                else
                    Application.OpenForms[i].BackColor = settingsClass.Light_Form_BackColor;

                control = Application.OpenForms[i].Controls;
                for (int CI = 0; CI<control.Count; CI++)
                {
                    if (control[CI].GetType() == new Button().GetType())
                    {
                        if (ISdark)
                        {
                            (control[CI] as Button).BackColor = Color.Black;
                            (control[CI] as Button).FlatAppearance.BorderColor = Color.DarkKhaki;
                            (control[CI] as Button).ForeColor = settingsClass.Light_Label_ForeColor;
                        }
                        else
                        {

                            (control[CI] as Button).BackColor = Color.White;
                            (control[CI] as Button).FlatAppearance.BorderColor = Color.Black;
                            (control[CI] as Button).ForeColor = settingsClass.Dark_Label_ForeColor;
                        }
                    }
                    if (control[CI].GetType() == new Label().GetType())
                    {
                        if (ISdark)
                            (control[CI] as Label).ForeColor = settingsClass.Light_Label_ForeColor;
                        else
                            (control[CI] as Label).ForeColor = settingsClass.Dark_Label_ForeColor;
                    }

                }
            }
        }
        public static void InitTheme(Form form)
        {
            if (Settings.ThemeIsDark)
                form.BackColor = Color.FromArgb(35, 39, 42);
            else
                form.BackColor = SystemColors.Control;

            var control = form.Controls;
            for (int CI = 0; CI < control.Count; CI++)
            {

                if (control[CI].GetType() == new Button().GetType())
                {
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
                if (control[CI].GetType() == new Label().GetType())
                {
                    if (Settings.ThemeIsDark)
                        (control[CI] as Label).ForeColor = settingsClass.Light_Label_ForeColor;
                    else
                        (control[CI] as Label).ForeColor = settingsClass.Dark_Label_ForeColor;
                }
                if (control[CI].GetType() == new TextBox().GetType())
                {

                }


            }
        }
    }

}
