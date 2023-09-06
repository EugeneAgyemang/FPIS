using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FPIS.Models
{
    public class SampleResultsDetailsWithParameter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string? Value { get; set; }
        public string? Remarks { get; set; }

        // Navigation Properties

        public Guid SampleResultDetailId { get; set; }
        [ForeignKey("SampleResultDetailId")]

        public SampleResultDetail SampleResultDetail { get; set; }

        public Guid AnalysisParameterId { get; set; }
        [ForeignKey("AnalysisParameterId")]

        public AnalysisParameter AnalysisParameter { get; set; }
    }
}
