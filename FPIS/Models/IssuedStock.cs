using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class IssuedStock
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public int QuantityIssued { get; set; }
        public DateTime IssuedDate { get; set; }

        // Navigation Properties
        public Guid StockItemId { get; set; }
        [ForeignKey("StockItemId")]
        public StockItem StockItem { get; set; }
    }
}
