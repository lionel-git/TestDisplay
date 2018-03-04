using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData
{
    public class DataSummary
    {
        DateTime FileDate { get; set; }
        string Name { get; set; }

        public DataSummary()
        {
            FileDate = DateTime.Now;
            Name = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $" {Name} {FileDate}";
        }

    }
}
