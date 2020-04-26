using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indexer2.DB;
using Indexer2.Models;

namespace Indexer2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirExtractor extract = new DirExtractor();
            extract.Execute(@"D:\Music");
            List<FileExtract> packed = extract.filesExtracted;

            if (SQLITE_DAL.Initialize())
            {
                foreach (FileExtract Fe in packed)
                {
                    SQLITE_DAL.InsertDFile(Fe);
                }
                try
                {
                    SQLITE_DAL.ReadData();
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
