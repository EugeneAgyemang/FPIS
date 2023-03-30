﻿using FPIS.Models;
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
                MaterialProcurementId = materialReceived.MaterialProcurementId
            };
            appDbContext.Add(_materialReceived);
            appDbContext.SaveChanges();
            return _materialReceived;
        }
    }
}