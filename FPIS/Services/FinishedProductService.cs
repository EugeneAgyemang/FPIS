using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    /// <summary>
    /// This class represents a service that works on the `Finished Product` model to perform
    /// database transactions.
    /// </summary>
    /// 
    internal class FinishedProductService
    {
        private readonly AppDbContext _dbContext;


        /// <summary>
        /// Constructor initialize a new `FinishedProductService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public FinishedProductService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Adds a new `Finished Product` with a Date, Cosignee, Product Type, Batch Number, Container Number
        /// Seal Number, Quantity
        /// </summary>
        /// <param name="date"></param>
        /// <param name="cosignee"></param>
        /// <param name="productType"></param>
        ///<param name="batchNumber"></param>
        ///<param name="containerNumber"></param>
        ///<param name="sealNumber"></param>
        ///<param name="quantity"></param>
        ///<param name="sampleResultID"></param>
        public FinishedProduct AddFinishedProduct(DateOnly date, string cosignee, string productType, string batchNumber, string containerNumber, string sealNumber, string quantity, Guid sampleResultID)
        {
            var finishedProduct = _dbContext.FinishedProducts.Add(
                    new()
                    {
                        Date = date,
                        Consignee = cosignee,
                        ProductType = productType, 
                        BatchNumber = batchNumber,
                        ContainerNumber = containerNumber,
                        SealNumber = sealNumber,
                        Quantity= quantity,
                        SampleResultId= sampleResultID
                    }
                ).Entity;

            _dbContext.SaveChanges();

            return finishedProduct;
        }
    }
}
