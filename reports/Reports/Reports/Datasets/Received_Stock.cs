using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Datasets
{
    public class Received_Stock
    {
        public string ItemName { get; set; }
        public string ReceivedDate { get; set; }
        public string UnitOfMeasurement { get; set; }
        public int QuantityReceived { get; set; }
        public int AvailableQuantity { get; set; }
        public string ExpiryDate { get; set; }
    }
}
