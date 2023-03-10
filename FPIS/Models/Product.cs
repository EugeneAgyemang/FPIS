using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string ProductName { get; set; }

        // Navigation Properties
        public List<MaterialProcurement> MaterialProcurements { get; set;}
        public List<AnalysisProduct> AnalysisProducts { get; set;}
    
    }
}
