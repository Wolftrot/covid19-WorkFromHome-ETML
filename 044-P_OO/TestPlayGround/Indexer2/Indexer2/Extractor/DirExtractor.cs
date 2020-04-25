using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;

namespace Indexer2
{
    class DirExtractor : Extractor
    {
        public DriveInfo[] drivesInfo;
        public List<FileInfo> fileInfo = new List<FileInfo>();
        public int timerCount;

        public Timer timer;

        public override void Explore(string path)
        {
            try
            {
                string[] subFiles = Directory.GetFileSystemEntries(path);

                foreach (string fullpath in subFiles)
                {
                    FileInfo fInfo = new FileInfo(fullpath);
                    ConsoleWriter.WriteFileInfo(fInfo);
                    fileInfo.Add(fInfo);

                    if (IsDirectory(fullpath))
                    {
                        Explore(fullpath);
                    }

                }
            }
            catch (UnauthorizedAccessException ex)
            {
                ConsoleWriter.WriteWarning(ex.Message);
            }
        }

        public override void PackData()
        {

        }

        public override void SendData()
        {
            //throw new NotImplementedException();
        }

        public bool IsDirectory(string path)
        {
            // get the file attributes for file or directory
            FileAttributes attr = File.GetAttributes(path);

            if (attr.HasFlag(FileAttributes.Directory))
                return true;
            else
                return false;
        }

        public void GetDrives()
        {
            ConsoleWriter.WriteSeparator();
            ConsoleWriter.WriteNotification("Getting available drives");

            drivesInfo = System.IO.DriveInfo.GetDrives();

            foreach (DriveInfo d in drivesInfo)
            {
                Console.WriteLine(d.Name + " " + d.DriveType + " " + d.DriveFormat + " " + d.VolumeLabel);
            }

            ConsoleWriter.WriteSeparator();

        }

       
    }
}
