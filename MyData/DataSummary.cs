using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData
{
    public class DataSummary
    {
        [Browsable(false)]
        public DateTime FileDate { get; set; }

        public string Name { get; set; }       
       public string FormatedDate
        {
            get
            {
                return FileDate.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }


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
