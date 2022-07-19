using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
{
    public class Report
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int NumberOfOrders { get; set; }
        public int NumberSaled { get; set; }
        public double Sales { get; set; }

        public Report()
        {
        }
    }
}
