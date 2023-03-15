using FPIS.Models;
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
    public partial class CreateAnalysisForm : Form
    {
        public static string analysisType = "";
        public static string selecteds = "";
        public static BindingList<AnalysisSampleBindingItem> analysisItemList = new();

        public CreateAnalysisForm()
        {
            InitializeComponent();

            if (String.IsNullOrEmpty(analysisType))
            {
                SelectAnalysisTypeForm selectAnalysisTypeForm = new();
                DialogResult result = selectAnalysisTypeForm.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    // this.Close();
                }
                this.Text = $"New {analysisType} Analysis";
            }

            dataGridView1.DataSource = analysisItemList;
        }

        private void materialButtonAddSample_Click(object sender, EventArgs e)
        {
            AddAnalysisSampleForm addAnalysisSampleForm = new()
            {
                AnalysisType = analysisType
            };
            addAnalysisSampleForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "";

            analysisItemList.ToList().ForEach(item =>
            {
                data += item.Name;
            });

            MessageBox.Show(data);
        }

        private void materialButtonRequestAnalysis_Click(object sender, EventArgs e)
        {
            
        }
    }
}
