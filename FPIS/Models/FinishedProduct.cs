using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class FinishedProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Consignee { get; set; }
        public string ProductType { get; set; }
        public string BatchNumber { get; set; }
        public string ContainerNumber { get; set; }
        public string SealNumber { get; set; }
        public string Quantity { get; set; }

        // Navigation Properties
        
        public Guid SampleResultId { get; set; }
        [ForeignKey("SampleResultId")]
        public SampleResult SampleResult { get; set; }

    }
}
