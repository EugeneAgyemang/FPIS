using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class ProcurementAttribute
    {
        public Guid Id { get; set; }
        public string Value { get; set; }

        // Navigation Properties

        public Guid ProcurementId { get; set; }
        [ForeignKey("ProcurementId")]
        public MaterialProcurement MaterialProcurement { get; set; }
        public Guid MaterialAttributeId { get; set; }
        [ForeignKey("MaterialAttributeId")]
        public MaterialAttribute MaterialAttribute { get; set; }
    }
}
