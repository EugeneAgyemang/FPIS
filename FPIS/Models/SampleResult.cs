using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FPIS.Models
{
    public class SampleResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public bool IsRetest { get; set; }

        // Navigation Properties
        
        public Guid SampleId { get; set; }
        [ForeignKey("SampleId")]
        public Sample Sample { get; set; }

        
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]

        public User User { get; set; }
        

        public List<FinishedProduct> FinishedProducts { get; set; }
        public List<SampleResultDetail> SampleResultDetails { get; set; }
    }
}
