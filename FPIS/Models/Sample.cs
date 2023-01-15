using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class Sample
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Status { get; set; }
        public string TypeForFiltering { get; set; }

        // Navigation Properties

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public string Employee1 { get; set; }
        public string Employee2 { get; set; }
        public User User { get; set; }
        public List<SampleResult> SampleResults { get; set; }
        public List<SampleDetail> SampleDetails { get; set; }
    }
}
