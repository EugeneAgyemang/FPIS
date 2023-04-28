using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    /// <summary>
    /// This class represents a service that works on the `Issue Stock` model to perform
    /// database transactions.
    /// </summary>
    internal class IssueStockService
    {
        private readonly AppDbContext _dbContext;


        /// <summary>
        /// Constructor initialize a new `IssueStockService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public IssueStockService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Adds a new `Issue Stock` with a Quantity Issued, Issued Date 
        /// </summary>
        /// <param name="quantityIssued"></param>
        /// <param name="issuedDate"></param>
        /// <param name="stockItemID"></param>
        public IssuedStock AddIssuedStock(int quantityIssued, DateOnly issuedDate, Guid stockItemID)
        {
            var issuedStock = _dbContext.IssuedStocks.Add(
                    new()
                    {
                        QuantityIssued = quantityIssued,
                        IssuedDate = issuedDate,
                        StockItemId = stockItemID
                    }
                ).Entity;

            _dbContext.SaveChanges();

            return issuedStock;
        }

    }
}
