using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Indexer2.DB;
using Indexer2.Models;

namespace Indexer2
{
    class Program
    {
        [DllImport("KERNEL32.DLL", EntryPoint = "SetProcessWorkingSetSize",
           SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize(IntPtr pProcess,
        int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

        static void Main(string[] args)
        {
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, int.MaxValue, int.MaxValue);

            Console.ReadKey();

            DirExtractor extract = new DirExtractor();
            extract.Execute(@"F:\");
            List<FileExtract> packed = extract.filesExtracted;

            try { SQLITE_DAL.CloseConnection(); } catch(Exception e){ ConsoleWriter.WriteWarning(e.Message); }
            if (SQLITE_DAL.Initialize())
            {
                foreach (FileExtract Fe in packed)
                {
                    SQLITE_DAL.InsertDFile(Fe);
                }
                try
                {
                    SQLITE_DAL.ReadData();
                    SQLITE_DAL.ReadOwners();
                }
                catch(Exception e)
                {
                    ConsoleWriter.WriteWarning(e.Message);
                }
            }
            else
            {
                ConsoleWriter.WriteWarning("FAILED INSERTION");
            }

            Console.ReadKey();
        }
    }
}
