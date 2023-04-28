using FPIS.Models;
using FPIS.Views;
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
        public List<Sample> GetSamplesRequested(ViewSamplesRequestedUserControl.Source source)
        {
            IQueryable<Sample> productSamplesRequestedQuery = appDbContext.Samples.
                Include(sample => sample.User.Samples).
                Where(a => a.Status.ToLower() == "pending").
                Include(analysisItem => analysisItem.SampleDetails).
                ThenInclude(analysisItem => analysisItem.AnalysisItem.AnalysisProducts).
                ThenInclude(analysisProduct => analysisProduct.Product.ProductParameters).
                ThenInclude(a => a.ProductAnalysisParameters).
                ThenInclude(a => a.AnalysisParameter.sampleResultsDetailsWithParameters);

            switch (source)
            {
                case ViewSamplesRequestedUserControl.Source.PROCUREMENT:
                    productSamplesRequestedQuery = productSamplesRequestedQuery.
                    Where(sample => sample.SampleDetails
                                    .FirstOrDefault()
                                    .AnalysisItem
                                    .AnalysisProducts
                                    .FirstOrDefault()
                                    .Product
                                    .Type
                                    .ToLower() == "raw materials");
                    break;
                case ViewSamplesRequestedUserControl.Source.PRODUCTION:
                    productSamplesRequestedQuery = productSamplesRequestedQuery.
                    Where(sample => sample.TypeForFiltering.ToLower() == "production");
                    productSamplesRequestedQuery = productSamplesRequestedQuery.
                    Where(sample => sample.SampleDetails
                                    .FirstOrDefault()
                                    .AnalysisItem
                                    .AnalysisProducts
                                    .FirstOrDefault()
                                    .Product
                                    .Type
                                    .ToLower() != "raw materials");
                    break;
                case ViewSamplesRequestedUserControl.Source.WATER:
                    productSamplesRequestedQuery = productSamplesRequestedQuery.
                    Where(sample => sample.TypeForFiltering.ToLower() == "water");
                    productSamplesRequestedQuery = productSamplesRequestedQuery.
                    Where(sample => sample.SampleDetails
                                    .FirstOrDefault()
                                    .AnalysisItem
                                    .AnalysisProducts
                                    .FirstOrDefault()
                                    .Product
                                    .Type
                                    .ToLower() != "raw materials");
                    break;
            }
            List<Sample> productSamplesRequested = productSamplesRequestedQuery.ToList();
            return productSamplesRequested;
            //Where(analysisItem => analysisItem.SampleDetails.
            //                        FirstOrDefault().AnalysisItem.AnalysisProducts.FirstOrDefault().Product.
            //                        Type.ToLower().Contains(category)).ToList();
        }
    }
}
