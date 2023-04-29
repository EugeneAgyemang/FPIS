using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    /// <summary>
    /// This class represents a service that works on the `Daily Production Report` model to perform
    /// database transactions.
    /// </summary>
    /// 
    internal class DailyProductionReportService
    {
        private readonly AppDbContext _dbContext;


        /// <summary>
        /// Constructor initialize a new `DailyProductionReportService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public DailyProductionReportService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Adds a new `Daily Production Report` with a Date, EID, TimeIn
        /// </summary>
        /// <param name="date"></param>
        /// <param name="timein"></param>
        /// <param name="userid"></param>
        public ProductionDailyReport AddDailyProductionReport(TimeOnly timein,Guid userid,DateOnly date)
        {
            var dailyProductionReport = _dbContext.ProductionDailyReports.Add(
                    new()
                    {
                        TimeIn = timein,
                        UserId = userid,
                        Date = date
                    }
                ).Entity;

            _dbContext.SaveChanges();

            return dailyProductionReport;
        }
    }
}
