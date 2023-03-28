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
            ProductParameter productParametertoBeSaved = new ProductParameter()
            {
                ParameterName = parameterName,
                Unit = unit,
                Method = method,
                Specification = specification,
                ProductId = productId
            };
            ProductParameter productParameterSaved = appDbContext.ProductParameters.Add(productParametertoBeSaved).Entity;
            appDbContext.SaveChanges();
            return productParameterSaved;
        }
    }
}
