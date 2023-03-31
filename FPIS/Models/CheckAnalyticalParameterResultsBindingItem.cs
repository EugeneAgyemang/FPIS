using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class CheckAnalyticalParameterResultsBindingItem
    {
        public string ParameterName { get; set; }
        public float Expected { get; set; }
        public float Actual { get; set; }
        public float Variance { get; set; }
        public float Indicator { get; set; }
    }
}
