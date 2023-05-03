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
        public UserControlDashboard()
        {
            InitializeComponent();
            LoadUsers();
            LoadSamples();
            LoadSampleResults();
            LoadPendingSamples();

            // User's live feed
            LiveLoadSamples("pending", SampleRequestedBreakdownDetailsSection, pendingItemXAxis, pendingItemYAxis);
            LiveLoadSamples("completed", SamplesProcessedBreakdownDetailsSection, completedItemXAxis, completedItemYAxis);

        }
        private void LoadUsers()
        {
            RegisteredUsersControl.Text = $"{appDbContext.Users.Count()}";
        }
        private void LoadSamples()
        {
            SamplesControl.Text = $"{appDbContext.Samples.Count()}";
        }
        private void LoadSampleResults()
        {
            SampleResultsControl.Text = $"{appDbContext.SampleResults.Count()}"; ;
        }

        private void LoadPendingSamples()
        {
            SamplesPendingControl.Text = $"{appDbContext.Samples.Count() - appDbContext.SampleResults.Count()}"; ;
        }

        private void LiveLoadSamples(string status, Panel section, int xAxis, int yAxis)
        {
            Guid userId = Guid.Parse(Main.LOGGED_USER_ID);
            LiveLoadProductSamples(userId, status, section, xAxis, yAxis);
            LiveLoadWaterSamples(userId, status, section, xAxis, yAxis);
        }

        private void LiveLoadProductSamples(Guid userId, string status, Panel section, int itemXAxis, int itemYAxis)
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
                MaterialLabel item = AddItem(productName, productCount, itemXAxis, itemYAxis);
                section.Controls.Add(item);
                itemYAxis += 30;
            }
        }

        private void LiveLoadWaterSamples(Guid userId, string status, Panel section, int itemXAxis, int itemYAxis)
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
            if (section.Controls.Count == 1 &&
                section.Controls[0].Text == "There's no data available")
            {
                SampleRequestedBreakdownDetailsSection.Controls.Clear();
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
                MaterialLabel item = AddItem(waterName, waterCount, itemXAxis, itemYAxis);
                section.Controls.Add(item);
                itemYAxis += 30;
            }
        }

        private IQueryable<SampleDetail> LiveLoadItemSamples(Guid userId, string status, string typeForFiltering)
        {
            return appDbContext.SampleDetails
                                    .Include(sampleDetail => sampleDetail.Sample)
                                    .Where(sampleDetail => sampleDetail.Sample.UserId == userId &&
                                                            sampleDetail.Sample.Status.ToLower() == status &&
                                                            sampleDetail.Sample.TypeForFiltering.ToLower() == typeForFiltering);
        }

        private MaterialLabel AddItem(string productName, int productCount, int itemXAxis, int itemYAxis)
        {
            MaterialLabel item = new MaterialLabel();
            item.Location = new Point(itemXAxis, itemYAxis);
            item.FontType = MaterialSkinManager.fontType.Button;
            item.AutoSize = false;
            item.Size = new Size(492, 21);
            item.Text = $"{TruncateLengthyText(productName)} {productCount}";
            helperToolTip.SetToolTip(item, productName);
            return item;
        }

        /// <summary>
        /// Truncate the given text if it exceeds 50 characters.
        /// </summary>
        /// <param name="text">The original text to be checked</param>
        /// <returns>The new text. WOuld only be the same as the original
        /// text provided the original text has less than
        /// 51 characters. Otherwise the truncated version of
        /// text is returned</returns>
        private string TruncateLengthyText(string text)
        {
            StringBuilder newText = new StringBuilder();
            if (text.Length > 50)
            {
                newText.Append(text.Substring(0, 49));
                newText.Append(text.Substring(0, 49));
                newText.Append("...");
            }
            else
            {
                newText.Append(text);
            }
            return newText.ToString();
        }

        private void asyncLoader_Tick(object sender, EventArgs e)
        {
            LiveLoadSamples("pending", SampleRequestedBreakdownDetailsSection, pendingItemXAxis, pendingItemYAxis);
            LiveLoadSamples("completed", SamplesProcessedBreakdownDetailsSection, completedItemXAxis, completedItemYAxis);
        }
    }
}
