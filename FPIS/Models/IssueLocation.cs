using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class IssueLocation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public string ApproxWeight { get; set; }
        public Guid ProcurementLocationId { get; set; }
        [ForeignKey("ProcurementLocationId")]
        public ProcurementLocation ProcurementLocation { get; set; }
        public Guid ReleasingId { get; set; }
        [ForeignKey("ReleasingId")]
        public Releasing Releasing { get; set; }
    }
}
