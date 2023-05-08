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
        public MaterialProcurement GetMaterialProcuredById(Guid id)
        {
            return appDbContext.MaterialProcurements.
                                Include(materialProcured => materialProcured.Receivings).
                                Include(materialProcured => materialProcured.Releasings).
                                Include(materialProcured => materialProcured.User).
                                Where(materialProcured => materialProcured.Id == id).
                                FirstOrDefault();
        }
        public List<MaterialProcurement> GetMaterialsProcuredForItem(Guid analysisItemId)
        {
            List<MaterialProcurement> materialProcurements = appDbContext.MaterialProcurements
                                                                .Include(materialProcurement => materialProcurement.Receivings)
                                                                .Include(materialProcurement => materialProcurement.Product)
                                                                .ThenInclude(product => product.AnalysisProducts)
                                                                .ThenInclude(analysisProduct => analysisProduct.AnalysisItem)
                                                                .Where(materialProcurement => materialProcurement
                                                                                                .Product
                                                                                                .AnalysisProducts
                                                                                                .FirstOrDefault()
                                                                                                .AnalysisItemId == analysisItemId)
                                                                .ToList();
            return materialProcurements;
        }
        // DELETE THIS FUNCTION
        public Product GetProductForRawMaterial(Guid materialProcurementId)
        {
            Product product = appDbContext.Products.FirstOrDefault(product => product.MaterialProcurements.FirstOrDefault().Id == materialProcurementId);
            return product;
        }
    }
}
