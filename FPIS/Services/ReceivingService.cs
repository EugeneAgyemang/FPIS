using FPIS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class ReceivingService
    {
        AppDbContext appDbContext;
        public ReceivingService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Receiving SaveMaterialReceivedRecord(Receiving materialReceived)
        {
            Receiving _materialReceived = new Receiving()
            {
                Supplier = materialReceived.Supplier,
                TruckNumber = materialReceived.TruckNumber,
                Quantity = materialReceived.Quantity,
                Units = materialReceived.Units,
                MaterialProcurementId = materialReceived.MaterialProcurementId,
                Country= materialReceived.Country,
                City = materialReceived.City,
                GrossWeight= materialReceived.GrossWeight,
                NetWeight= materialReceived.NetWeight
            };
            appDbContext.Add(_materialReceived);
            appDbContext.SaveChanges();
            return _materialReceived;
        }
        public Receiving UpdateReceivedQuantity(Guid materialReceivedId, int quantityToIssue)
        {
            Receiving receiving = appDbContext.Receivings
                                        .FirstOrDefault(record => 
                                            record.Id == materialReceivedId);
            receiving.Quantity = quantityToIssue;
            appDbContext.Update(receiving);
            appDbContext.SaveChanges();
            return receiving;
        }

        public Receiving UpdateRecord(Receiving receivingRecord)
        {
            Receiving receiving = appDbContext.Update(receivingRecord).Entity;
            appDbContext.SaveChanges();
            return receiving;
        }

        public List<Receiving> FetchReceivedMaterialsPending()
        {
            List<Receiving> receivings = appDbContext.Receivings
                                            .Include(record => record.MaterialProcurement)
                                            .Where(record => record.Units == string.Empty)
                                            .ToList();
            return receivings;
        }

        public Receiving FetchFirstPendingReceivedMaterial()
        {
            Receiving receiving = appDbContext.Receivings
                                        .Where(record => record.Units == string.Empty)
                                        .OrderBy(record => record.MaterialProcurement.Date)
                                        .FirstOrDefault();
            return receiving;
        }

        public Receiving FetchRecordById(Guid id)
        {
            return appDbContext.Receivings
                .FirstOrDefault(record => record.Id == id);
        }
    }
}
