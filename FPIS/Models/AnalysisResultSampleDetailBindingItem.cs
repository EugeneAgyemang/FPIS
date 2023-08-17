using System.Text;

namespace FPIS.Models
{
    public class AnalysisResultSampleDetailBindingItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Label { get; set; }

        public bool isRejected { get; set; }

        public string Reject { get; set; } = "Reject Sample";

        public string AnalysisItemId { get; set; }

        public string? ParameterValues { get; set; }

        public string? ProductOrWaterId { get; set; }

        public List<ParametersWithValues> parametersWithValues = new();

        public override string ToString()
        {
            StringBuilder stringBuilder = new();

            parametersWithValues.ForEach(it =>
            {
                stringBuilder.Append($"{it.ParameterName} = {it.ParameterValue}, ");
            });

            return "{ " + stringBuilder.Replace(",", "", stringBuilder.ToString().LastIndexOf(","), 1) + " }";
        }
    }

    public class ParametersWithValues
    {
        public string AnalysisResultWithParameterId { get; set; }
        public string ParameterId { get; set; }
        public string ParameterValue { get; set; } = "0.00";
        public string ParameterName { get; set; }
        public string Remarks { get; set; }
    }
}
