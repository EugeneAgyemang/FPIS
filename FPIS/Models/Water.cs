using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class Water
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string WaterName { get; set; }

        // Navigation Properties
        public List<AnalysisWater> AnalysisWaters { get; set; }
        public List<WaterParameter> WaterParameters { get; set; }
        public override string ToString()
        {
            return WaterName;
        }
    }

}
