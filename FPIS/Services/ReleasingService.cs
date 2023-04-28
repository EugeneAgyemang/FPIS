using FPIS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class ReleasingService
    {
        AppDbContext appDbContext;
        public ReleasingService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Releasing SaveMaterialToBeReleased(Releasing materialToBeReleased, Guid materialReceivedId)
        {
            Releasing releasing = new Releasing();
            releasing.ReceivingId = materialReceivedId;
            releasing.MaterialProcurementId = materialToBeReleased.MaterialProcurementId;
            releasing.Quantity = materialToBeReleased.Quantity;
            appDbContext.Releasings.Add(releasing);
            appDbContext.SaveChanges();
            return releasing;
        }
        public int GetQuantityIssuedFromMaterialReceived(Guid materialReceivedId)
        {
            int quantityIssued = appDbContext
                                    .Releasings
                                        .Where(
                                            releasing => releasing.ReceivingId 
                                            == materialReceivedId)
                                        .Sum(
                                            releasing => 
                                                releasing.Quantity);
            return quantityIssued;
        }
    }
}
