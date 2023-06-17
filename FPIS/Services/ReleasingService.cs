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
        public Releasing SaveMaterialToBeReleased(Releasing materialToBeReleased)
        {
            Releasing releasing = new Releasing();
            releasing = appDbContext.Releasings.Add(materialToBeReleased).Entity;
            appDbContext.SaveChanges();
            return releasing;
        }
    }
}
