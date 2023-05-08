namespace FPIS.Models
{

    // this is SampleDetail in the database
    public class AnalysisSampleBindingItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool Selected { get; set; }

        public string? Label { get; set; }

        public string? Quantity { get; set; }
    }
}
