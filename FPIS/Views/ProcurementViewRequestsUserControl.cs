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
    public partial class ProcurementViewRequestsUserControl : UserControl
    {
        private static ProcurementViewRequestsUserControl instance;
        readonly BindingList<ViewSampleRequestsMadeBindingItem> listOfRequests = new BindingList<ViewSampleRequestsMadeBindingItem>();
        private ProcurementViewRequestsUserControl()
        {
            InitializeComponent();
            dataGridView1.DataSource = listOfRequests;

            LoadSampleRequestsMade();
        }

        private void LoadSampleRequestsMade()
        {
            List<Sample> samplesRequested = new ViewSampleRequestedService(new()).GetSamplesRequested("shea nut");
            foreach (var sampleRequested in samplesRequested)
            {
                    ViewSampleRequestsMadeBindingItem sampleRequestMade = new ViewSampleRequestsMadeBindingItem();

                    sampleRequestMade.SampleIdAsString = Utils.Utils.GetLastCharacters(sampleRequested.Id.ToString(), 4);
                    sampleRequestMade.ProductId = sampleRequested.SampleDetails.FirstOrDefault().AnalysisItem.AnalysisProducts.FirstOrDefault().ProductId;
                    sampleRequestMade.SampleId = sampleRequested.Id;
                    sampleRequestMade.SampleDetailId = sampleRequested.SampleDetails.FirstOrDefault().Id;
                    sampleRequestMade.AnalysisItemId = sampleRequested.SampleDetails.FirstOrDefault().AnalysisItemId;
                    sampleRequestMade.AnalysisProductId = sampleRequested.SampleDetails.FirstOrDefault().AnalysisItem.AnalysisProducts.FirstOrDefault().Id;
                    sampleRequestMade.Date = sampleRequested.Date;
                    sampleRequestMade.Time = sampleRequested.Time;
                    sampleRequestMade.Status = sampleRequested.Status;
                    sampleRequestMade.TypeForFiltering = sampleRequested.TypeForFiltering;
                    sampleRequestMade.EngineerOne = LoadUser(sampleRequested.Employee1).Id;
                    sampleRequestMade.EngineerTwo = LoadUser(sampleRequested.Employee2).Id;
                    sampleRequestMade.EngineerOneEmpId = sampleRequested.Employee1;
                    sampleRequestMade.EngineerTwoEmpId = sampleRequested.Employee2;
                    sampleRequestMade.EngineerOneFullName = LoadUserFullName(sampleRequestMade.EngineerOne);
                    sampleRequestMade.EngineerTwoFullName = LoadUserFullName(sampleRequestMade.EngineerTwo);

                    listOfRequests.Add(sampleRequestMade);
                
            }
        }

        private User? LoadUser(string empId)
        {
            return new UserService(new()).GetUserByEmpId(empId);
        }
        private string LoadUserFullName(Guid id)
        {
            return new UserService(new()).GetFullName(id);
        }

        public static ProcurementViewRequestsUserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProcurementViewRequestsUserControl();
                    return instance;
                }
                return instance;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
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
