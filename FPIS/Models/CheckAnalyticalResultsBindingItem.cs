using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class CheckAnalyticalResultsBindingItem
    {
        public string ProductName { get; set; }
        public string AnalysisType { get; set; }
        public string AnalysisRequestDate { get; set; }
        public string AnalysisRequestTime { get; set; }
        public string AnalysisResultDate { get; set; }
        public string AnalysisResultTime { get; set; }
        public string SampleDetailsId { get; set; }
        public string SampleResultId { get; set; }
        public string SampleResultDetailsId { get; set;}

    }
}