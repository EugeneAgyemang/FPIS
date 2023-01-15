using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<FinishedProduct> FinishedProducts { get; set; }
        public List<SampleResultDetail> SampleResultDetails { get; set; }
    }
}
