using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;

namespace Indexer1
{
    class Program
    {
        public static DriveInfo[] drivesInfo;
        public static List<FileInfo> fileInfo = new List<FileInfo>();
        public static int timerCount;
        
        public static Timer timer;

        static void Main(string[] args)
        {
            //timer = new Timer(1000);
            //timer.Elapsed += TimerPrint;
            //timer.Enabled = true;

            //Seek available drives
            //GetDrives();

            //Explore arborescence
            //foreach (DriveInfo drive in drivesInfo)
            //{
                //ExploreFiles(drive.Name);
                ExploreFiles(@"C:\Users\Wolftrot\Desktop");
            //}

            Console.ReadLine();
        }

        public static void TimerPrint(Object source, ElapsedEventArgs e)
        {
            timerCount++;

            Console.WriteLine(timerCount + 's');
        }

        public static void WriteFileInfo(FileInfo f)
        {
            Console.WriteLine("Directory :" + f.Directory);
            Console.WriteLine("DirectoryName:" + f.DirectoryName);
            Console.WriteLine("Name :" + f.Name);
            Console.WriteLine("FullName :" + f.FullName);
            Console.WriteLine("Extension :" + f.Extension);
            
            try { Console.WriteLine("Octets :" + f.Length);  } catch (Exception e) { WriteWarning("SUBDIRECTORY :" + e.Message); }

            Console.WriteLine("Last Edition :" + f.LastWriteTime);
            Console.WriteLine("ReadOnly :" + f.IsReadOnly);
            Console.WriteLine("Exists :" + f.Exists);
        }


        public static void ExploreFiles(string path)
        {
            try
            {
                string[] subFiles = Directory.GetFileSystemEntries(path);

                foreach (string fullpath in subFiles)
                {
                    FileInfo fInfo = new FileInfo(fullpath);
                    WriteFileInfo(fInfo);
                    fileInfo.Add(fInfo);

                    if (IsDirectory(fullpath))
                    {
                        ExploreFiles(fullpath);
                    }

                }
            }
            catch (UnauthorizedAccessException ex)
            {
                WriteWarning(ex.Message);
            }
        }

        public static bool IsDirectory(string path)
        {
            // get the file attributes for file or directory
            FileAttributes attr = File.GetAttributes(path);

            if (attr.HasFlag(FileAttributes.Directory))
                return true;
            else
                return false;
        }

        public static void GetDrives()
        {
            WriteSeparator();
            WriteNotification("Getting available drives");

            drivesInfo = System.IO.DriveInfo.GetDrives();

            foreach (DriveInfo d in drivesInfo)
            {
                Console.WriteLine(d.Name + " " + d.DriveType + " " + d.DriveFormat + " " + d.VolumeLabel);
            }

            WriteSeparator();

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
            Console.WriteLine(new string('-', Console.BufferWidth));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
