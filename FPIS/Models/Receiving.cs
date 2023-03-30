using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class Receiving
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Supplier { get; set; }
        public string TruckNumber { get; set; }
        public int Quantity { get; set; }
        public string Units { get; set; }

        // Navigation Properties
        
        public Guid MaterialProcurementId { get; set; }
        [ForeignKey("MaterialProcurementId")]
        public MaterialProcurement MaterialProcurement { get; set; }
        public List<Releasing> Releasings { get; set; }
    }
}
