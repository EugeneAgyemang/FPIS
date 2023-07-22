using FPIS.Models;
using FPIS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Data
{
    public class MaterialIssueSchema
    {
        public string SchemaId { get; set; }
        public SampleDetail SampleDetail { get; set; }
        //public Releasing MaterialReleased { get; set; }
        public Receiving MaterialToBeIssued { get; set; }
        public string Weight { get; set; }
        public string Status { get; set; }
        public override string ToString()
        {
            Sample sample = SampleDetail.Sample;
            return $"Request #{SchemaId} " +
                $"@ {sample.Time.ToShortTimeString()} " +
                $"on " +
                $"{sample.Date.ToShortDateString()} " +
                $"for {new ProductService(new()).GetProductById(MaterialToBeIssued.MaterialProcurement.ProductId).ProductName} ";
        }
    }
}
