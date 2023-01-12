using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class WaterAnalysisParameter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        // Navigation Properties
        public Guid WaterParameterId { get; set; }
        [ForeignKey("WaterParameterId")]
        public WaterParameter WaterParameter { get; set; }
        public Guid AnalysisParameterId { get; set; }
        [ForeignKey("AnalysisParameterId")]
        public AnalysisParameter AnalysisParameter { get; set; }
    }
}
