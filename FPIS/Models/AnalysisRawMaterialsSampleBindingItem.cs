namespace FPIS.Models
{
    public class AnalysisRawMaterialsSampleBindingItem
    {
        // Analysis Item Id
        public Guid Id { get; set; }
        public Guid MaterialProcuredId { get; set; }
        public Guid ProcurementLocationId { get; set; }
        public string IdAsStr { get; set; }
        public DateOnly DateAdded { get; set; }
        public string Supplier { get; set; }
        public string TruckNumber { get; set; }
        public int QuantityReceived { get; set; }
        public int QuantityLeft { get; set; }  
        public string Remarks { get; set; }
        public bool Selected { get; set; }
        public string Location { get; set; }
        public string Lot { get; set; }
        public string AnalysisStatus { get; set; }
        public string ProductName { get; set; }
    }
}
