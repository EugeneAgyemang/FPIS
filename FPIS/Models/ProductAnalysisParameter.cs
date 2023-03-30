﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FPIS.Models
{
    public class ProductAnalysisParameter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        // Navigation Properties
        public Guid ProductParameterId { get; set; }
        [ForeignKey("ProductParameterId")]
        public ProductParameter ProductParameter { get; set; }
        public Guid AnalysisParameterId { get; set; }
        [ForeignKey("AnalysisParameterId")]
        public AnalysisParameter AnalysisParameter { get; set; }
    }
}
