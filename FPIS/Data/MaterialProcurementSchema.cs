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
        public string SchemaId { get; set; }
        public SampleDetail SampleDetail { get; set; }
        public Receiving Receiving { get; set; }
        public string Status { get; set; }
        public override string ToString()
        {
            Sample sample = SampleDetail.Sample;
            return $"Request #{SchemaId} " +
                $"@ {sample.Time.ToShortTimeString()} " +
                $"on " +
                $"{sample.Date.ToShortDateString()}";
        }
    }
}
