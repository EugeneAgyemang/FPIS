using FPIS.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class AnalysisCalculatorForm : MaterialForm
    {
        string Concentration = "Concentration of Sodium Hydroxide";
        string Normality = "Normality of Sodium Thiosulfate";

        public bool _isDataValid = true;
        float valueOfConcentrationOfNaOH;
        float valueOfNormalityOfNaSO;
        public AnalysisCalculatorForm()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            LoadVariables();

            labelFFATitreValueError.ForeColor = System.Drawing.Color.Red;
            labelFFAMassOfSampleTakenError.ForeColor = System.Drawing.Color.Red;
            labelAcetoneContentMassOfEvaporatedSampleError.ForeColor = System.Drawing.Color.Red;
            labelAcetoneContentMassOfGlasswareUsedError.ForeColor = System.Drawing.Color.Red;
            labelAcetoneContentMassOfUnevaporatedSampleError.ForeColor = System.Drawing.Color.Red;
            labelIVBlankValueError.ForeColor = System.Drawing.Color.Red;
            labelIVMassOfTestSampleError.ForeColor = System.Drawing.Color.Red;
            labelIVTitreValueError.ForeColor = System.Drawing.Color.Red;
            labelMassofDriedSampleError.ForeColor = System.Drawing.Color.Red;
            labelMassOfUndriedSampleError.ForeColor = System.Drawing.Color.Red;
            labelMassOfEmptyPanError.ForeColor = System.Drawing.Color.Red;
            labelFatContentMassOfExtractedOilError.ForeColor = System.Drawing.Color.Red;
            labelFatContentMassOfGlasswareUsedError.ForeColor = System.Drawing.Color.Red;
            labelFatContentMassOfTestSampleError.ForeColor = System.Drawing.Color.Red;
            labelPVVolumeOfTitrantOfSampleError.ForeColor = System.Drawing.Color.Red;
            labelPVVolumeOFTitrantOFBlankError.ForeColor = System.Drawing.Color.Red;
            labelPVMassOfTestSampleError.ForeColor = System.Drawing.Color.Red;

            labelFFATitreValueError.Text = "";
            labelFFAMassOfSampleTakenError.Text = "";
            labelAcetoneContentMassOfEvaporatedSampleError.Text = "";
            labelAcetoneContentMassOfGlasswareUsedError.Text = "";
            labelAcetoneContentMassOfUnevaporatedSampleError.Text = "";
            labelIVBlankValueError.Text = "";
            labelIVMassOfTestSampleError.Text = "";
            labelIVTitreValueError.Text = "";
            labelMassofDriedSampleError.Text = "";
            labelMassOfUndriedSampleError.Text = "";
            labelMassOfEmptyPanError.Text = "";
            labelFatContentMassOfExtractedOilError.Text = "";
            labelFatContentMassOfGlasswareUsedError.Text = "";
            labelFatContentMassOfTestSampleError.Text = "";
            labelPVVolumeOfTitrantOfSampleError.Text = "";
            labelPVVolumeOFTitrantOFBlankError.Text = "";
            labelPVMassOfTestSampleError.Text = "";
        }

        public void ClearFFAErrorLabels()
        {
            labelFFATitreValueError.Text = "";
            labelFFAMassOfSampleTakenError.Text = "";
        }

        public void ClearFFAFormFields()
        {
            materialTextBoxTitreValueForFFA.Text = "";
            materialTextBoxMassOfSampleTaken.Text = "";
            textBoxFFAResult.Text = "";
        }

        public void ClearAcetoneContentErrorLabels()
        {
            labelAcetoneContentMassOfEvaporatedSampleError.Text = "";
            labelAcetoneContentMassOfGlasswareUsedError.Text = "";
            labelAcetoneContentMassOfUnevaporatedSampleError.Text = "";
        }

        public void ClearAcetoneContentFormFields()
        {
            materialTextBoxMassOfEvaporatedSample.Text = "";
            materialTextBoxMassOfUnevaporatedSample.Text = "";
            materialTextBoxMassOfGlasswareUsed.Text = "";
            textBoxAcetoneContentResult.Text = "";
        }

        public void ClearIVErrorLabels()
        {
            labelIVBlankValueError.Text = "";
            labelIVMassOfTestSampleError.Text = "";
            labelIVTitreValueError.Text = "";
        }

        public void ClearIVFormFields()
        {
            materialTextBoxBlankValue.Text = "";
            materialTextBoxTitreValueForIV.Text = "";
            materialTextBoxMassOfTestSampleIV.Text = "";
            textBoxIodineValueResult.Text = "";
        }

        public void ClearMoistureContentErrorLabels()
        {
            labelMassofDriedSampleError.Text = "";
            labelMassOfUndriedSampleError.Text = "";
            labelMassOfEmptyPanError.Text = "";
        }

        public void ClearMoistureContentFormFields()
        {
            materialTextBoxMassOfDriedSample.Text = "";
            materialTextBoxMassOfUndriedSample.Text = "";
            materialTextBoxMassOfEmptyPan.Text = "";
            textBoxMoistureContentResult.Text = "";
        }

        public void ClearFatContentErrorLabels()
        {
            labelFatContentMassOfExtractedOilError.Text = "";
            labelFatContentMassOfGlasswareUsedError.Text = "";
            labelFatContentMassOfTestSampleError.Text = "";
        }

        public void ClearFatContentFormFields()
        {
            materialTextBoxMassOfExtractedOil.Text = "";
            materialTextBoxMassOfGlasswareFatContent.Text = "";
            materialTextBoxMassOfTestSampleFatContent.Text = "";
            textBoxFatContentResult.Text = "";
        }

        public void ClearPVErrorLabels()
        {
            labelPVVolumeOfTitrantOfSampleError.Text = "";
            labelPVVolumeOFTitrantOFBlankError.Text = "";
            labelPVMassOfTestSampleError.Text = "";
        }

        public void ClearPVFormFields()
        {
            materialTextBoxVolumeOfTitrantSample.Text = "";
            materialTextBoxVolumeOfTitrantOfBlank.Text = "";
            materialTextBoxMassOfTestSamplePV.Text = "";
            textBoxPeroxideValueResult.Text = "";
        }

        public void ValidatePV_VolumeOfTitrantOfSample(string volumeOfTitrantOfSample)
        {
            if (volumeOfTitrantOfSample.Length == 0)
            {
                labelPVVolumeOfTitrantOfSampleError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidatePV_VolumeOfTitrantOfBlank(string volumeOfTitrantOfBlank)
        {
            if (volumeOfTitrantOfBlank.Length == 0)
            {
                labelPVVolumeOFTitrantOFBlankError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidatePV_MassofTestSample(string massOfTestSample)
        {
            if (massOfTestSample.Length == 0)
            {
                labelPVMassOfTestSampleError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateFatContent_MassOfExtractedOil(string massOfEtractedOil)
        {
            if (massOfEtractedOil.Length == 0)
            {
                labelFatContentMassOfExtractedOilError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateFatContent_MassOfGlasswareUsed(string massOfGlasswareUsed)
        {
            if (massOfGlasswareUsed.Length == 0)
            {
                labelFatContentMassOfGlasswareUsedError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateFatContent_MassOfTestSample(string massOfTestSample)
        {
            if (massOfTestSample.Length == 0)
            {
                labelFatContentMassOfTestSampleError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateMoistureContent_MassOfDriedSample(string massOfDriedSample)
        {
            if (massOfDriedSample.Length == 0)
            {
                labelMassofDriedSampleError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateMoistureContent_MassOfUndriedSample(string massOfUndriedSample)
        {
            if (massOfUndriedSample.Length == 0)
            {
                labelMassOfUndriedSampleError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateMoistureContent_MassOfEmptyPan(string massOfEmptyPan)
        {
            if (massOfEmptyPan.Length == 0)
            {
                labelMassOfEmptyPanError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateIVBlankValue(string blankValue)
        {
            if (blankValue.Length == 0)
            {
                labelIVBlankValueError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateIVTitreValue(string titreValue)
        {
            if (titreValue.Length == 0)
            {
                labelIVTitreValueError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateIVMassOfTestSample(string massOfTestSample)
        {
            if (massOfTestSample.Length == 0)
            {
                labelIVMassOfTestSampleError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateAcetoneContent_MassOfEvaporatedSample(string evaporatedSample)
        {
            if (evaporatedSample.Length == 0)
            {
                labelAcetoneContentMassOfEvaporatedSampleError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateAcetoneContent_MassOfUnevaporatedSample(string unevaporatedSample)
        {
            if (unevaporatedSample.Length == 0)
            {
                labelAcetoneContentMassOfUnevaporatedSampleError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateAcetoneContent_MassOfGlasswareUsed(string massOfGlasswareUsed)
        {
            if (massOfGlasswareUsed.Length == 0)
            {
                labelAcetoneContentMassOfGlasswareUsedError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateFFATitreValue(string titreValue)
        {
            if (titreValue.Length == 0)
            {
                labelFFATitreValueError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }
        public void ValidateFFAMassOfSampleTaken(string massTaken)
        {
            if (massTaken.Length == 0)
            {
                labelFFAMassOfSampleTakenError.Text = "Required!";
                _isDataValid = false;
                return;
            }

        }


        public void LoadVariables()
        {
            try
            {
                AppDbContext dbContext = new();
                var concentrationOfNaOH = dbContext.CalculatorVariables.Where(cv => cv.VariableName == Concentration).Single();
                var normalityOfNaSO = dbContext.CalculatorVariables.Where(cv => cv.VariableName == Normality).Single();
                labelConcentrationOfNaOH.Text = concentrationOfNaOH.Value.ToString();
                labelNormalityOfNaSO.Text = normalityOfNaSO.Value.ToString();
                valueOfConcentrationOfNaOH = float.Parse(concentrationOfNaOH.Value.ToString());
                valueOfNormalityOfNaSO = float.Parse(normalityOfNaSO.Value.ToString());
                dbContext.Dispose();
            }
            catch (Exception ex)
            {

            }
            if (labelConcentrationOfNaOH.Text == "" && labelNormalityOfNaSO.Text == "")
            {
                labelConcentrationOfNaOH.Text = 0.ToString();
                labelNormalityOfNaSO.Text = 0.ToString();
            }

        }

        private void materialButtonGenerateCertificateOfAnalysis_Click(object sender, EventArgs e)
        {
            SetVariables sb = new SetVariables();
            sb.ShowDialog();
            LoadVariables();
        }

        private void materialButtonCalculateFFA_Click(object sender, EventArgs e)
        {
            string titreValue = materialTextBoxTitreValueForFFA.Text.Trim();
            string massOfSample = materialTextBoxMassOfSampleTaken.Text.Trim();
            ClearFFAErrorLabels();

            ValidateFFATitreValue(titreValue);
            ValidateFFAMassOfSampleTaken(massOfSample);

            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            double FFAResult = (float.Parse(titreValue) * valueOfConcentrationOfNaOH * 28.2) / float.Parse(massOfSample);
            textBoxFFAResult.Text = Math.Round(FFAResult, 2).ToString();
        }

        private void materialTextBoxTitreValueForFFA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfSampleTaken_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfEvaporatedSample_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfUnevaporatedSample_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfGlasswareUsed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxBlankValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxTitreValueForIV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfTestSampleIV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfDriedSample_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfUndriedSample_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfEmptyPan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfExtractedOil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfGlasswareFatContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfTestSampleFatContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxVolumeOfTitrantSample_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxVolumeOfTitrantOfBlank_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxMassOfTestSamplePV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialButtonClearFFA_Click(object sender, EventArgs e)
        {
            ClearFFAFormFields();
        }

        private void materialButtonCalculateAcetoneContent_Click(object sender, EventArgs e)
        {
            string massOfEvaporatedSample = materialTextBoxMassOfEvaporatedSample.Text.Trim();
            string massOfUnevaporatedSample = materialTextBoxMassOfUnevaporatedSample.Text.Trim();
            string massOfglasswareUsed = materialTextBoxMassOfGlasswareUsed.Text.Trim();
            ClearAcetoneContentErrorLabels();

            ValidateAcetoneContent_MassOfEvaporatedSample(massOfEvaporatedSample);
            ValidateAcetoneContent_MassOfUnevaporatedSample(massOfUnevaporatedSample);
            ValidateAcetoneContent_MassOfGlasswareUsed(massOfglasswareUsed);

            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            double AcetoneContentResult = ((float.Parse(massOfEvaporatedSample) - float.Parse(massOfUnevaporatedSample)) /
                (float.Parse(massOfUnevaporatedSample) - float.Parse(massOfglasswareUsed))) * 100;
            textBoxAcetoneContentResult.Text = Math.Round(AcetoneContentResult, 2).ToString() + "%";
        }

        private void materialButtonClearAcetoneContent_Click(object sender, EventArgs e)
        {
            ClearAcetoneContentFormFields();
        }

        private void materialButtonCalculateIV_Click(object sender, EventArgs e)
        {
            string blankValue = materialTextBoxBlankValue.Text.Trim();
            string titreValueIV = materialTextBoxTitreValueForIV.Text.Trim();
            string massOfTestSample = materialTextBoxMassOfTestSampleIV.Text.Trim();
            ClearIVErrorLabels();

            ValidateIVBlankValue(blankValue);
            ValidateIVTitreValue(titreValueIV);
            ValidateIVMassOfTestSample(massOfTestSample);

            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            double iodineValue = ((float.Parse(blankValue) - float.Parse(titreValueIV)) * valueOfNormalityOfNaSO * 12.69) / float.Parse(massOfTestSample);
            textBoxIodineValueResult.Text = Math.Round(iodineValue, 2).ToString();
        }

        private void materialButtonClearIV_Click(object sender, EventArgs e)
        {
            ClearIVFormFields();
        }

        private void materialButtonCalculateMoistureContent_Click(object sender, EventArgs e)
        {
            string massOfDriedSample = materialTextBoxMassOfDriedSample.Text.Trim();
            string massOfUndriedSample = materialTextBoxMassOfUndriedSample.Text.Trim();
            string massOfEmptyPan = materialTextBoxMassOfEmptyPan.Text.Trim();

            ClearMoistureContentErrorLabels();

            ValidateMoistureContent_MassOfDriedSample(massOfDriedSample);
            ValidateMoistureContent_MassOfUndriedSample(massOfUndriedSample);
            ValidateMoistureContent_MassOfEmptyPan(massOfEmptyPan);

            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            double moistureContent = ((float.Parse(massOfDriedSample) - float.Parse(massOfUndriedSample)) /
                (float.Parse(massOfUndriedSample) - float.Parse(massOfEmptyPan))) * 100;
            textBoxMoistureContentResult.Text = Math.Round(moistureContent, 2).ToString() + "%";
        }

        private void materialButtonClearMoistureContent_Click(object sender, EventArgs e)
        {
            ClearMoistureContentFormFields();
        }

        private void materialButtonCalculateFatContent_Click(object sender, EventArgs e)
        {
            string massOfExtractedOil = materialTextBoxMassOfExtractedOil.Text.Trim();
            string massOfGlasswareUsed = materialTextBoxMassOfGlasswareFatContent.Text.Trim();
            string massOfTestSample = materialTextBoxMassOfTestSampleFatContent.Text.Trim();

            ClearFatContentErrorLabels();

            ValidateFatContent_MassOfExtractedOil(massOfExtractedOil);
            ValidateFatContent_MassOfGlasswareUsed(massOfGlasswareUsed);
            ValidateFatContent_MassOfTestSample(massOfTestSample);

            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            double fatContent = ((float.Parse(massOfExtractedOil) - float.Parse(massOfGlasswareUsed)) /
                float.Parse(massOfTestSample)) * 100;
            textBoxFatContentResult.Text = Math.Round(fatContent, 2).ToString() + "%";
        }

        private void materialButtonClearFatContent_Click(object sender, EventArgs e)
        {
            ClearFatContentFormFields();
        }

        private void materialButtonCalculatePV_Click(object sender, EventArgs e)
        {
            string volumeOfTitrantOfSample = materialTextBoxVolumeOfTitrantSample.Text.Trim();
            string volumeOfTitrantOfBlank = materialTextBoxVolumeOfTitrantOfBlank.Text.Trim();
            string massOfTestSample = materialTextBoxMassOfTestSamplePV.Text.Trim();

            ClearPVErrorLabels();

            ValidatePV_VolumeOfTitrantOfSample(volumeOfTitrantOfSample);
            ValidatePV_VolumeOfTitrantOfBlank(volumeOfTitrantOfBlank);
            ValidatePV_MassofTestSample(massOfTestSample);

            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            double peroxideValue = ((float.Parse(volumeOfTitrantOfSample) - float.Parse(volumeOfTitrantOfBlank)) * valueOfNormalityOfNaSO * 1000) / float.Parse(massOfTestSample);
            textBoxPeroxideValueResult.Text = Math.Round(peroxideValue, 2).ToString();
        }

        private void materialButtonClearPeroxideValue_Click(object sender, EventArgs e)
        {
            ClearPVFormFields();
        }
    }
}
