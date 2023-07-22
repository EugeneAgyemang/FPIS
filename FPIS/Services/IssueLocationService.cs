using FPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    public class IssueLocationService
    {
        private AppDbContext appDbContext;

        public IssueLocationService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IssueLocation SaveRecords(List<IssueLocation> issueLocations)
        {
            appDbContext.IssueLocations.AddRange(issueLocations);
            appDbContext.SaveChanges();
            return issueLocations.FirstOrDefault();
        }
    }
}
