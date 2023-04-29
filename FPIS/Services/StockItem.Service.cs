using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{

    /// <summary>
    /// This class represents a service that works on the `StockItem` model to perform
    /// database transactions.
    /// </summary>
    public class StockItemService
    {

        private readonly AppDbContext _dbContext;


        /// <summary>
        /// Constructor initialize a new `StockItemService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public StockItemService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Checks if a stock item name already exists.
        /// </summary>
        /// <param name="stockItemName"></param>
        /// <returns></returns>
        public bool DoesStockItemExists(string stockItemName)
        {
            var stockItem = _dbContext.StockItems.FirstOrDefault(si => si.StockItemName.ToLower() == stockItemName.ToLower());

            if (stockItem != null)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Creates a new `Stock Item` with a Stock Item Name, Unit of Measurement 
        /// and Item type
        /// </summary>
        /// <param name="stockItemName"></param>
        /// <param name="unitOfMeasurement"></param>
        /// <param name="itemType"></param>
        public StockItem CreateStockItem(string stockItemName, string unitOfMeasurement, string itemType)
        {
            var stockItem = _dbContext.StockItems.Add(
                    new()
                    {
                        StockItemName = stockItemName,
                        Unit = unitOfMeasurement,
                        StockItemType = itemType
                    }
                ).Entity;

            _dbContext.SaveChanges();

            return stockItem;
        }

        public string GetStockItemName(Guid id)
        {
            string itemName;
            StockItem item = _dbContext.StockItems.FirstOrDefault(item => item.Id == id);
            itemName = item.StockItemName;
            return itemName;
        }

        public string GetStockItemType(Guid id)
        {
            string itemType;
            StockItem item = _dbContext.StockItems.FirstOrDefault(item => item.Id == id);
            itemType = item.StockItemType;
            return itemType;
        }
    }
}
