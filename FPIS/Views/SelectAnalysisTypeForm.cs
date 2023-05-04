using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class SelectAnalysisTypeForm : MaterialForm
    {
        public SelectAnalysisTypeForm()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            materialComboBoxAnalysisType.DataSource =
                new string[] { "Production", "Water" };
        }

        private void materialButtonProductionAnalysis_Click(object sender, EventArgs e)
        {
            CreateAnalysisRequestFormUserControl.analysisType = "Production";
            Close();
        }

        private void materialButtonWaterAnalysis_Click(object sender, EventArgs e)
        {
            CreateAnalysisRequestFormUserControl.analysisType = "Water";
            Close();
        }

        private void materialButtonContinue_Click(object sender, EventArgs e)
        {
            CreateAnalysisRequestFormUserControl.analysisItemList.Clear();
            CreateAnalysisRequestFormUserControl.analysisType =
                materialComboBoxAnalysisType.SelectedItem.ToString();

            Close();
        }
    }
}
