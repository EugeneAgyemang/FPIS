using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class AnalysisWater
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        // Navigation Properties
        public Guid WaterId { get; set; }
        [ForeignKey("WaterId")]
        public Water Water { get; set; }
        public Guid AnalysisItemId { get; set; }
        [ForeignKey("AnalysisItemId")]
        public AnalysisItem AnalysisItem { get; set; }
    }
}
