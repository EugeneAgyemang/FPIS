using FPIS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class MaterialProcurementService
    {
        AppDbContext appDbContext;
        public MaterialProcurementService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public MaterialProcurement SaveMaterialProcuredRecord(MaterialProcurement materialProcured)
        {
            MaterialProcurement materialToBeProcured = new MaterialProcurement()
            {
                ProductId = materialProcured.ProductId,
                Location = materialProcured.Location,
                Date = materialProcured.Date,
                Remarks = materialProcured.Remarks,
                Type = materialProcured.Type,
                UserId = materialProcured.UserId
            };
            appDbContext.Add(materialToBeProcured);
            appDbContext.SaveChanges();
            return materialToBeProcured;
        }
        public Receiving SaveMaterialReceivedRecord(Receiving materialReceived)
        {
            Receiving _materialReceived = new Receiving()
            {
                Supplier = materialReceived.Supplier,
                TruckNumber = materialReceived.TruckNumber,
                Quantity= materialReceived.Quantity,
                Units= materialReceived.Units,
                MaterialProcurementId = materialReceived.MaterialProcurementId
            };
            appDbContext.Add(_materialReceived);
            appDbContext.SaveChanges();
            return _materialReceived;
        }
    }
}
