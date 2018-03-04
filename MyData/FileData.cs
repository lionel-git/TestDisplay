using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyData
{
    public class FileData
    {
        public DateTime FileDatetime { get; set; }
        public IList<string> Names { get; set; }
        public string Text { get; set; }

        public FileData(string path)
        {
            Text=File.ReadAllText(path);
        }
    }


}
