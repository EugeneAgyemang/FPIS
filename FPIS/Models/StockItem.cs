using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class StockItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string StockItemName { get; set; }
        public string Unit { get; set; }
        public string StockItemType { get; set; }

        // Navigation Properties
        public List<ReceivedStock> ReceivedStocks { get; set; }
        public List<IssuedStock> IssuedStocks { get; set; }
    }
}
