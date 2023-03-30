using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class ProductParameterService
    {
        AppDbContext appDbContext;
        public ProductParameterService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public bool DoesProductParameterExist(string parameterName, Guid productId)
        {
            bool itExists = false;
            ProductParameter foundItem = appDbContext.ProductParameters.
                                            Where(productParameter => productParameter.ParameterName == parameterName
                                            && productParameter.ProductId == productId).FirstOrDefault();
            if (foundItem != null)
            {
                itExists = true;
            }
            return itExists;
        }
        public ProductParameter Save(string parameterName, string unit, string method, float specification, Guid productId)
        {
            AnalysisParameter analysisParameter = appDbContext.AnalysisParameters.Add(
                new AnalysisParameter(){ Id = new Guid(), ItemType = "Product"  }
            ).Entity;

            ProductParameter productParameter = appDbContext.ProductParameters
                .Add(new ProductParameter()
                    {
                        ParameterName = parameterName,
                        Unit = unit,
                        Method = method,
                        Specification = specification,
                        Id = new Guid(),
                        ProductId = productId
                    }
                ).Entity;

            appDbContext.ProductAnalysisParameters.Add(
                new ProductAnalysisParameter() {
                    Id = new Guid(),
                    AnalysisParameterId = analysisParameter.Id,
                    ProductParameterId = productParameter.Id
                }
            );
            appDbContext.SaveChanges();
            return productParameter;
        }
    }
}
