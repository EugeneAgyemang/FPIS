﻿using FPIS.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private Utils.Form form;
        public ViewSamplesRequestedUserControl(Source source, Utils.Form form)
        {
            InitializeComponent();
            dataGridView1.DataSource = listOfRequests;
            this.source = source;
            this.form = form;
            UpdateDataGridColumns();
            LoadSampleRequestsMade(form);
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
        private void LoadSampleRequestsMade(Utils.Form form)
        {
            List<Sample> samplesRequested = new List<Sample>();
            switch (form)
            {
                case Utils.Form.PROCUREMENT_ISSUE:
                case Utils.Form.PRODUCTION:
                    samplesRequested.AddRange(new AnalysisService(new()).GetProductSamplesRequestedByAUser(source, Guid.Parse(Main.LOGGED_USER_ID), "pending"));
                    break;
                case Utils.Form.QUALITY_CONTROL:
                    samplesRequested.AddRange(new AnalysisService(new()).GetProductSamplesRequestedByAllUsers("pending"));
                    samplesRequested.AddRange(new AnalysisService(new()).GetWaterSamplesRequestedByAllUsers("pending"));
                    break;
            }
            int totalSamplesRequested = samplesRequested.Count;
            UpdateSamplesRequestedOverview(totalSamplesRequested);
            foreach (var sampleRequested in samplesRequested)
            {
                ViewSampleRequestsMadeBindingItem sampleRequestMade = new ViewSampleRequestsMadeBindingItem();

                sampleRequestMade.SampleIdAsString = Utils.Utils.GetLastCharacters(sampleRequested.Id.ToString(), 4);
                sampleRequestMade.SampleId = sampleRequested.Id;
                //sampleRequestMade.SampleId = sampleRequested.Id;
                //sampleRequestMade.SampleDetailId = sampleRequested.SampleDetails.FirstOrDefault().Id;
                //sampleRequestMade.AnalysisItemId = sampleRequested.SampleDetails.FirstOrDefault().AnalysisItemId;
                sampleRequestMade.Date = sampleRequested.Date;
                sampleRequestMade.Time = sampleRequested.Time;
                sampleRequestMade.TypeForFiltering = sampleRequested.TypeForFiltering;
                sampleRequestMade.Status = "Pending";
                //sampleRequestMade.EngineerOne = LoadUser(sampleRequested.Employee1).Id;
                //sampleRequestMade.EngineerTwo = LoadUser(sampleRequested.Employee2).Id;


                //sampleRequestMade.EngineerOneEmpId = sampleRequested.Employee1;
                //sampleRequestMade.EngineerTwoEmpId = sampleRequested.Employee2;

                sampleRequestMade.EngineerOneFullName = LoadUserFullName(sampleRequested.Employee1);
                sampleRequestMade.EngineerTwoFullName = LoadUserFullName(sampleRequested.Employee2);
                if (sampleRequested.TypeForFiltering.ToLower() == "production" &&
                    sampleRequested.Employee1 == sampleRequested.Employee2)
                {
                    //sampleRequestMade.Engineer = sampleRequestMade.EngineerOneFullName;
                    sampleRequestMade.EngineerTwoFullName = string.Empty;
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
                        dataGridView1.Columns["EngineerTwoFullName"].Visible = false;
                    //dataGridView1.Columns["TypeForFiltering"].Visible = false;

                    //dataGridView1.Columns["Engineer"].Visible = true;
                    break;
                case Source.PRODUCTION:
                case Source.WATER:
                    dataGridView1.Columns["EngineerOneFullName"].Visible =
                        dataGridView1.Columns["EngineerTwoFullName"].Visible = true;

                    //dataGridView1.Columns["Engineer"].Visible =
                    //    dataGridView1.Columns["TypeForFiltering"].Visible = false;
                    break;
                case Source.ALL:
                    dataGridView1.Columns["EngineerOneFullName"].Visible =
                       dataGridView1.Columns["EngineerTwoFullName"].Visible = true;
                    //dataGridView1.Columns["TypeForFiltering"].Visible = true;

                    //dataGridView1.Columns["Engineer"].Visible = false;
                    break;
            }
        }
        private User? LoadUser(string empId)
        {
            return new UserService(new()).GetUserByEmployeeId(empId);
        }
        private string LoadUserFullName(string empId)
        {
            return new UserService(new()).GetFullName(empId);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || form != Utils.Form.QUALITY_CONTROL)
            {
                return;
            }
            string sampleId = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string typeForFiltering = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().ToLower();
            UpdateRawMaterialSampleRequestStatus(Guid.Parse(sampleId), ProcurementReceiveMaterialsUserControl.ANALYZED);
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
                UpdateRawMaterialSampleRequestStatus(Guid.Parse(sampleId), ProcurementReceiveMaterialsUserControl.DONE);
            }
            else
            {
                UpdateRawMaterialSampleRequestStatus(Guid.Parse(sampleId), ProcurementReceiveMaterialsUserControl.EN_ROUTE);
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
        private void UpdateRawMaterialSampleRequestStatus(Guid sampleUserClicked, string status)
        {
            FileInfo[] receivedFiles = LoadRawMaterialsRequestedFiles(ProcurementReceiveMaterialsUserControl.DIRECTORY_NAME);
            UpdateFilesForSample(receivedFiles, sampleUserClicked, status, Utils.Form.PROCUREMENT_RECEIVE);

            FileInfo[] issuedFiles = LoadRawMaterialsRequestedFiles(ProcurementIssueMaterials.DIRECTORY_NAME);
            UpdateFilesForSample(issuedFiles, sampleUserClicked, status, Utils.Form.PROCUREMENT_ISSUE);

        }
        private FileInfo[] LoadRawMaterialsRequestedFiles(string directory)
        {
            List<FileInfo> cachedFiles = new List<FileInfo>();
            FileInfo[] filesInDirectory = JsonParser.GetFiles(directory);
            foreach (FileInfo file in filesInDirectory)
            {
                if (file.Name.StartsWith("schema"))
                {
                    continue;
                }
                cachedFiles.Add(file);
            }
            return cachedFiles.ToArray();
        }
        private void UpdateFilesForSample(FileInfo[] files, Guid sampleUserClicked, string status, Utils.Form form)
        {
            string json;
            foreach (FileInfo file in files)
            {
                json = JsonParser.Read(file.FullName);
                dynamic aSampleRequestedByAnyUser = (form == Utils.Form.PROCUREMENT_RECEIVE) ?
                                                                                        (MaterialProcurementSchema)JsonParser
                                                                                            .Parse<MaterialProcurementSchema>
                                                                                            (json)
                                                                                            :
                                                                                            (MaterialIssueSchema)JsonParser
                                                                                            .Parse<MaterialIssueSchema>
                                                                                            (json);
                if (aSampleRequestedByAnyUser.SampleDetail.Sample.Id == sampleUserClicked)
                {
                    aSampleRequestedByAnyUser.Status = status;
                    json = (form == Utils.Form.PROCUREMENT_RECEIVE) ?
                        JsonParser.Stringify<MaterialProcurementSchema>(aSampleRequestedByAnyUser)
                        :
                        JsonParser.Stringify<MaterialIssueSchema>(aSampleRequestedByAnyUser);
                    JsonParser.Write(json, file.FullName);
                }
            }
        }
    }
}
