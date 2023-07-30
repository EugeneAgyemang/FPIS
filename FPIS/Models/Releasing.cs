using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class Releasing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public string Weight { get; set; }

        // Navigation Properties
        public Guid MaterialProcurementId { get; set; }
        [ForeignKey("MaterialProcurementId")]
        public MaterialProcurement MaterialProcurement { get; set; }
        public Guid ProcurementLocationId { get; set; }
        [ForeignKey("ProcurementLocationId")]
        public ProcurementLocation ProcurementLocation { get; set; }
        public List<IssueLocation> IssueLocations { get; set; }
    }
}
