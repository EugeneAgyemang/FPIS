using System.Text;

namespace FPIS.Models
{
    public class AnalysisResultDataBindingItem
    {
        public string SampleResultId { get; set; }

        public string AnalysisType { get; set; }

        public string Name { get; set; }

        public string ResultDate { get; set; }

        public string Sample { get; set; }

        public string ProductionEngineerOne { get; set; }

        public string ProductionEngineerTwo { get; set; }

        public string Update { get; set; } = "Update Result";
    }

}
