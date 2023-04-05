﻿using FPIS.Models;
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
                UserId = materialProcured.UserId,
                Lot = materialProcured.Lot
            };
            appDbContext.Add(materialToBeProcured);
            appDbContext.SaveChanges();
            return materialToBeProcured;
        }
        public MaterialProcurement GetMaterialProcuredById(Guid id)
        {
            return appDbContext.MaterialProcurements.
                                Include(materialProcured => materialProcured.Receivings).
                                Include(materialProcured => materialProcured.Releasings).
                                Include(materialProcured => materialProcured.User).
                                Where(materialProcured => materialProcured.Id == id).
                                FirstOrDefault();
        }
    }
}
