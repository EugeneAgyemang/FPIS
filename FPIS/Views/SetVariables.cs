using FPIS.Models;
using FPIS.Services;
using FPISReports.ReportViews;
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
    public partial class SetVariables : MaterialForm
    {
        public bool _isDataValid = true;
        string Concentration = "Concentration of Sodium Hydroxide";
        string Normality = "Normality of Sodium Thiosulfate";
        string _ValueOfConcentrationOfNaOH = "";
        string _ValueOfNormalityOfNaOS = "";
        public SetVariables()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
            labelNaOHError.ForeColor = System.Drawing.Color.Red;
            labelNaSOError.ForeColor = System.Drawing.Color.Red;

            labelNaOHError.Text = "";
            labelNaSOError.Text = "";
            LoadVariables();
        }

        private void materialTextBoxConcentrationOFNaOH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void materialTextBoxNormalityOfNaSO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        public void ClearFormFields()
        {
            materialTextBoxConcentrationOFNaOH.Text = "";
            materialTextBoxNormalityOfNaSO.Text = "";
        }

        public void ClearErrorLabels()
        {
            labelNaOHError.Text = "";
            labelNaSOError.Text = "";

        }

        public void ValidateConcentrationOFNaOH(string stockItemName)
        {
            if (stockItemName.Length == 0)
            {

                labelNaOHError.Text = "Concentration is required";
                _isDataValid = false;
                return;
            }
        }

        public void ValidateNormalityOfNaSO(string quantity)
        {
            if (quantity.Length == 0)
            {
                _isDataValid = false;
                labelNaSOError.Text = "Normality is required!";
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
                materialTextBoxConcentrationOFNaOH.Text = concentrationOfNaOH.Value.ToString();
                materialTextBoxNormalityOfNaSO.Text = normalityOfNaSO.Value.ToString();
                _ValueOfConcentrationOfNaOH = concentrationOfNaOH.VariableName;
                _ValueOfNormalityOfNaOS = normalityOfNaSO.VariableName;
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                
            }

        }

        public void SetNewVariables()
        {
            string value_ConcentrationOfNaOH = materialTextBoxConcentrationOFNaOH.Text;
            string value_NormalityOfNaSO = materialTextBoxNormalityOfNaSO.Text;
            ClearErrorLabels();
            ValidateConcentrationOFNaOH(value_ConcentrationOfNaOH);
            ValidateNormalityOfNaSO(value_NormalityOfNaSO);
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            AppDbContext dbContext = new();
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                $"Do you want to set a new Variable?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    if (_ValueOfConcentrationOfNaOH == "" && _ValueOfNormalityOfNaOS == "")
                    {
                        SetVariableService _setVariableService = new(dbContext);
                        _setVariableService.SetNewVariable(Concentration,float.Parse(materialTextBoxConcentrationOFNaOH.Text));
                        _setVariableService.SetNewVariable(Normality, float.Parse(materialTextBoxNormalityOfNaSO.Text));
                         
                    }
                    else
                    {
                        var setVariablesforConcentration = dbContext.CalculatorVariables.Where(cv => cv.VariableName == Concentration).Single();
                        setVariablesforConcentration.Value = float.Parse(materialTextBoxConcentrationOFNaOH.Text);
                        var setVariablesforNormality = dbContext.CalculatorVariables.Where(cv => cv.VariableName == Normality).Single();
                        setVariablesforNormality.Value = float.Parse(materialTextBoxNormalityOfNaSO.Text);
                       
                    }
                    dbContext.SaveChanges();
                    MessageBox.Show(
                            $"Variable Set Successfuly",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to set new variables. Please Try again." + ex,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                dbContext.Dispose();
            }
        }

        private void materialButtonSetVariable_Click(object sender, EventArgs e)
        {
            SetNewVariables();

            this.Close();
            
            
        }
    }
}
