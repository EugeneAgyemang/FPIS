using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Data
{
    /// <summary>
    /// Schema file for JSON object when caching Material sent to
    /// Quality COntrol for analysis
    /// </summary>
    public class MaterialProcurementSchema
    {
        public SampleDetail SampleDetail { get; set; }
        public Receiving Receiving { get; set; }
    }
}
