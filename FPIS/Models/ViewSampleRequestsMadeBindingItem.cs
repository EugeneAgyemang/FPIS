using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Models
{
    public class ViewSampleRequestsMadeBindingItem
    {
        public string SampleIdAsString { get; set; }
        public Guid ProductId { get; set; }
        public Guid SampleId { get; set; }
        public Guid SampleDetailId { get; set; }
        public Guid AnalysisItemId { get; set; }
        public Guid AnalysisProductId { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Status { get; set; }
        public string TypeForFiltering { get; set; }
        public Guid EngineerOne { get; set; }
        public Guid EngineerTwo { get; set;}
        public string EngineerOneEmpId { get; set; }
        public string EngineerTwoEmpId { get; set; }
        public string EngineerOneFullName { get; set; }
        public string EngineerTwoFullName { get; set; }
        public string Engineer { get; set; }
    }
}
