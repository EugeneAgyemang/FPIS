using FPIS.Models;
using FPIS.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class ProcurementLocationService
    {
        private AppDbContext appDbContext;

        public ProcurementLocationService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Models.ProcurementLocation SaveRecords(List<Models.ProcurementLocation> procurementLocations)
        {
            appDbContext.ProcurementLocations.AddRange(procurementLocations);
            appDbContext.SaveChanges();
            return procurementLocations.FirstOrDefault();
        }

        public List<Models.ProcurementLocation> GetProcurmentLocation(Guid receivingId)
        {
            List<Models.ProcurementLocation> procurementLocations = appDbContext.ProcurementLocations
                                                                .Include(procurementLocation => procurementLocation.Receiving)
                                                                .Where(procurementLocation => procurementLocation.ReceivingId == receivingId)
                                                                .ToList();
            return procurementLocations;
        }

        public List<Models.ProcurementLocation> UpdateQuantity(List<IssueLocation> issueLocations)
        {
            List<Models.ProcurementLocation> updatedRecords = appDbContext
                                                                .ProcurementLocations
                                                                .ToList();
            updatedRecords.ForEach(record =>
            {
                issueLocations.ForEach(issueLocation =>
                {
                    if (record.Id == issueLocation.ProcurementLocationId)
                    {
                        record.Quantity -= issueLocation.Quantity;
                    }
                });
            });
            appDbContext.UpdateRange(updatedRecords);
            appDbContext.SaveChanges();

            return updatedRecords;
        }
    }
}
