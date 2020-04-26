using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer2.Models
{
    public class FileExtract
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public DateTime LastModifiedDate { get; set; }

        //OS doesnt keep track : public string LastModifiedAuthor { get; set; }
    }
}
