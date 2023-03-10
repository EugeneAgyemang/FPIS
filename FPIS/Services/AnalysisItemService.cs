using FPIS.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
namespace FPIS.Services
{
    public class AnalysisItemService
    {
        private readonly AppDbContext _dbContext;

        /// <summary>
        /// Constructor initialize a new `AnalysisItemService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public AnalysisItemService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<AnalysisProduct> FetchAnalysisProducts()
        {
            return this._dbContext.AnalysisProducts
                .Include(ap => ap.Product)
                .ToList();
        }

        public List<AnalysisWater> FetchAnalysisWater()
        {
            return this._dbContext.AnalysisWaters
                .Include(aw => aw.Water)
                .ToList();
        }

        /// <summary>
        /// Checks if the provided product is already an AnalysisProduct
        /// </summary>
        /// <param name="product"></param>
        /// <returns>bool</returns>
        public bool IsProductAnalysisProduct(Product product)
        {
            AnalysisProduct? analysisProduct = _dbContext.AnalysisProducts.FirstOrDefault(
                analysisProduct => analysisProduct.ProductId == product.Id
                );

            if (analysisProduct == null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the provided water is already an AnalysisWater
        /// </summary>
        /// <param name="water"></param>
        /// <returns>bool</returns>
        public bool IsWaterAnAnalysisItem(Water water)
        {
            AnalysisWater? analysisWater = _dbContext.AnalysisWaters.FirstOrDefault(
                analysisWater => analysisWater.WaterId == water.Id
                );

            if (analysisWater == null)
            {
                return false;
            }

            return true;
        }


        public AnalysisProduct CreateAnalysisProduct(Product product)
        {
            var analysisItem = _dbContext.AnalysisItems.Add(new AnalysisItem() { ItemType = "Product" }).Entity;
            var analysisProduct = _dbContext.AnalysisProducts.Add(new AnalysisProduct()
            {
                ProductId = product.Id,
                AnalysisItemId = analysisItem.Id
            }).Entity;

            _dbContext.SaveChanges();
            return analysisProduct;
        }


        public AnalysisWater CreateAnalysisWater(Water water)
        {
            var analysisItem = _dbContext.AnalysisItems.Add(new AnalysisItem() { ItemType = "Water" }).Entity;
            var analysisWater = _dbContext.AnalysisWaters.Add(new AnalysisWater()
            {
                WaterId = water.Id,
                AnalysisItemId = analysisItem.Id
            }).Entity;

            _dbContext.SaveChanges();
            return analysisWater;
        }
    }
}
