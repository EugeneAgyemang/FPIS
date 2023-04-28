namespace FPIS.Models
{
    public class AnalysisSampleParameterBindingItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Unit { get; set; }

        public string? Method { get; set; }

        public float? ControlLimit { get; set; }

        public float Specification { get; set; }

        public string? Value { get; set; }
    }
}
