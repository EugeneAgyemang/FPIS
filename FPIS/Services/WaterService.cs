using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FPIS.Services
{
    /// <summary>
    /// This class represents a service that works the `Products` models to perform
    /// database transactions.
    /// </summary>
    public class WaterService
    {
        private readonly AppDbContext _dbContext;

        /// <summary>
        /// Constructor initialize a new `WaterService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public WaterService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Checks if a water exists already.
        /// </summary>
        /// <param name="waterName"></param>
        /// <returns></returns>
        public bool DoesWaterExists(string waterName)
        {
            var water = _dbContext.Waters.FirstOrDefault(p => p.WaterName.ToLower() == waterName.ToLower());

            if (water != null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Creates a new `Water` with the provided name
        /// </summary>
        /// <param name="name"></param>
        public Water CreateWater(string name)
        {
            var water = _dbContext.Waters.Add(
                    new()
                    {
                        WaterName = name
                    }
                ).Entity;

            _dbContext.SaveChanges();

            return water;
        }
    }
}
