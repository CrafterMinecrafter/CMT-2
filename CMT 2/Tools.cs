using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;
using CMT_2.BS;
using System.Linq;

namespace CMT_2
{
    class FileTools
    {
        public static string OpenFile()
        {
            using (FileDialog diag = new OpenFileDialog())
            {
                if (diag.ShowDialog() == DialogResult.OK)
                    return diag.FileName;
            }
            return null;
        }
        public static Image FileToImage(string Path)
        {
            var bitmap = new Bitmap(30, 30);
            var Rand = new Random(BitConverter.ToInt32(new Utils().MD5FileV(Path), 0)) ;
            for (int x = 30 - 1; x >= 0; x--)
            {
                for (int y = 30 - 1; y >= 0; y--)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(Convert.ToInt32("80"+Convert.ToString(Rand.Next(0, 16777215),16), 16)));
                }
            }
            return Image.FromHbitmap(bitmap.GetHbitmap());
        }
        
        public static void SetDate(string Path, DateTime data)
        {
            File.SetCreationTime(Path, data);
            File.SetLastWriteTime(Path, data);
            File.SetLastAccessTime(Path, data);
        }
        public static long GetLength(string Path)
        {
            return new FileInfo(Path).Length;
        }

    }
}
