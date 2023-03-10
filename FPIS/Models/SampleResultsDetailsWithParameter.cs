using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class SampleResultsDetailsWithParameter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public float Value { get; set; }

        // Navigation Properties

        public Guid SampleResultDetailId { get; set; }
        [ForeignKey("SampleResultDetailId")]
        public SampleResultDetail SampleResultDetail { get; set; }
        public Guid SampleDetailId { get; set; }
        [ForeignKey("SampleDetailId")]
        public SampleDetail SampleDetail { get; set; }
        public Guid AnalysisParameterId { get; set; }
        [ForeignKey("AnalysisParameterId")]
        public AnalysisParameter AnalysisParameter { get; set; }
    }
}
