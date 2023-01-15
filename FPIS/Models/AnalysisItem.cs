using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class AnalysisItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string ItemType { get; set; }

        // Navigation Properties
        public List<AnalysisProduct> AnalysisProducts { get; set; }
        public List<AnalysisWater> AnalysisWaters { get; set; }
        public List<SampleDetail> SampleDetails { get; set; }

    }
}
