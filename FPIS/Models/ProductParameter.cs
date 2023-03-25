using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FPIS.Models
{
    public class ProductParameter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string ParameterName { get; set; }
        public string Unit { get; set; }
        public string Method { get; set; }
        public float Specification { get; set; }

        // Navigation Properties
        public List<ProductAnalysisParameter> ProductAnalysisParameters { get; set; }
        public List<ProcurementParameter> ProcurementParameters { get; set; }
    }
}
