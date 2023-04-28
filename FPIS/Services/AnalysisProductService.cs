using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class AnalysisProductService
    {
        AppDbContext appDbContext;
        
        public AnalysisProductService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public AnalysisProduct GetAnalysisProductByProductId(Guid productId)
        {
            AnalysisProduct analysisProduct = new AnalysisProduct();
            analysisProduct = appDbContext.AnalysisProducts
                                .FirstOrDefault(analysisProduct => analysisProduct.ProductId == productId);
            return analysisProduct;
        }
    }
}
