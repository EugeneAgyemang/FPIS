using FPIS.Models;
using Moq;
using Microsoft.EntityFrameworkCore;
using FPIS.Services;

namespace FPIS_TEST.Services
{
    [TestClass]
    public class WaterServiceTest
    {
        [TestMethod]
        public void DoesProductExists_True_Test()
        {
            var fakeWaters = new List<Water>
            {
                new Water() { WaterName = "w-000-1" },
                new Water() { WaterName = "w-000-2" }
            }.AsQueryable();

            var watersMockSet = new Mock<DbSet<Water>>();
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.Provider).Returns(fakeWaters.Provider);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.Expression).Returns(fakeWaters.Expression);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.ElementType).Returns(fakeWaters.ElementType);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.GetEnumerator()).Returns(() => fakeWaters.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.Waters).Returns(watersMockSet.Object);
            var service = new WaterService(mockContext.Object);

            bool result = service.DoesWaterExists("w-000-1");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesProductExists_False_Test()
        {
            var fakeWaters = new List<Water>
            {
                new Water() { WaterName = "w-000-1" },
                new Water() { WaterName = "w-000-2" }
            }.AsQueryable();

            var watersMockSet = new Mock<DbSet<Water>>();
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.Provider).Returns(fakeWaters.Provider);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.Expression).Returns(fakeWaters.Expression);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.ElementType).Returns(fakeWaters.ElementType);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.GetEnumerator()).Returns(() => fakeWaters.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.Waters).Returns(watersMockSet.Object);
            var service = new WaterService(mockContext.Object);

            bool result = service.DoesWaterExists("w-000-no-water-like-this");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetAllWater_Test()
        {
            var fakeWaters = new List<Water>
            {
                new Water() { WaterName = "w-000-1" },
                new Water() { WaterName = "w-000-2" }
            }.AsQueryable();

            var watersMockSet = new Mock<DbSet<Water>>();
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.Provider).Returns(fakeWaters.Provider);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.Expression).Returns(fakeWaters.Expression);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.ElementType).Returns(fakeWaters.ElementType);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.GetEnumerator()).Returns(() => fakeWaters.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.Waters).Returns(watersMockSet.Object);
            var service = new WaterService(mockContext.Object);

            List<Water> waterList = service.GetAllWater();
            Water? firstItem = waterList.FirstOrDefault(w => w.WaterName == "w-000-1");
            Water? secondItem = waterList.FirstOrDefault(w => w.WaterName == "w-000-2");

            Assert.AreEqual(waterList.Count, 2);
            Assert.AreEqual(firstItem?.WaterName, "w-000-1");
            Assert.AreEqual(secondItem?.WaterName, "w-000-2");
        }


        [TestMethod]
        public void GetWaterByName_Test()
        {
            var fakeWaters = new List<Water>
            {
                new Water() { WaterName = "w-000-1" },
                new Water() { WaterName = "w-000-2" }
            }.AsQueryable();

            var watersMockSet = new Mock<DbSet<Water>>();
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.Provider).Returns(fakeWaters.Provider);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.Expression).Returns(fakeWaters.Expression);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.ElementType).Returns(fakeWaters.ElementType);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.GetEnumerator()).Returns(() => fakeWaters.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.Waters).Returns(watersMockSet.Object);
            var service = new WaterService(mockContext.Object);

            Water? water = service.GetWaterByName("w-000-1");

            Assert.AreEqual(water?.WaterName, "w-000-1");
        }


        [TestMethod]
        public void GetWaterByName_Test_Null()
        {
            var fakeWaters = new List<Water>
            {
                new Water() { WaterName = "w-000-1" },
                new Water() { WaterName = "w-000-2" }
            }.AsQueryable();

            var watersMockSet = new Mock<DbSet<Water>>();
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.Provider).Returns(fakeWaters.Provider);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.Expression).Returns(fakeWaters.Expression);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.ElementType).Returns(fakeWaters.ElementType);
            watersMockSet.As<IQueryable<Water>>().Setup(m => m.GetEnumerator()).Returns(() => fakeWaters.GetEnumerator());

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.Waters).Returns(watersMockSet.Object);
            var service = new WaterService(mockContext.Object);

            Water? water = service.GetWaterByName("w-000-5");

            Assert.AreEqual(water, null);
        }

    }
}
