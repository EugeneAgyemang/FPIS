using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    /// <summary>
    /// This class represents a service that works on the `Analysis Remark` model to perform
    /// database transactions.
    /// </summary>
    internal class AnalysisRemarkService
    {
        private readonly AppDbContext _dbContext;


        /// <summary>
        /// Constructor initialize a new `AnalysisRemarkService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param> 
        public AnalysisRemarkService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Adds a new `Analysis Remark` with a Analysis Remark, Date ,SampleDetailID , SampleResultDetailID,userID
        /// </summary>
        /// <param name="analysisRemark"></param>
        /// <param name="date"></param> 
        /// <param name="sampleDetailID"></param>
        /// <param name="sampleResultDetailID"></param>
        /// <param name="userID"></param>
        /// <param name="time"></param>
        /// <param name="analysisItem"></param>
        public AnalysisRemark AddAnalysisRemark(string analysisRemark, DateOnly date, Guid sampleDetailID, Guid sampleResultDetailID, Guid userID, TimeOnly time, string analysisItem)
        {
            var addAnalysisRemark = _dbContext.AnalysisRemarks.Add(
                    new()
                    {
                        Remark = analysisRemark,
                        Date = date,
                        SampleDetailId = sampleDetailID,
                        SampleResultDetailId = sampleResultDetailID,
                        UserId = userID,
                        Time= time,
                        AnalysisItem = analysisItem
                        

                    }
                ).Entity;

            _dbContext.SaveChanges();

            return addAnalysisRemark;
        }
    }
}
