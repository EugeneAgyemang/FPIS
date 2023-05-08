using FPIS.Models;
using FPIS.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPIS.Views
{
    public partial class UserControlDashboard : UserControl
    {
        AppDbContext appDbContext = new AppDbContext();
        int pendingItemXAxis = 25, pendingItemYAxis = 20;
        int completedItemXAxis = 25, completedItemYAxis = 20;
        Guid userId;
        public UserControlDashboard()
        {
            InitializeComponent();
            userId = Guid.Parse(Main.LOGGED_USER_ID);
            LoadUsers();
            SamplesControl.Text = $"{LoadSamples()}";
            SampleResultsControl.Text = $"{LoadSamples("completed")}";
            SamplesPendingControl.Text = $"{LoadSamples("pending")}";

            // User's live feed
            LiveLoadSamples("pending", SampleRequestedBreakdownDetailsSection, ref pendingItemXAxis, ref pendingItemYAxis);
            LiveLoadSamples("completed", SamplesProcessedBreakdownDetailsSection, ref completedItemXAxis, ref completedItemYAxis);

        }
        private void LoadUsers()
        {
            string fullName = new UserService(new()).GetFullName(userId);
            if (fullName.ToLower().Trim() == "super admin")
            {
                RegisteredUsersControl.Text = $"{appDbContext.Users.Count()}";
                return;
            }
            ActiveUsersSection.Visible = false;
            SectionForUser.Location = new Point(87, 54);
        }

        private int LoadSamples(string status = "")
        {
            IQueryable<Sample> sampleQuery = appDbContext.Samples;
            string fullName = new UserService(new()).GetFullName(userId);
            if (fullName.ToLower().Trim() == "super admin")
            {
                if (status == string.Empty)
                {
                    return sampleQuery.Count();
                }
                return sampleQuery.Where(sample => sample.Status.ToLower() == status).Count();
            }
            if (status == string.Empty)
            {
                // Fetch samples which are both Pending and Completed (all samples) for a user
                return sampleQuery.Where(sample => sample.UserId == userId && sample.Status.ToLower() != status).Count();
            }
            return sampleQuery.Where(sample => sample.UserId == userId && sample.Status.ToLower() == status).Count();
        }

        private void LiveLoadSamples(string status, Panel section, ref int xAxis, ref int yAxis)
        {
            LiveLoadProductSamples(userId, status, section, ref xAxis, ref yAxis);
            LiveLoadWaterSamples(userId, status, section, ref xAxis, ref yAxis);
        }

        private void LiveLoadProductSamples(Guid userId, string status, Panel section, ref int itemXAxis, ref int itemYAxis)
        {
            var sampleDetails = LiveLoadItemSamples(userId, status, "production").
                                    GroupBy(a => a.AnalysisItemId)
                                                 .Select(a => new
                                                 {
                                                     AnalysisItemId = a.Key
                                                     ,
                                                     Count = a.Count()
                                                 })
                                                 .ToList();
            if (sampleDetails.Count > 0)
            {
                section.Controls.Clear();
            }
            foreach (var sampleDetail in sampleDetails)
            {
                Product product = appDbContext.AnalysisProducts
                                        .Include(ap => ap.Product)
                                        .FirstOrDefault
                                            (ap => ap.AnalysisItemId == sampleDetail.AnalysisItemId)
                                        .Product;
                string productName = product.ProductName;
                int productCount = sampleDetail.Count;
                MaterialLabel item = AddItem(productName, productCount, ref itemXAxis, ref itemYAxis);
                section.Controls.Add(item);
                itemYAxis += 30;
            }
        }

        private void LiveLoadWaterSamples(Guid userId, string status, Panel section, ref int itemXAxis, ref int itemYAxis)
        {
            var sampleDetails = LiveLoadItemSamples(userId, status, "water").
                                    GroupBy(a => a.AnalysisItemId)
                                                 .Select(a => new
                                                 {
                                                     AnalysisItemId = a.Key
                                                     ,
                                                     Count = a.Count()
                                                 })
                                                 .ToList();
            if (sampleDetails.Count > 0 &&
                section.Controls.Count == 1 &&
                section.Controls[0].Text == "There's no data available")
            {
                section.Controls.Clear();
            }
            foreach (var sampleDetail in sampleDetails)
            {
                Water water = appDbContext.AnalysisWaters
                                        .Include(ap => ap.Water)
                                        .FirstOrDefault
                                            (ap => ap.AnalysisItemId == sampleDetail.AnalysisItemId)
                                        .Water;
                string waterName = water.WaterName;
                int waterCount = sampleDetail.Count;
                MaterialLabel item = AddItem(waterName, waterCount, ref itemXAxis, ref itemYAxis);
                section.Controls.Add(item);
                itemYAxis += 30;
            }
        }

        private IQueryable<SampleDetail> LiveLoadItemSamples(Guid userId, string status, string typeForFiltering)
        {
            IQueryable<SampleDetail> sampleDetailsQuery = appDbContext.SampleDetails
                                    .Include(sampleDetail => sampleDetail.Sample)
                                    .Where(sampleDetail => sampleDetail.Sample.Status.ToLower() == status &&
                                                            sampleDetail.Sample.TypeForFiltering.ToLower() == typeForFiltering &&
                                                            sampleDetail.Sample.Date == DateOnly.FromDateTime(DateTime.Now));

            string fullName = new UserService(new()).GetFullName(userId);
            if (fullName.ToLower().Trim() == "super admin")
            {
                return sampleDetailsQuery;
            }
            sampleDetailsQuery = sampleDetailsQuery.Where(sampleDetail => sampleDetail.Sample.UserId == userId);

            return sampleDetailsQuery;
        }

        private MaterialLabel AddItem(string productName, int productCount, ref int itemXAxis, ref int itemYAxis)
        {
            MaterialLabel item = new MaterialLabel();
            item.Location = new Point(itemXAxis, itemYAxis);
            item.FontType = MaterialSkinManager.fontType.Button;
            item.AutoSize = false;
            item.Size = new Size(492, 21);
            item.Text = $"{Utils.Utils.TruncateLengthyText(productName, 50)} {productCount}";
            helperToolTip.SetToolTip(item, productName);
            return item;
        }

        private void asyncLoader_Tick(object sender, EventArgs e)
        {
            userId = Guid.Parse(Main.LOGGED_USER_ID);
            pendingItemXAxis = completedItemXAxis = 25;
            pendingItemYAxis = completedItemYAxis = 20;
            LiveLoadSamples("pending", SampleRequestedBreakdownDetailsSection, ref pendingItemXAxis, ref pendingItemYAxis);
            LiveLoadSamples("completed", SamplesProcessedBreakdownDetailsSection, ref completedItemXAxis, ref completedItemYAxis);
        }
    }
}
