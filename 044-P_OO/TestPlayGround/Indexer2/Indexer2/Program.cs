using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirExtractor extract = new DirExtractor();
            extract.Execute(@"C:\Users\Wolftrot\Desktop");
        }
    }
}
