using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class WaterParameter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string ParameterName { get; set; }
        public string Unit { get; set; }
        public float ControlLimit { get; set; }

        // Navigation Properties
        public List<WaterAnalysisParameter> WaterAnalysisParameters { get; set; }
    }
}
