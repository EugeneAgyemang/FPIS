using FPIS.Models;
using Moq;
using Microsoft.EntityFrameworkCore;
using FPIS.Services;

namespace FPIS_TEST.Services
{
    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void DoesProductExists_True_Test()
        {
            var products = new List<Product>
            {
                new Product() { ProductName = "000-1" },
                new Product() { ProductName = "000-2" }
            }.AsQueryable();

            var productsMockSet = new Mock<DbSet<Product>>();
            productsMockSet.As<IQueryable<Product>>().Setup(m => m.Provider).Returns(products.Provider);
            productsMockSet.As<IQueryable<Product>>().Setup(m => m.Expression).Returns(products.Expression);
            productsMockSet.As<IQueryable<Product>>().Setup(m => m.ElementType).Returns(products.ElementType);
            productsMockSet.As<IQueryable<Product>>().Setup(m => m.GetEnumerator()).Returns(() => products.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.Products).Returns(productsMockSet.Object);
            var service = new ProductService(mockContext.Object);

            bool result = service.DoesProductExists("000-1");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesProductExists_False_Test()
        {
            var products = new List<Product>
            {
                new Product() { ProductName = "000-1" },
                new Product() { ProductName = "000-2" }
            }.AsQueryable();

            var productsMockSet = new Mock<DbSet<Product>>();
            productsMockSet.As<IQueryable<Product>>().Setup(m => m.Provider).Returns(products.Provider);
            productsMockSet.As<IQueryable<Product>>().Setup(m => m.Expression).Returns(products.Expression);
            productsMockSet.As<IQueryable<Product>>().Setup(m => m.ElementType).Returns(products.ElementType);
            productsMockSet.As<IQueryable<Product>>().Setup(m => m.GetEnumerator()).Returns(() => products.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.Products).Returns(productsMockSet.Object);
            var service = new ProductService(mockContext.Object);

            bool result = service.DoesProductExists("no-product");

            Assert.IsFalse(result);
        }
    }
}
