using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer2
{
    public static class ConsoleWriter
    {
        public static void WriteNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(notification);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteWarning(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(notification);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteSeparator()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine(new string('-', Console.BufferWidth));
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteFileInfo(FileInfo f)
        {
            Console.WriteLine("Directory :" + f.Directory);
            Console.WriteLine("DirectoryName:" + f.DirectoryName);
            Console.WriteLine("Name :" + f.Name);
            Console.WriteLine("FullName :" + f.FullName);
            Console.WriteLine("Extension :" + f.Extension);

            try { Console.WriteLine("Octets :" + f.Length); } catch (Exception e) { WriteWarning("SUBDIRECTORY :" + e.Message); }

            Console.WriteLine("Last Edition :" + f.LastWriteTime);
            Console.WriteLine("ReadOnly :" + f.IsReadOnly);
            
            Console.WriteLine("Exists :" + f.Exists);

            string user = System.IO.File.GetAccessControl(path).
        }
    }
}
