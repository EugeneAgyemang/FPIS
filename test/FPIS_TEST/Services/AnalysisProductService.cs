using FPIS.Models;
using Moq;
using Microsoft.EntityFrameworkCore;
using FPIS.Services;

namespace FPIS_TEST.Services
{
    [TestClass]
    public class AnalysisItemServiceTest
    {
        [TestMethod]
        public void IsProductAnalysisProduct_True_Test()
        {
            Product fakeProduct = new() {
                ProductName = "new-product-1",
                Id = new Guid("fa235a48-c005-417b-9599-74f338d8f2b2")
            };

            var fakeAnalysisProducts = new List<AnalysisProduct>
            {
                new AnalysisProduct() { ProductId = fakeProduct.Id }
            }.AsQueryable();

            var analysisProductsMockSet = new Mock<DbSet<AnalysisProduct>>();
            analysisProductsMockSet.As<IQueryable<AnalysisProduct>>().Setup(m => m.Provider).Returns(fakeAnalysisProducts.Provider);
            analysisProductsMockSet.As<IQueryable<AnalysisProduct>>().Setup(m => m.Expression).Returns(fakeAnalysisProducts.Expression);
            analysisProductsMockSet.As<IQueryable<AnalysisProduct>>().Setup(m => m.ElementType).Returns(fakeAnalysisProducts.ElementType);
            analysisProductsMockSet.As<IQueryable<AnalysisProduct>>().Setup(m => m.GetEnumerator()).Returns(() => fakeAnalysisProducts.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.AnalysisProducts).Returns(analysisProductsMockSet.Object);

            var service = new AnalysisItemService(mockContext.Object);

            bool result = service.IsProductAnalysisProduct(fakeProduct);

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void IsProductAnalysisProduct_False_Test()
        {
            Product fakeProduct = new()
            {
                ProductName = "new-product-1",
                Id = new Guid("fa235a48-c005-417b-9599-74f338d8f2b2")
            };

            var fakeAnalysisProducts = new List<AnalysisProduct> { }.AsQueryable(); // empty

            var analysisProductsMockSet = new Mock<DbSet<AnalysisProduct>>();
            analysisProductsMockSet.As<IQueryable<AnalysisProduct>>().Setup(m => m.Provider).Returns(fakeAnalysisProducts.Provider);
            analysisProductsMockSet.As<IQueryable<AnalysisProduct>>().Setup(m => m.Expression).Returns(fakeAnalysisProducts.Expression);
            analysisProductsMockSet.As<IQueryable<AnalysisProduct>>().Setup(m => m.ElementType).Returns(fakeAnalysisProducts.ElementType);
            analysisProductsMockSet.As<IQueryable<AnalysisProduct>>().Setup(m => m.GetEnumerator()).Returns(() => fakeAnalysisProducts.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.AnalysisProducts).Returns(analysisProductsMockSet.Object);

            var service = new AnalysisItemService(mockContext.Object);

            bool result = service.IsProductAnalysisProduct(fakeProduct);

            Assert.IsFalse(result);
        }

    }
}
