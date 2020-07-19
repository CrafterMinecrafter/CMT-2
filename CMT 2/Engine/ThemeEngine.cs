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
        /// <summary>
        /// 0 is white theme ||| 1 is dark theme
        /// </summary>
        private static Button_style[] Button_Styles = new Button_style[]
        {
            new Button_style(Color.FromName("black"), Color.FromName("white")),
            new Button_style(Color.FromName("white"),  Color.FromName("black"))
        };
        /// <summary>
        /// 0 is white theme ||| 1 is dark theme
        /// </summary>
        /// <param name="black"></param>
         public static void SetTheme(bool ISdark)
        {
            Control.ControlCollection control;
            for (int i = Application.OpenForms.Count; i > 0; i--)
            {
                control = Application.OpenForms[i].Controls;
                for(int CI = control.Count;i>0;i--)
                {
                    if(control[CI].GetType() == new Button().GetType())
                    {

                        (control[CI] as Button).ForeColor = Button_Styles[Convert.ToInt32(ISdark)].ForeColor;
                        (control[CI] as Button).FlatAppearance.BorderColor = Button_Styles[Convert.ToInt32(ISdark)].Line;

                    }
                }
            }
        }
        private class Button_style
        {
            public Button_style(Color ForeCol, Color line)
            {
                ForeColor = ForeCol;
                Line = line;
            } 
            
            public Color ForeColor;
            public Color Line;
        }
    }
    
}
