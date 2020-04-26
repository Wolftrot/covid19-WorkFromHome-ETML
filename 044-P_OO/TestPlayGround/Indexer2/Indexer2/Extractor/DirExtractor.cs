using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using Indexer2.Models;


namespace Indexer2
{
    class DirExtractor : Extractor
    {
        public DriveInfo[] drivesInfo;
        public List<FileInfo> fileInfo = new List<FileInfo>();

        public List<FileExtract> filesExtracted = new List<FileExtract>();
        public List<Source> sources = new List<Source>();


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
            foreach (FileInfo file in fileInfo)
            {
                FileExtract newFile = new FileExtract();
                newFile.Path = file.DirectoryName;
                newFile.Name = file.FullName;
                newFile.Author = System.IO.File.GetAccessControl(newFile.Path).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
                newFile.Date = System.IO.File.GetCreationTime(newFile.Path);
                newFile.LastModifiedDate = System.IO.File.GetLastWriteTime(newFile.Path);
                //OS does not keep track of last modification authors
                //newFile.LastModifiedAuthor = System.IO.File.GetAccessControl(newFile.Path).l


                filesExtracted.Add(new FileExtract
                    
                    
                    )
            }

            //Clean 
            drivesInfo = null;
            fileInfo = new List<FileInfo>();
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
