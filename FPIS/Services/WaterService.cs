using FPIS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FPIS.Services
{
    /// <summary>
    /// This class represents a service that works the `Products` models to perform
    /// database transactions.
    /// </summary>
    public class WaterService
    {
        private readonly AppDbContext _dbContext;

        /// <summary>
        /// Constructor initialize a new `WaterService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public WaterService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Checks if a water exists already.
        /// </summary>
        /// <param name="waterName"></param>
        /// <returns></returns>
        public bool DoesWaterExists(string waterName)
        {
            var water = _dbContext.Waters.FirstOrDefault(p => p.WaterName.ToLower() == waterName.ToLower());

            if (water != null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns a single water by the name
        /// </summary>
        /// <returns>Water?</returns>
        public Water? GetWaterByName(string waterName)
        {
            return _dbContext.Waters.FirstOrDefault(w => w.WaterName == waterName);
        }

        /// <summary>
        /// Returns all waters
        /// </summary>
        /// <returns>List<Water></returns>
        public List<Water> GetAllWater()
        {
            return _dbContext.Waters.ToList();
        }

        /// <summary>
        /// Creates a new `Water` with the provided name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Water</returns>
        public Water CreateWater(string name)
        {
            var water = _dbContext.Waters.Add(
                    new()
                    {
                        WaterName = name
                    }
                ).Entity;

            _dbContext.SaveChanges();

            return water;
        }

        public List<SampleDetail> GetWatersWithAnalysisResults(Guid? sampleDetailId)
        {
            IQueryable<SampleDetail> samplesRequestedQuery = _dbContext.SampleDetails.
                Include(sd => sd.Sample).
                Where(sample => sample.Sample.Status.ToLower() == "completed").
                Include(sample => sample.Sample.SampleResults).
                Where(a => a.AnalysisItem.ItemType == "Water").
                Include(analysisItem => analysisItem.AnalysisItem.AnalysisWaters).

                ThenInclude(analysisWater => analysisWater.Water.WaterParameters).
                ThenInclude(a => a.WaterAnalysisParameters).
                ThenInclude(a => a.AnalysisParameter.sampleResultsDetailsWithParameters).
                ThenInclude(a => a.SampleResultDetail.SampleResult);


            if (sampleDetailId != null)
            {
                samplesRequestedQuery = samplesRequestedQuery.
                Where(a => a.Id == sampleDetailId);
            }


            return samplesRequestedQuery.ToList();

        }

        public List<SampleDetail> GetWatersWithAnalysisResultsPerDate(DateOnly fromDate, DateOnly toDate, string waterName = "")
        {
            IQueryable<SampleDetail> waterSamplesRequestedQuery = _dbContext.SampleDetails.
                Include(sd => sd.Sample).
                Where(a => a.Sample.Date >= fromDate && a.Sample.Date <= toDate).
                Where(a => a.AnalysisItem.ItemType == "Water").
                Include(analysisItem => analysisItem.AnalysisItem.AnalysisWaters).
                ThenInclude(analysisWater => analysisWater.Water.WaterParameters).
                ThenInclude(a => a.WaterAnalysisParameters).
                ThenInclude(a => a.AnalysisParameter.sampleResultsDetailsWithParameters).
                ThenInclude(a => a.SampleResultDetail.SampleResult);


            if (waterName != string.Empty)
            {
                waterSamplesRequestedQuery = waterSamplesRequestedQuery.
                Where(a => a.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName == waterName);

            }


            return waterSamplesRequestedQuery.ToList();

        }
    }
}
