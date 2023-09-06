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
        public ProductParameter Save(string parameterName, string unit, string method, string specification, Guid productId,float? minSpecification)
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
                        ProductId = productId,
                        MinimumSpecification= minSpecification
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

        public List<ProductParameter> GetProductParameters(Guid productId)
        {
            return appDbContext.ProductParameters
                        .Where(productParameter => productParameter.ProductId == productId)
                        .ToList();
        }

        public ProductParameter UpdateParameterSpecification(Guid parameterId, string newUnit, string newMethod, string newSpecification, float? newMinSpecification)
        {
            ProductParameter productParameter = appDbContext.ProductParameters
                                                                .FirstOrDefault(productParameter => productParameter.Id == parameterId);
            productParameter.Unit = newUnit;
            productParameter.Method = newMethod;
            productParameter.Specification = newSpecification;
            productParameter.MinimumSpecification= newMinSpecification;
            appDbContext.Update(productParameter);
            appDbContext.SaveChanges();
            return productParameter;
        }
    }
}
