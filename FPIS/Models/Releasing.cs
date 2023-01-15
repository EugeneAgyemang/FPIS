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
        public int FatContent { get; set; }

        // Navigation Properties
        public Guid MaterialProcurementId { get; set; }
        [ForeignKey("MaterialProcurementId")]

        public MaterialProcurement MaterialProcurement { get; set; }
    }
}
