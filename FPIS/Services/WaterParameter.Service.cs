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
            AnalysisParameter analysisParameter = appDbContext.AnalysisParameters.Add(
                new AnalysisParameter() { Id = new Guid(), ItemType = "Water" }
            ).Entity;

            WaterParameter waterParameter = appDbContext.WaterParameters.Add(
                new WaterParameter()
                {
                    ParameterName = parameterName,
                    Unit = unit,
                    ControlLimit = controlLimit
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
    }
}
