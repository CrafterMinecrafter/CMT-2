using System.Text;

namespace UHWID
{
    public static class IDsManager
    {
        /// <summary>
        ///  0 - DiskID
        /// | 1 - CpuID
        /// | 2 - WindowsID
        /// | 3 - CPU+WindowsID
        /// </summary>
        public static string[] id { get; private set; }

        public static void init()
        {
            id = new string[] { DiskId.GetDiskId(), CpuId.GetCpuId(), WindowsId.GetWindowsId(), null };
            using (var md5 = System.Security.Cryptography.MD5.Create())
                id[3] = System.BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(id[1] + id[2]))).Replace("-", string.Empty);
        }
    }
}