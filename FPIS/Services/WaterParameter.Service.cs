using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class WaterParameterService
    {
        AppDbContext appDbContext;
        public WaterParameterService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public bool DoesWaterParameterExist(string parameterName)
        {
            bool itExists = false;
            WaterParameter foundItem = appDbContext.WaterParameters.FirstOrDefault(waterParameter => waterParameter.ParameterName == parameterName);
            if(foundItem != null)
            {
                itExists = true;
            }
            return itExists;
        }
        public WaterParameter Save(string parameterName, string unit, float controlLimit)
        {
            WaterParameter waterParameterToBeSaved = new WaterParameter()
            {
                ParameterName = parameterName,
                Unit = unit,
                ControlLimit = controlLimit
            };
            WaterParameter waterParameterSaved = appDbContext.WaterParameters.Add(waterParameterToBeSaved).Entity;
            appDbContext.SaveChanges();
            return waterParameterSaved;
        }
    }
}
