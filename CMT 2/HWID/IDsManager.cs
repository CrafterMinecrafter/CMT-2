namespace UHWID
{
    public static class IDsManager
    {
        /// <summary>
        /// 0 - DiskID
        /// 1 - CpuID
        /// 2 - WindowsID
        /// </summary>
        public static string[] id { get; private set; }

        static IDsManager()
        {
            id = new string[] { DiskId.GetDiskId(), CpuId.GetCpuId(), WindowsId.GetWindowsId() };
        }
    }
}