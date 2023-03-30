using FPIS.Models;
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
        public Releasing SaveMaterialsToBeReleased(Releasing materialToBeReleased)
        {
            Releasing releasing = new Releasing();
            releasing.ReceivingId = materialToBeReleased.ReceivingId;
            releasing.MaterialProcurementId = materialToBeReleased.MaterialProcurementId;
            appDbContext.Releasings.Add(releasing);
            appDbContext.SaveChanges();
            return releasing;
        }
    }
}
