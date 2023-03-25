using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class AnalysisRawMaterialsService
    {
        private readonly AppDbContext _dbContext;

        /// <summary>
        /// Constructor to initialize a new `AnalysisService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public AnalysisRawMaterialsService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Sample CreateSample(
            Guid userId,
            string emp1Id,
            string emp2Id,
            DateOnly date,
            TimeOnly time,
            string analysisType,
            List<AnalysisRawMaterialsSampleBindingItem> analysisItems
            )
        {
            Sample sample = _dbContext.Samples.Add(
                new Sample()
                {
                    Date = date,
                    Time = time,
                    UserId = userId,
                    Employee1 = emp1Id,
                    Employee2 = emp2Id,
                    Status = "Pending",
                    TypeForFiltering = analysisType
                }
            ).Entity;

            SampleDetail[] sampleDetails = analysisItems.Select(ai =>
            {
                return new SampleDetail()
                {
                    SampleId = sample.Id,
                    AnalysisItemId = ai.Id,
                };
            }).ToArray();

            _dbContext.SampleDetails.AddRange(sampleDetails);
            _dbContext.SaveChanges();

            return sample;
        }
    }
}
