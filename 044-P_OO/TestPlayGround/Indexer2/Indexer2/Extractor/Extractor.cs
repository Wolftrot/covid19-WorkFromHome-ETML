using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer2
{
    abstract class Extractor
    {
        public void Execute(string path)
        {
            Explore(path);
            PackData();
            SendData();
        }
        public abstract void Explore(string path);
        public abstract void PackData();
        public abstract void SendData();


    }
}
