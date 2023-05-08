﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class ProcurementLocation
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public string Lot { get; set; }
        public int Quantity { get; set; }
        public Guid ReceivingId { get; set; }
        [ForeignKey("ReceivingId")]
        public Receiving Receiving { get; set; }
    }
}
