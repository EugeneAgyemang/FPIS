using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting.Datasets
{
    public class Issued_Stocks
    {
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public string IssuedDate { get; set; }
        public int QuantityIssued { get; set; }
        public string IssuedBy { get; set; }
    }
}
