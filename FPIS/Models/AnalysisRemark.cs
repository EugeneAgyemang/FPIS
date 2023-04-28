using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class AnalysisRemark
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Remark { get; set; }
        public DateTime Date { get; set; }

        // Navigation Properties

        public Guid SampleDetailId { get; set; }
        [ForeignKey("SampleDetailId")]
        public SampleDetail SampleDetail { get; set; }
        public Guid SampleResultDetailId { get; set; }
        [ForeignKey("SampleResultDetailId")]
        public SampleResultDetail SampleResultDetail { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
