using CMT_2.BS;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
        public static string OpenFolder()
        {
            using (var diag = new FolderBrowserDialog())
            {
                diag.ShowNewFolderButton = true;
                if (diag.ShowDialog() == DialogResult.OK)
                    return diag.SelectedPath;
            }
            return null;
        }
        public static Image FileToImage(string Path)
        {
            var bitmap = new Bitmap(30, 30);
            var Rand = new Random(BitConverter.ToInt32(Utils.MD5FileV(Path), 0));
            for (int x = 29; x >= 0; x--)
            {
                for (int y = 29; y >= 0; y--)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(Convert.ToInt32("FF" + Convert.ToString(Rand.Next(0, 16777215), 16), 16)));
                }
            }
            return Image.FromHbitmap(bitmap.GetHbitmap());
        }

        public static void AddBytes(string path, long length)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Write))
                fs.SetLength(fs.Length + length);
        }
        public static long GetLength(string Path)
        {
            return new FileInfo(Path).Length;
        }

        public static void SetDate(string Path, DateTime data)
        {
            File.SetCreationTime(Path, data);
            File.SetLastWriteTime(Path, data);
            File.SetLastAccessTime(Path, data);
        }


    }
}
