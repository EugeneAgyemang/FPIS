using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class SampleDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        // Navigation properties
        public Guid SampleId { get; set; }
        [ForeignKey("SampleId")]
        public Sample Sample { get; set; }
        public Guid AnalysisItemId { get; set; }
        [ForeignKey("AnalysisItemId")]
        public AnalysisItem AnalysisItem { get; set; }
        public List<SampleResultsDetailsWithParameter> sampleResultsDetailsWithParameters { get; set; }
        public List<AnalysisRemark> AnalysisRemarks { get; set; }
    }
}
