using FPIS.Models;
using Moq;
using Microsoft.EntityFrameworkCore;
using FPIS.Services;

namespace FPIS_TEST.Services
{
    [TestClass]
    public class StockItemService
    {
        [TestMethod]
        public void DoesStockItemExists_True_Test()
        {
            var stockItems = new List<StockItem>
            {
                new StockItem() { StockItemName = "St-000-1" },
                new StockItem() { StockItemName = "St-000-2" }
            }.AsQueryable();

            var stockItemsMockSet = new Mock<DbSet<StockItem>>();
            stockItemsMockSet.As<IQueryable<StockItem>>().Setup(m => m.Provider).Returns(stockItems.Provider);
            stockItemsMockSet.As<IQueryable<StockItem>>().Setup(m => m.Expression).Returns(stockItems.Expression);
            stockItemsMockSet.As<IQueryable<StockItem>>().Setup(m => m.ElementType).Returns(stockItems.ElementType);
            stockItemsMockSet.As<IQueryable<StockItem>>().Setup(m => m.GetEnumerator()).Returns(() => stockItems.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.StockItems).Returns(stockItemsMockSet.Object);
            var service = new FPIS.Services.StockItemService(mockContext.Object);

            bool result = service.DoesStockItemExists("St-000-1");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesStockItemExists_False_Test()
        {
            var stockItems = new List<StockItem>
            {
                new StockItem() { StockItemName = "St-000-1" },
                new StockItem() { StockItemName = "St-000-2" }
            }.AsQueryable();

            var stockItemsMockSet = new Mock<DbSet<StockItem>>();
            stockItemsMockSet.As<IQueryable<StockItem>>().Setup(m => m.Provider).Returns(stockItems.Provider);
            stockItemsMockSet.As<IQueryable<StockItem>>().Setup(m => m.Expression).Returns(stockItems.Expression);
            stockItemsMockSet.As<IQueryable<StockItem>>().Setup(m => m.ElementType).Returns(stockItems.ElementType);
            stockItemsMockSet.As<IQueryable<StockItem>>().Setup(m => m.GetEnumerator()).Returns(() => stockItems.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.StockItems).Returns(stockItemsMockSet.Object);
            var service = new FPIS.Services.StockItemService(mockContext.Object);

            bool result = service.DoesStockItemExists("no-product");

            Assert.IsFalse(result);
        }
    }
}
