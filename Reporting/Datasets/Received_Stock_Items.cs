using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting.Datasets
{
    public class Received_Stock_Items
    {
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public string ReceivedDate { get; set; }
        public string UnitOfMeasurement { get; set; }
        public int QuantityReceived { get; set; }
        public int AvailableQuantity { get; set; }
        public string ExpiryDate { get; set; }
        public string ReceivedBy { get; set; }
    }
}
