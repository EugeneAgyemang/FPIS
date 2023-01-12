
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FPIS.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string EmpID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        // Navigation properties
        
        public Guid DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }
        public List<Sample> Samples { get; set; }
        public List<ProductionDailyReport> ProductionDailyReports { get; set;}
        public List<MaterialProcurement> MaterialProcurements { get; set; }
        public List<SampleResultDetail> SampleResultDetails { get; set; }
        public List<AnalysisRemark> AnalysisRemarks { get; set; }
      
      public override string ToString()
        {
            return $"EmployeeID: {EmpID}";
        }
    }
}
