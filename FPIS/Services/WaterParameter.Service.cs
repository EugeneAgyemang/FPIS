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
        public bool DoesWaterParameterExist(string parameterName, Guid waterId)
        {
            bool itExists = false;
            WaterParameter foundItem = appDbContext.WaterParameters.
                FirstOrDefault(waterParameter => waterParameter.ParameterName == parameterName 
                && waterParameter.WaterId == waterId);
            if(foundItem != null)
            {
                itExists = true;
            }
            return itExists;
        }
        public WaterParameter Save(string parameterName, string unit, float controlLimit, Guid waterId)
        {
            AnalysisParameter analysisParameter = appDbContext.AnalysisParameters.Add(
                new AnalysisParameter() { Id = new Guid(), ItemType = "Water" }
            ).Entity;

            WaterParameter waterParameter = appDbContext.WaterParameters.Add(
                new WaterParameter()
                {
                    ParameterName = parameterName,
                    Unit = unit,
                    ControlLimit = controlLimit,
                    WaterId = waterId
                }
            ).Entity;

            appDbContext.WaterAnalysisParameters.Add(
                new WaterAnalysisParameter()
                {
                    Id = new Guid(),
                    AnalysisParameterId = analysisParameter.Id,
                    WaterParameterId = waterParameter.Id
                }
            );

            appDbContext.SaveChanges();
            return waterParameter;
        }

        public List<WaterParameter> GetWaterParameters(Guid waterId)
        {
            return appDbContext.WaterParameters
                        .Where(waterParameter => waterParameter.WaterId == waterId)
                        .ToList();
        }

        public WaterParameter UpdateParameterControlLimit(Guid parameterId, float newControlLimit)
        {
            WaterParameter waterParameter = appDbContext.WaterParameters
                                                                .FirstOrDefault(waterParameter => waterParameter.Id == parameterId);
            waterParameter.ControlLimit = newControlLimit;
            appDbContext.Update(waterParameter);
            appDbContext.SaveChanges();
            return waterParameter;
        }
    }
}
