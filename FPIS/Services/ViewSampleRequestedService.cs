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
        public List<Sample> GetSamplesRequested(params string[] typesForFiltering)
        {
            IQueryable<Sample> productSamplesRequestedQuery = appDbContext.Samples.
                Include(sample => sample.User.Samples).
                Include(analysisItem => analysisItem.SampleDetails).
                ThenInclude(analysisItem => analysisItem.AnalysisItem.AnalysisProducts).
                ThenInclude(analysisProduct => analysisProduct.Product.AnalysisProducts);

            if (typesForFiltering.Length == 1)
            {
                typesForFiltering[0] = CheckTypeForFiltering(typesForFiltering[0]);
                productSamplesRequestedQuery = productSamplesRequestedQuery.
                    Where(sample => sample.TypeForFiltering.ToLower() == typesForFiltering[0]);
            }
            else
            {
                typesForFiltering[0] = CheckTypeForFiltering(typesForFiltering[0]);
                typesForFiltering[1] = CheckTypeForFiltering(typesForFiltering[1]);
                productSamplesRequestedQuery = productSamplesRequestedQuery.
                    Where(sample => sample.TypeForFiltering.ToLower() != "raw materials");
            }
            List<Sample> productSamplesRequested = productSamplesRequestedQuery.ToList();
            return productSamplesRequested;
            //Where(analysisItem => analysisItem.SampleDetails.
            //                        FirstOrDefault().AnalysisItem.AnalysisProducts.FirstOrDefault().Product.
            //                        Type.ToLower().Contains(category)).ToList();
        }
        private string CheckTypeForFiltering(string type)
        {
            string[] validTypes = { "raw materials", "production", "water" };
            foreach (var validType in validTypes)
            {
                if (type == validType)
                {
                    return type;
                }
            }
            return "production";
        }
    }
}
