using FPIS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class AnalysisService
    {
        private readonly AppDbContext _dbContext;

        /// <summary>
        /// Constructor to initialize a new `AnalysisService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public AnalysisService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Sample? FetchProductionAnalysis(string sampleId)
        {
            return _dbContext.Samples
                .Include(s => s.SampleDetails)
                .ThenInclude(sd => sd.AnalysisItem)
                .ThenInclude(ai => ai.AnalysisProducts)
                .ThenInclude(ap => ap.Product.MaterialProcurements)
                .FirstOrDefault(s => s.Id.ToString() == sampleId);
        }

        public Sample? FetchWaterAnalysis(string sampleId)
        {
            return _dbContext.Samples
                .Include(s => s.SampleDetails)
                .ThenInclude(sd => sd.AnalysisItem)
                .ThenInclude(ai => ai.AnalysisWaters)
                .ThenInclude(aw => aw.Water)
                .FirstOrDefault(s => s.Id.ToString() == sampleId);
        }

        public SampleResult? FetchWaterAnalysisResult(string analysisResultId)
        {
            return _dbContext.SampleResults
                .Where(sr => sr.Id.ToString() == analysisResultId)
                .Include(sr => sr.SampleResultDetails)
                .ThenInclude(sd => sd.AnalysisItem)
                .ThenInclude(ai => ai.AnalysisWaters)
                .ThenInclude(aw => aw.Water)
                .Include(sr => sr.Sample)
                .FirstOrDefault(s => s.Id.ToString() == analysisResultId);
        }

        public SampleResult? FetchProductionAnalysisResult(string analysisResultId)
        {
            return _dbContext.SampleResults
                .Where(sr => sr.Id.ToString() == analysisResultId)
                .Include(s => s.SampleResultDetails)
                .ThenInclude(sd => sd.AnalysisItem)
                .ThenInclude(ai => ai.AnalysisProducts)
                .ThenInclude(ap => ap.Product)
                .Include(sr => sr.Sample)
                .FirstOrDefault(s => s.Id.ToString() == analysisResultId);
        }

        public List<SampleResultsDetailsWithParameter> FetchSampleResultWithParameters(
            string sampleResultDetailId,
            string analysisType
        )
        {
            if (analysisType.ToLower() == "production")
            {
                return _dbContext.SampleResultsDetailsWithParameters
                    .Where(resultParam => resultParam.SampleResultDetailId.ToString() == sampleResultDetailId)
                    .Include(parameter => parameter.SampleResultDetail)
                    .ThenInclude(resultDetail => resultDetail.AnalysisItem)
                    .ThenInclude(ai => ai.AnalysisProducts)
                    .ThenInclude(ap => ap.Product)
                    .Include(rp => rp.AnalysisParameter)
                    .ThenInclude(ap => ap.ProductAnalysisParameters)
                    .ThenInclude(pap => pap.ProductParameter)
                    .ToList();
            }
            else
            {
                return _dbContext.SampleResultsDetailsWithParameters
                    .Where(resultParam => resultParam.SampleResultDetailId.ToString() == sampleResultDetailId)
                    .Include(parameter => parameter.SampleResultDetail)
                    .ThenInclude(resultDetail => resultDetail.AnalysisItem)
                    .ThenInclude(ai => ai.AnalysisWaters)
                    .ThenInclude(ap => ap.Water)
                    .Include(rp => rp.AnalysisParameter)
                    .ThenInclude(ap => ap.WaterAnalysisParameters)
                    .ThenInclude(wap => wap.WaterParameter)
                    .ToList();
            }
        }

        public Sample CreateSample(
            Guid userId,
            string emp1Id,
            string emp2Id,
            DateOnly date,
            TimeOnly time,
            string analysisType,
            List<AnalysisSampleBindingItem> analysisItems
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

        public Sample? SetSampleAsComplete(string sampleId)
        {
            Sample? sample = _dbContext.Samples.FirstOrDefault(s => s.Id.ToString().Equals(sampleId));

            if (sample == null)
            {
                return null;
            }

            sample.Status = "Completed";
            _dbContext.Samples.Update(sample);

            _dbContext.SaveChanges();

            return sample;
        }

        public SampleResult CreateSampleResult(
            string sampleId,
            string userId,
            List<AnalysisResultSampleDetailBindingItem> sampleDetailsIdsWithParameters
        )
        {
            SampleResult sampleResult = _dbContext.SampleResults.Add(
                new()
                {
                    Id = new Guid(),
                    IsRetest = false,
                    UserId = new Guid(userId),
                    SampleId = new Guid(sampleId),
                    Date =  DateOnly.FromDateTime(DateTime.UtcNow.Date),
                    Time = TimeOnly.FromDateTime(DateTime.UtcNow),
                }
            ).Entity;

            foreach(AnalysisResultSampleDetailBindingItem sampleDetailsIdsWithParameter in sampleDetailsIdsWithParameters)
            {
                SampleResultDetail sampleResultDetail = _dbContext.SampleResultDetails.Add(
                    new SampleResultDetail() {
                        Id = new Guid(),
                        SampleResultId = sampleResult.Id,
                        AnalysisItemId = new Guid(sampleDetailsIdsWithParameter.AnalysisItemId)
                    }
                ).Entity;

                foreach(ParametersWithValues parameterWithValue in sampleDetailsIdsWithParameter.parametersWithValues)
                {
                    _dbContext.SampleResultsDetailsWithParameters.Add(
                        new SampleResultsDetailsWithParameter()
                        {
                            Id = new Guid(),
                            SampleResultDetailId = sampleResultDetail.Id,
                            Value = float.Parse(parameterWithValue.ParameterValue ?? "0.00"),
                            AnalysisParameterId = new Guid(parameterWithValue.ParameterId)
                        }
                    );
                }
            }

            _dbContext.SaveChanges();

            return sampleResult;
        }

        public bool UpdateSampleResult(
            string sampleResultId,
            List<SampleResultsDetailsWithParameter> sampleResultDetailsIdsWithParameters
        )
        {
            try
            {
                sampleResultDetailsIdsWithParameters.ForEach(sr =>
                {
                    _dbContext.SampleResultsDetailsWithParameters
                    .Where(it => it.Id == sr.Id)
                    .ExecuteUpdate(it => it.SetProperty(resultWithParam => resultWithParam.Value, sr.Value));
                });

                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
