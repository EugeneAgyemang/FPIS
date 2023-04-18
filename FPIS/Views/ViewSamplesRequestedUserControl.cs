using FPIS.Models;
using FPIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPIS.Views
{
    public partial class ViewSamplesRequestedUserControl : UserControl
    {
        /// <summary>
        /// Specify the source where the user control is being referenced
        /// </summary>
        public enum Source { PROCUREMENT, PRODUCTION, WATER, ALL };
        private Source source;
        readonly BindingList<ViewSampleRequestsMadeBindingItem> listOfRequests = new BindingList<ViewSampleRequestsMadeBindingItem>();
        public static bool isRequestCompleted = false;
        public ViewSamplesRequestedUserControl(Source source)
        {
            InitializeComponent();
            dataGridView1.DataSource = listOfRequests;
            this.source = source;
            UpdateDataGridColumns();
            LoadSampleRequestsMade();
        }
        void UpdateSamplesRequestedOverview(int totalSamplesRequested)
        {
            if (totalSamplesRequested == 0)
            {
                SamplesRequestedOverviewControl.Text = "No requests made yet";
            }
            else
            {
                SamplesRequestedOverviewControl.Text =
                    $"{totalSamplesRequested} sample{((totalSamplesRequested > 1) ? "s" : "")} requested";
            }
        }
        private void LoadSampleRequestsMade()
        {
            List<Sample> samplesRequested = new ViewSampleRequestedService(new()).GetSamplesRequested(source);
            int totalSamplesRequested = samplesRequested.Count;
            UpdateSamplesRequestedOverview(totalSamplesRequested);
            foreach (var sampleRequested in samplesRequested)
            {
                ViewSampleRequestsMadeBindingItem sampleRequestMade = new ViewSampleRequestsMadeBindingItem();

                sampleRequestMade.SampleIdAsString = Utils.Utils.GetLastCharacters(sampleRequested.Id.ToString(), 4);
                //sampleRequestMade.AnalysisProductId = sampleRequested.SampleDetails.FirstOrDefault().AnalysisItem.AnalysisProducts.FirstOrDefault().ProductId;
                sampleRequestMade.SampleId = sampleRequested.Id;
                sampleRequestMade.SampleDetailId = sampleRequested.SampleDetails.FirstOrDefault().Id;
                sampleRequestMade.AnalysisItemId = sampleRequested.SampleDetails.FirstOrDefault().AnalysisItemId;
               // sampleRequestMade.AnalysisProductId = sampleRequested.SampleDetails.FirstOrDefault().AnalysisItem.AnalysisProducts.FirstOrDefault().Id;
                sampleRequestMade.Date = sampleRequested.Date;
                sampleRequestMade.Time = sampleRequested.Time;
                sampleRequestMade.Status = sampleRequested.Status;
                sampleRequestMade.TypeForFiltering = sampleRequested.TypeForFiltering;

                sampleRequestMade.EngineerOne = LoadUser(sampleRequested.Employee1).Id;
                sampleRequestMade.EngineerTwo = LoadUser(sampleRequested.Employee2).Id;


                sampleRequestMade.EngineerOne = LoadUser(sampleRequested.Employee1).Id;
                sampleRequestMade.EngineerTwo = LoadUser(sampleRequested.Employee2).Id;
                sampleRequestMade.EngineerOneEmpId = sampleRequested.Employee1;
                sampleRequestMade.EngineerTwoEmpId = sampleRequested.Employee2;
                //if (sampleRequested.TypeForFiltering.ToLower() != "raw materials")
                if (sampleRequested.SampleDetails.FirstOrDefault().AnalysisItem.AnalysisProducts.FirstOrDefault().Product.Type.ToLower() != "raw materials")
                {
                    sampleRequestMade.EngineerOneFullName = LoadUserFullName(sampleRequestMade.EngineerOne);
                    sampleRequestMade.EngineerTwoFullName = LoadUserFullName(sampleRequestMade.EngineerTwo);
                    sampleRequestMade.Engineer = "";
                }
                else
                {
                    sampleRequestMade.EngineerOneFullName = LoadUserFullName(sampleRequestMade.EngineerOne);
                    sampleRequestMade.Engineer = LoadUserFullName(sampleRequestMade.EngineerOne);
                    sampleRequestMade.EngineerTwoFullName = "";
                }

                listOfRequests.Add(sampleRequestMade);

            }
        }
        public void UpdateDataGridColumns()
        {
            switch (source)
            {
                case Source.PROCUREMENT:
                    dataGridView1.Columns["EngineerOneFullName"].Visible =
                        dataGridView1.Columns["EngineerTwoFullName"].Visible =
                        dataGridView1.Columns["TypeForFiltering"].Visible = false;

                    dataGridView1.Columns["Engineer"].Visible = true;
                    break;
                case Source.PRODUCTION:
                case Source.WATER:
                    dataGridView1.Columns["EngineerOneFullName"].Visible =
                        dataGridView1.Columns["EngineerTwoFullName"].Visible = true;

                    dataGridView1.Columns["Engineer"].Visible =
                        dataGridView1.Columns["TypeForFiltering"].Visible = false;
                    break;
                case Source.ALL:
                    dataGridView1.Columns["EngineerOneFullName"].Visible =
                       dataGridView1.Columns["EngineerTwoFullName"].Visible =
                        dataGridView1.Columns["TypeForFiltering"].Visible = true;

                    dataGridView1.Columns["Engineer"].Visible = false;
                    break;
            }
        }

        private User? LoadUser(string empId)
        {
            return new UserService(new()).GetUserByEmployeeId(empId);
        }
        private string LoadUserFullName(Guid id)
        {
            return new UserService(new()).GetFullName(id);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            string sampleId = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string typeForFiltering = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString().ToLower();

            if (source == Source.PRODUCTION)
            {

            }
            else if (source == Source.ALL)
            {
                new AddAnalysisResultForm(sampleId, typeForFiltering).ShowDialog();
            }
            if (isRequestCompleted)
            {
                listOfRequests.RemoveAt(e.RowIndex);
                UpdateSamplesRequestedOverview(listOfRequests.Count);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs args)
        {
            if (args.RowIndex == 0)
            {
                return;
            }
            if (IsRepeatedCellValue(args.RowIndex, args.ColumnIndex))
            {
                args.Value = string.Empty;
                args.FormattingApplied = true;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs args)
        {
            args.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            args.CellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            if (args.RowIndex < 1 || args.ColumnIndex < 0)
            {
                return;
            }
            if (IsRepeatedCellValue(args.RowIndex, args.ColumnIndex))
            {
                args.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                args.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            }
        }
        private bool IsRepeatedCellValue(int rowIndex, int colIndex)

        {

            DataGridViewCell currCell = dataGridView1.Rows[rowIndex].Cells[colIndex];
            DataGridViewCell prevCell = dataGridView1.Rows[rowIndex - 1].Cells[colIndex];
            if ((currCell.Value == prevCell.Value) || (currCell.Value != null && prevCell.Value != null && currCell.Value.ToString() == prevCell.Value.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
