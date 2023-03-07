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
    public partial class SelectAnalysisTypeForm : Form
    {
        public SelectAnalysisTypeForm()
        {
            InitializeComponent();
        }

        private void materialButtonProductionAnalysis_Click(object sender, EventArgs e)
        {
            CreateAnalysisRequestForm.analysisType = "Production";
            Close();
        }

        private void materialButtonWaterAnalysis_Click(object sender, EventArgs e)
        {
            CreateAnalysisRequestForm.analysisType = "Water";
            Close();
        }
    }
}
