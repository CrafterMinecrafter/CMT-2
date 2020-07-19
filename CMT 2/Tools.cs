using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CMT_2
{
    class FileTools
    {
        public static void AddBytes(string Path, int length)
        {
            using (var fs = new FileStream(Path, FileMode.Open, FileAccess.Write))
                fs.SetLength(fs.Length + length);
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
