using FPIS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class AnalysisParameterService
    {
        private readonly AppDbContext _dbContext;

        /// <summary>
        /// Constructor to initialize a new `AnalysisService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public AnalysisParameterService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<WaterAnalysisParameter> FetchAnalysisWaterParameters(Guid waterId)
        {
            return _dbContext.WaterAnalysisParameters
                .Include(pap => pap.AnalysisParameter)
                .Include(pap => pap.WaterParameter)
                .Where(pap => pap.WaterParameter.WaterId == waterId)
                .ToList();
        }

        public List<ProductAnalysisParameter> FetchProductAnalysisParameters(Guid productId)
        {
            return _dbContext.ProductAnalysisParameters
                .Include(pap => pap.AnalysisParameter)
                .Include(pap => pap.ProductParameter)
                .Where(pap => pap.ProductParameter.ProductId == productId)
                .ToList();
        }
    }
}
