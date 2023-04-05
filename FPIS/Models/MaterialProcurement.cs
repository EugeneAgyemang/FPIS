using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace FPIS.Models
{
    public class MaterialProcurement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public string Location { get; set; }
        public string Remarks { get; set; }
        public string Type { get; set; }
        public string Lot { get; set; }

        // Navigation Properties

        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public List<Receiving> Receivings { get; set; }
        public List<Releasing> Releasings { get; set; }
        public List<ProcurementParameter> ProcurementParameters { get; set; }
        public List<ProcurementAttribute> ProcurementAttributes { get; set; }

    }
}
