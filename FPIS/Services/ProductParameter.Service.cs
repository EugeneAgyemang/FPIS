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
        public bool DoesProductParameterExist(string parameterName)
        {
            bool itExists = false;
            ProductParameter foundItem = appDbContext.ProductParameters.FirstOrDefault(productParameter => productParameter.ParameterName == parameterName);
            if (foundItem != null)
            {
                itExists = true;
            }
            return itExists;
        }
        public ProductParameter Save(string parameterName, string unit, string method, float specification)
        {
            ProductParameter productParametertoBeSaved = new ProductParameter()
            {
                ParameterName = parameterName,
                Unit = unit,
                Method = method,
                Specification = specification
            };
            ProductParameter productParameterSaved = appDbContext.ProductParameters.Add(productParametertoBeSaved).Entity;
            appDbContext.SaveChanges();
            return productParameterSaved;
        }
    }
}
