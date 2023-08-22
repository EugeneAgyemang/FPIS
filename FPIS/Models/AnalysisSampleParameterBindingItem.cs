namespace FPIS.Models
{
    public class AnalysisSampleParameterBindingItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Unit { get; set; }

        public string? Method { get; set; }

        public string? ControlLimit { get; set; }

        public string Specification { get; set; }

        public string? Value { get; set; }
        public string? Remarks { get; set; }

        public bool shouldUpdate = false;
    }
}
