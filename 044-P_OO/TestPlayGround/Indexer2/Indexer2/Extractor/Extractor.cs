using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer2
{
    abstract class Extractor
    {
        public abstract int EntriesCount { get; set; }
        public void Execute(string path)
        {
            Explore(path);
            SendData();
        }
        public abstract void Explore(string path);
        public abstract void PackData(FileInfo file);
        public abstract void SendData();


    }
}
