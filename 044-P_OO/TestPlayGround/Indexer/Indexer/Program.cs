using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.-Get All Drives
            DriveInfo[] drivesInfo = System.IO.DriveInfo.GetDrives();
            List<string> drives = new List<string>();

            List<string[]> driveFiles = new List<string[]>();

            WriteSeparator();
            WriteNotification("Getting available drives");

            foreach (DriveInfo d in drivesInfo)
            {
                drives.Add(d.Name);
                Console.WriteLine(d.Name + " " + d.DriveType + " " + d.DriveFormat + " " + d.VolumeLabel);
                driveFiles.Add(System.IO.Directory.GetFileSystemEntries(d.Name));
            }
            WriteSeparator();


            //2.-Get All Files in Drives
            WriteSeparator();
            WriteNotification("Getting drives tree");

            foreach(string[] filesInDirectory in driveFiles)
            {
                foreach (string file in filesInDirectory)
                {
                    Console.WriteLine(file);
                }
            }


            WriteSeparator();
            Console.ReadLine();
        }

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
            Console.WriteLine(new string ('-', Console.BufferWidth));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
