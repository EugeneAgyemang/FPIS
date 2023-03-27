using FPIS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class ViewSampleRequestedService
    {
        AppDbContext appDbContext;
        public ViewSampleRequestedService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public List<Sample> GetSamplesRequested(string category)
        {
            // TODO: CHANGE CTAEGORY TO THE NEW CATEGORY FIELD IN THE TABLE AND NOT THE PRODUCT NAME
            List<Sample> productSamplesRequested = new List<Sample>();
            productSamplesRequested = appDbContext.Samples.
                Include(sample => sample.User.Samples).
                Include(analysisItem => analysisItem.SampleDetails).
                ThenInclude(analysisItem => analysisItem.AnalysisItem.AnalysisProducts).
                ThenInclude(analysisProduct => analysisProduct.Product.AnalysisProducts).
                Where(analysisItem => analysisItem.SampleDetails.
                                        FirstOrDefault().AnalysisItem.AnalysisProducts.FirstOrDefault().Product.
                                        ProductName.ToLower() == category).ToList();
                //Where(product => product.ProductName.ToLower().Contains(category));
            return productSamplesRequested;
        }
    }
}
