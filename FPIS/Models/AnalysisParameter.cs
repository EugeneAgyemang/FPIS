using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class AnalysisParameter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string ItemType { get; set; }

        // Navigation Properties
        public List<ProductAnalysisParameter> ProductAnalysisParameters { get; set; }
        public List<WaterAnalysisParameter> WaterAnalysisParameters { get; set; }
        public List<SampleResultsDetailsWithParameter> sampleResultsDetailsWithParameters { get; set; }
    }
}
