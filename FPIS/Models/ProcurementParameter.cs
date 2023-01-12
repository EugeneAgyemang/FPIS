using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class ProcurementParameter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public float Value { get; set; }

        // Navigation Properties

        public Guid ProcurementId { get; set; }
        [ForeignKey("ProcurementId")]
        public MaterialProcurement MaterialProcurement { get; set; }
        public Guid ProductParameterId { get; set; }
        [ForeignKey("ProductParameterId")]
        public ProductParameter ProductParameter { get; set; }

    }
}
