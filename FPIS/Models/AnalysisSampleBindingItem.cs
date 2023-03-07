using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class AnalysisSampleBindingItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public bool Selected { get; set; }
    }
}
