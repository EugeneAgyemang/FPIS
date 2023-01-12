using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string ItemType { get; set; }

        // Navigation Properties
        public List<ProductAnalysisParameter> ProductAnalysisParameters { get; set; }
        public List<ProcurementParameter> ProcurementParameters { get; set; }
    }
}
