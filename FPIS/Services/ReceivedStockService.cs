using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    /// <summary>
    /// This class represents a service that works on the `Received Stock` model to perform
    /// database transactions.
    /// </summary>
    internal class ReceivedStockService
    {
        private readonly AppDbContext _dbContext;


        /// <summary>
        /// Constructor initialize a new `ReceivedStockService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public ReceivedStockService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Adds a new `Received Stock` with a Received Date, Quantity Recieved 
        /// and Expiry Date
        /// </summary>
        /// <param name="receivedDate"></param>
        /// <param name="quantity"></param>
        /// <param name="balance"></param>
        /// <param name="expiryDate"></param>
        /// <param name="stockItemID"></param>
        /// <param name="userID"></param>
        public ReceivedStock AddReceivedStock(DateOnly receivedDate,int quantity, int balance, DateOnly expiryDate, Guid stockItemID,Guid userID)
        {
            var receivedStock = _dbContext.ReceivedStocks.Add(
                    new()
                    {
                        ReceivedDate = receivedDate,
                        Quantity = quantity,
                        QuantityAvailable = balance,
                        ExpiryDate = expiryDate,
                        StockItemId= stockItemID,
                        UserId= userID
                    }
                ).Entity;

            _dbContext.SaveChanges();

            return receivedStock;
        }
    }
}
