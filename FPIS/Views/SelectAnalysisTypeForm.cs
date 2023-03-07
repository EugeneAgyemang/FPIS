namespace FPIS.Views
{
    public partial class SelectAnalysisTypeForm : Form
    {
        public SelectAnalysisTypeForm()
        {
            InitializeComponent();
            materialComboBoxAnalysisType.DataSource =
                new string[] { "Production", "Water" };
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

        private void materialButtonContinue_Click(object sender, EventArgs e)
        {
            CreateAnalysisRequestForm.analysisType =
                materialComboBoxAnalysisType.SelectedItem.ToString();

            Close();
        }
    }
}
