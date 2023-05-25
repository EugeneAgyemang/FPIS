using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FPIS.Models
{
    public class SampleResultDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string? Label { get; set; }

        // Navigation Properties

        public Guid SampleResultId { get; set; }
        [ForeignKey("SampleResultId")]

        public SampleResult SampleResult { get; set; }

        public Guid AnalysisItemId { get; set; }
        [ForeignKey("AnalysisItemId")]

        public AnalysisItem AnalysisItem { get; set; }

        public List<SampleResultsDetailsWithParameter> sampleResultsDetailsWithParameters { get; set; }

        public List<AnalysisRemark> AnalysisRemarks { get; set; }
    }
}
