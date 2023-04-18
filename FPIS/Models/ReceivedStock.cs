﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class ReceivedStock
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public DateOnly ReceivedDate { get; set; }
        public int Quantity { get; set;}
        public int QuantityAvailable { get; set; }
        public DateOnly ExpiryDate { get; set; }

        // Navigation Properties
        
        public Guid StockItemId { get; set; }
        [ForeignKey("StockItemId")]
        public StockItem StockItem { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
