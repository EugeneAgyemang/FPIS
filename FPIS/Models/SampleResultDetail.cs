using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class SampleResultDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        // Navigation Properties

        public Guid SampleResultId { get; set; }
        [ForeignKey("SampleResultId")]
        public SampleResult SampleResult { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public List<SampleResultsDetailsWithParameter> sampleResultsDetailsWithParameters { get; set; }
        public List<AnalysisRemark> AnalysisRemarks { get; set; }

    }
}
