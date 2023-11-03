namespace FPIS.Views
{
    partial class AnalysisCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalysisCalculatorForm));
            materialButtonSetVariables = new MaterialSkin.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            labelFFAMassOfSampleTakenError = new Label();
            labelFFATitreValueError = new Label();
            materialButtonClearFFA = new MaterialSkin.Controls.MaterialButton();
            materialButtonCalculateFFA = new MaterialSkin.Controls.MaterialButton();
            textBoxFFAResult = new TextBox();
            materialTextBoxMassOfSampleTaken = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxTitreValueForFFA = new MaterialSkin.Controls.MaterialTextBox();
            groupBox2 = new GroupBox();
            labelAcetoneContentMassOfGlasswareUsedError = new Label();
            labelAcetoneContentMassOfUnevaporatedSampleError = new Label();
            labelAcetoneContentMassOfEvaporatedSampleError = new Label();
            materialButtonClearAcetoneContent = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxMassOfGlasswareUsed = new MaterialSkin.Controls.MaterialTextBox();
            materialButtonCalculateAcetoneContent = new MaterialSkin.Controls.MaterialButton();
            textBoxAcetoneContentResult = new TextBox();
            materialTextBoxMassOfUnevaporatedSample = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxMassOfEvaporatedSample = new MaterialSkin.Controls.MaterialTextBox();
            groupBox3 = new GroupBox();
            labelIVMassOfTestSampleError = new Label();
            labelIVTitreValueError = new Label();
            labelIVBlankValueError = new Label();
            materialButtonClearIV = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxMassOfTestSampleIV = new MaterialSkin.Controls.MaterialTextBox();
            materialButtonCalculateIV = new MaterialSkin.Controls.MaterialButton();
            textBoxIodineValueResult = new TextBox();
            materialTextBoxTitreValueForIV = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxBlankValue = new MaterialSkin.Controls.MaterialTextBox();
            groupBox4 = new GroupBox();
            labelMassOfEmptyPanError = new Label();
            labelMassOfUndriedSampleError = new Label();
            labelMassofDriedSampleError = new Label();
            materialButtonClearMoistureContent = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxMassOfEmptyPan = new MaterialSkin.Controls.MaterialTextBox();
            materialButtonCalculateMoistureContent = new MaterialSkin.Controls.MaterialButton();
            textBoxMoistureContentResult = new TextBox();
            materialTextBoxMassOfUndriedSample = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxMassOfDriedSample = new MaterialSkin.Controls.MaterialTextBox();
            groupBox5 = new GroupBox();
            labelFatContentMassOfTestSampleError = new Label();
            labelFatContentMassOfGlasswareUsedError = new Label();
            labelFatContentMassOfExtractedOilError = new Label();
            materialButtonClearFatContent = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxMassOfTestSampleFatContent = new MaterialSkin.Controls.MaterialTextBox();
            materialButtonCalculateFatContent = new MaterialSkin.Controls.MaterialButton();
            textBoxFatContentResult = new TextBox();
            materialTextBoxMassOfGlasswareFatContent = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxMassOfExtractedOil = new MaterialSkin.Controls.MaterialTextBox();
            groupBox6 = new GroupBox();
            labelPVMassOfTestSampleError = new Label();
            labelPVVolumeOFTitrantOFBlankError = new Label();
            labelPVVolumeOfTitrantOfSampleError = new Label();
            materialButtonClearPeroxideValue = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxMassOfTestSamplePV = new MaterialSkin.Controls.MaterialTextBox();
            materialButtonCalculatePV = new MaterialSkin.Controls.MaterialButton();
            textBoxPeroxideValueResult = new TextBox();
            materialTextBoxVolumeOfTitrantOfBlank = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxVolumeOfTitrantSample = new MaterialSkin.Controls.MaterialTextBox();
            labelConcentrationOfNaOH = new Label();
            label5 = new Label();
            label7 = new Label();
            labelNormalityOfNaSO = new Label();
            groupBox7 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // materialButtonSetVariables
            // 
            materialButtonSetVariables.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSetVariables.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonSetVariables.Cursor = Cursors.Hand;
            materialButtonSetVariables.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSetVariables.Depth = 0;
            materialButtonSetVariables.HighEmphasis = true;
            materialButtonSetVariables.Icon = null;
            materialButtonSetVariables.Location = new Point(438, 36);
            materialButtonSetVariables.Margin = new Padding(5);
            materialButtonSetVariables.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSetVariables.Name = "materialButtonSetVariables";
            materialButtonSetVariables.NoAccentTextColor = Color.Empty;
            materialButtonSetVariables.Size = new Size(128, 36);
            materialButtonSetVariables.TabIndex = 30;
            materialButtonSetVariables.Text = "Set Variables";
            materialButtonSetVariables.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSetVariables.UseAccentColor = true;
            materialButtonSetVariables.UseVisualStyleBackColor = true;
            materialButtonSetVariables.Click += materialButtonGenerateCertificateOfAnalysis_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(labelFFAMassOfSampleTakenError);
            groupBox1.Controls.Add(labelFFATitreValueError);
            groupBox1.Controls.Add(materialButtonClearFFA);
            groupBox1.Controls.Add(materialButtonCalculateFFA);
            groupBox1.Controls.Add(textBoxFFAResult);
            groupBox1.Controls.Add(materialTextBoxMassOfSampleTaken);
            groupBox1.Controls.Add(materialTextBoxTitreValueForFFA);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(79, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 453);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Free Fatty Acids (FFA)";
            // 
            // labelFFAMassOfSampleTakenError
            // 
            labelFFAMassOfSampleTakenError.AutoSize = true;
            labelFFAMassOfSampleTakenError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFFAMassOfSampleTakenError.Location = new Point(54, 185);
            labelFFAMassOfSampleTakenError.Name = "labelFFAMassOfSampleTakenError";
            labelFFAMassOfSampleTakenError.Size = new Size(73, 20);
            labelFFAMassOfSampleTakenError.TabIndex = 35;
            labelFFAMassOfSampleTakenError.Text = "Required!";
            // 
            // labelFFATitreValueError
            // 
            labelFFATitreValueError.AutoSize = true;
            labelFFATitreValueError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFFATitreValueError.Location = new Point(54, 279);
            labelFFATitreValueError.Name = "labelFFATitreValueError";
            labelFFATitreValueError.Size = new Size(73, 20);
            labelFFATitreValueError.TabIndex = 34;
            labelFFATitreValueError.Text = "Required!";
            // 
            // materialButtonClearFFA
            // 
            materialButtonClearFFA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonClearFFA.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonClearFFA.Cursor = Cursors.Hand;
            materialButtonClearFFA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonClearFFA.Depth = 0;
            materialButtonClearFFA.HighEmphasis = true;
            materialButtonClearFFA.Icon = null;
            materialButtonClearFFA.Location = new Point(193, 395);
            materialButtonClearFFA.Margin = new Padding(5);
            materialButtonClearFFA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonClearFFA.Name = "materialButtonClearFFA";
            materialButtonClearFFA.NoAccentTextColor = Color.Empty;
            materialButtonClearFFA.Size = new Size(66, 36);
            materialButtonClearFFA.TabIndex = 33;
            materialButtonClearFFA.Text = "Clear";
            materialButtonClearFFA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonClearFFA.UseAccentColor = true;
            materialButtonClearFFA.UseVisualStyleBackColor = true;
            materialButtonClearFFA.Click += materialButtonClearFFA_Click;
            // 
            // materialButtonCalculateFFA
            // 
            materialButtonCalculateFFA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonCalculateFFA.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonCalculateFFA.Cursor = Cursors.Hand;
            materialButtonCalculateFFA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonCalculateFFA.Depth = 0;
            materialButtonCalculateFFA.HighEmphasis = true;
            materialButtonCalculateFFA.Icon = null;
            materialButtonCalculateFFA.Location = new Point(66, 395);
            materialButtonCalculateFFA.Margin = new Padding(5);
            materialButtonCalculateFFA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonCalculateFFA.Name = "materialButtonCalculateFFA";
            materialButtonCalculateFFA.NoAccentTextColor = Color.Empty;
            materialButtonCalculateFFA.Size = new Size(103, 36);
            materialButtonCalculateFFA.TabIndex = 32;
            materialButtonCalculateFFA.Text = "Calculate";
            materialButtonCalculateFFA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonCalculateFFA.UseAccentColor = true;
            materialButtonCalculateFFA.UseVisualStyleBackColor = true;
            materialButtonCalculateFFA.Click += materialButtonCalculateFFA_Click;
            // 
            // textBoxFFAResult
            // 
            textBoxFFAResult.BackColor = SystemColors.Window;
            textBoxFFAResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxFFAResult.Enabled = false;
            textBoxFFAResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxFFAResult.ForeColor = Color.Green;
            textBoxFFAResult.Location = new Point(55, 47);
            textBoxFFAResult.Name = "textBoxFFAResult";
            textBoxFFAResult.Size = new Size(236, 47);
            textBoxFFAResult.TabIndex = 2;
            textBoxFFAResult.TextAlign = HorizontalAlignment.Center;
            // 
            // materialTextBoxMassOfSampleTaken
            // 
            materialTextBoxMassOfSampleTaken.AnimateReadOnly = false;
            materialTextBoxMassOfSampleTaken.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfSampleTaken.Depth = 0;
            materialTextBoxMassOfSampleTaken.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfSampleTaken.Hint = "Mass of Sample Taken";
            materialTextBoxMassOfSampleTaken.LeadingIcon = null;
            materialTextBoxMassOfSampleTaken.Location = new Point(54, 129);
            materialTextBoxMassOfSampleTaken.MaxLength = 50;
            materialTextBoxMassOfSampleTaken.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfSampleTaken.Multiline = false;
            materialTextBoxMassOfSampleTaken.Name = "materialTextBoxMassOfSampleTaken";
            materialTextBoxMassOfSampleTaken.Size = new Size(238, 50);
            materialTextBoxMassOfSampleTaken.TabIndex = 1;
            materialTextBoxMassOfSampleTaken.Text = "";
            materialTextBoxMassOfSampleTaken.TrailingIcon = null;
            materialTextBoxMassOfSampleTaken.KeyPress += materialTextBoxMassOfSampleTaken_KeyPress;
            // 
            // materialTextBoxTitreValueForFFA
            // 
            materialTextBoxTitreValueForFFA.AnimateReadOnly = false;
            materialTextBoxTitreValueForFFA.BorderStyle = BorderStyle.None;
            materialTextBoxTitreValueForFFA.Depth = 0;
            materialTextBoxTitreValueForFFA.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxTitreValueForFFA.Hint = "Titre Value";
            materialTextBoxTitreValueForFFA.LeadingIcon = null;
            materialTextBoxTitreValueForFFA.Location = new Point(54, 225);
            materialTextBoxTitreValueForFFA.MaxLength = 50;
            materialTextBoxTitreValueForFFA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxTitreValueForFFA.Multiline = false;
            materialTextBoxTitreValueForFFA.Name = "materialTextBoxTitreValueForFFA";
            materialTextBoxTitreValueForFFA.Size = new Size(238, 50);
            materialTextBoxTitreValueForFFA.TabIndex = 0;
            materialTextBoxTitreValueForFFA.Text = "";
            materialTextBoxTitreValueForFFA.TrailingIcon = null;
            materialTextBoxTitreValueForFFA.KeyPress += materialTextBoxTitreValueForFFA_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(labelAcetoneContentMassOfGlasswareUsedError);
            groupBox2.Controls.Add(labelAcetoneContentMassOfUnevaporatedSampleError);
            groupBox2.Controls.Add(labelAcetoneContentMassOfEvaporatedSampleError);
            groupBox2.Controls.Add(materialButtonClearAcetoneContent);
            groupBox2.Controls.Add(materialTextBoxMassOfGlasswareUsed);
            groupBox2.Controls.Add(materialButtonCalculateAcetoneContent);
            groupBox2.Controls.Add(textBoxAcetoneContentResult);
            groupBox2.Controls.Add(materialTextBoxMassOfUnevaporatedSample);
            groupBox2.Controls.Add(materialTextBoxMassOfEvaporatedSample);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(471, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 453);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Percentage of Acetone Content";
            // 
            // labelAcetoneContentMassOfGlasswareUsedError
            // 
            labelAcetoneContentMassOfGlasswareUsedError.AutoSize = true;
            labelAcetoneContentMassOfGlasswareUsedError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelAcetoneContentMassOfGlasswareUsedError.Location = new Point(42, 174);
            labelAcetoneContentMassOfGlasswareUsedError.Name = "labelAcetoneContentMassOfGlasswareUsedError";
            labelAcetoneContentMassOfGlasswareUsedError.Size = new Size(73, 20);
            labelAcetoneContentMassOfGlasswareUsedError.TabIndex = 39;
            labelAcetoneContentMassOfGlasswareUsedError.Text = "Required!";
            // 
            // labelAcetoneContentMassOfUnevaporatedSampleError
            // 
            labelAcetoneContentMassOfUnevaporatedSampleError.AutoSize = true;
            labelAcetoneContentMassOfUnevaporatedSampleError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelAcetoneContentMassOfUnevaporatedSampleError.Location = new Point(42, 267);
            labelAcetoneContentMassOfUnevaporatedSampleError.Name = "labelAcetoneContentMassOfUnevaporatedSampleError";
            labelAcetoneContentMassOfUnevaporatedSampleError.Size = new Size(73, 20);
            labelAcetoneContentMassOfUnevaporatedSampleError.TabIndex = 38;
            labelAcetoneContentMassOfUnevaporatedSampleError.Text = "Required!";
            // 
            // labelAcetoneContentMassOfEvaporatedSampleError
            // 
            labelAcetoneContentMassOfEvaporatedSampleError.AutoSize = true;
            labelAcetoneContentMassOfEvaporatedSampleError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelAcetoneContentMassOfEvaporatedSampleError.Location = new Point(42, 366);
            labelAcetoneContentMassOfEvaporatedSampleError.Name = "labelAcetoneContentMassOfEvaporatedSampleError";
            labelAcetoneContentMassOfEvaporatedSampleError.Size = new Size(73, 20);
            labelAcetoneContentMassOfEvaporatedSampleError.TabIndex = 37;
            labelAcetoneContentMassOfEvaporatedSampleError.Text = "Required!";
            // 
            // materialButtonClearAcetoneContent
            // 
            materialButtonClearAcetoneContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonClearAcetoneContent.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonClearAcetoneContent.Cursor = Cursors.Hand;
            materialButtonClearAcetoneContent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonClearAcetoneContent.Depth = 0;
            materialButtonClearAcetoneContent.HighEmphasis = true;
            materialButtonClearAcetoneContent.Icon = null;
            materialButtonClearAcetoneContent.Location = new Point(193, 395);
            materialButtonClearAcetoneContent.Margin = new Padding(5);
            materialButtonClearAcetoneContent.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonClearAcetoneContent.Name = "materialButtonClearAcetoneContent";
            materialButtonClearAcetoneContent.NoAccentTextColor = Color.Empty;
            materialButtonClearAcetoneContent.Size = new Size(66, 36);
            materialButtonClearAcetoneContent.TabIndex = 36;
            materialButtonClearAcetoneContent.Text = "Clear";
            materialButtonClearAcetoneContent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonClearAcetoneContent.UseAccentColor = true;
            materialButtonClearAcetoneContent.UseVisualStyleBackColor = true;
            materialButtonClearAcetoneContent.Click += materialButtonClearAcetoneContent_Click;
            // 
            // materialTextBoxMassOfGlasswareUsed
            // 
            materialTextBoxMassOfGlasswareUsed.AnimateReadOnly = false;
            materialTextBoxMassOfGlasswareUsed.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfGlasswareUsed.Depth = 0;
            materialTextBoxMassOfGlasswareUsed.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfGlasswareUsed.Hint = "Mass of Glassware Used";
            materialTextBoxMassOfGlasswareUsed.LeadingIcon = null;
            materialTextBoxMassOfGlasswareUsed.Location = new Point(42, 112);
            materialTextBoxMassOfGlasswareUsed.MaxLength = 50;
            materialTextBoxMassOfGlasswareUsed.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfGlasswareUsed.Multiline = false;
            materialTextBoxMassOfGlasswareUsed.Name = "materialTextBoxMassOfGlasswareUsed";
            materialTextBoxMassOfGlasswareUsed.Size = new Size(247, 50);
            materialTextBoxMassOfGlasswareUsed.TabIndex = 33;
            materialTextBoxMassOfGlasswareUsed.Text = "";
            materialTextBoxMassOfGlasswareUsed.TrailingIcon = null;
            materialTextBoxMassOfGlasswareUsed.KeyPress += materialTextBoxMassOfGlasswareUsed_KeyPress;
            // 
            // materialButtonCalculateAcetoneContent
            // 
            materialButtonCalculateAcetoneContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonCalculateAcetoneContent.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonCalculateAcetoneContent.Cursor = Cursors.Hand;
            materialButtonCalculateAcetoneContent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonCalculateAcetoneContent.Depth = 0;
            materialButtonCalculateAcetoneContent.HighEmphasis = true;
            materialButtonCalculateAcetoneContent.Icon = null;
            materialButtonCalculateAcetoneContent.Location = new Point(66, 395);
            materialButtonCalculateAcetoneContent.Margin = new Padding(5);
            materialButtonCalculateAcetoneContent.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonCalculateAcetoneContent.Name = "materialButtonCalculateAcetoneContent";
            materialButtonCalculateAcetoneContent.NoAccentTextColor = Color.Empty;
            materialButtonCalculateAcetoneContent.Size = new Size(103, 36);
            materialButtonCalculateAcetoneContent.TabIndex = 32;
            materialButtonCalculateAcetoneContent.Text = "Calculate";
            materialButtonCalculateAcetoneContent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonCalculateAcetoneContent.UseAccentColor = true;
            materialButtonCalculateAcetoneContent.UseVisualStyleBackColor = true;
            materialButtonCalculateAcetoneContent.Click += materialButtonCalculateAcetoneContent_Click;
            // 
            // textBoxAcetoneContentResult
            // 
            textBoxAcetoneContentResult.BackColor = SystemColors.Window;
            textBoxAcetoneContentResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxAcetoneContentResult.Enabled = false;
            textBoxAcetoneContentResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxAcetoneContentResult.ForeColor = SystemColors.WindowText;
            textBoxAcetoneContentResult.Location = new Point(42, 47);
            textBoxAcetoneContentResult.Name = "textBoxAcetoneContentResult";
            textBoxAcetoneContentResult.Size = new Size(250, 47);
            textBoxAcetoneContentResult.TabIndex = 2;
            textBoxAcetoneContentResult.TextAlign = HorizontalAlignment.Center;
            // 
            // materialTextBoxMassOfUnevaporatedSample
            // 
            materialTextBoxMassOfUnevaporatedSample.AnimateReadOnly = false;
            materialTextBoxMassOfUnevaporatedSample.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfUnevaporatedSample.Depth = 0;
            materialTextBoxMassOfUnevaporatedSample.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfUnevaporatedSample.Hint = "Mass of Unevaporated Sample";
            materialTextBoxMassOfUnevaporatedSample.LeadingIcon = null;
            materialTextBoxMassOfUnevaporatedSample.Location = new Point(42, 207);
            materialTextBoxMassOfUnevaporatedSample.MaxLength = 50;
            materialTextBoxMassOfUnevaporatedSample.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfUnevaporatedSample.Multiline = false;
            materialTextBoxMassOfUnevaporatedSample.Name = "materialTextBoxMassOfUnevaporatedSample";
            materialTextBoxMassOfUnevaporatedSample.Size = new Size(250, 50);
            materialTextBoxMassOfUnevaporatedSample.TabIndex = 1;
            materialTextBoxMassOfUnevaporatedSample.Text = "";
            materialTextBoxMassOfUnevaporatedSample.TrailingIcon = null;
            materialTextBoxMassOfUnevaporatedSample.KeyPress += materialTextBoxMassOfUnevaporatedSample_KeyPress;
            // 
            // materialTextBoxMassOfEvaporatedSample
            // 
            materialTextBoxMassOfEvaporatedSample.AnimateReadOnly = false;
            materialTextBoxMassOfEvaporatedSample.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfEvaporatedSample.Depth = 0;
            materialTextBoxMassOfEvaporatedSample.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfEvaporatedSample.Hint = "Mass of Evaporated Sample";
            materialTextBoxMassOfEvaporatedSample.LeadingIcon = null;
            materialTextBoxMassOfEvaporatedSample.Location = new Point(42, 300);
            materialTextBoxMassOfEvaporatedSample.MaxLength = 50;
            materialTextBoxMassOfEvaporatedSample.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfEvaporatedSample.Multiline = false;
            materialTextBoxMassOfEvaporatedSample.Name = "materialTextBoxMassOfEvaporatedSample";
            materialTextBoxMassOfEvaporatedSample.Size = new Size(250, 50);
            materialTextBoxMassOfEvaporatedSample.TabIndex = 0;
            materialTextBoxMassOfEvaporatedSample.Text = "";
            materialTextBoxMassOfEvaporatedSample.TrailingIcon = null;
            materialTextBoxMassOfEvaporatedSample.KeyPress += materialTextBoxMassOfEvaporatedSample_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(labelIVMassOfTestSampleError);
            groupBox3.Controls.Add(labelIVTitreValueError);
            groupBox3.Controls.Add(labelIVBlankValueError);
            groupBox3.Controls.Add(materialButtonClearIV);
            groupBox3.Controls.Add(materialTextBoxMassOfTestSampleIV);
            groupBox3.Controls.Add(materialButtonCalculateIV);
            groupBox3.Controls.Add(textBoxIodineValueResult);
            groupBox3.Controls.Add(materialTextBoxTitreValueForIV);
            groupBox3.Controls.Add(materialTextBoxBlankValue);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(867, 181);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(334, 453);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Iodine Value (IV)";
            // 
            // labelIVMassOfTestSampleError
            // 
            labelIVMassOfTestSampleError.AutoSize = true;
            labelIVMassOfTestSampleError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelIVMassOfTestSampleError.Location = new Point(42, 174);
            labelIVMassOfTestSampleError.Name = "labelIVMassOfTestSampleError";
            labelIVMassOfTestSampleError.Size = new Size(73, 20);
            labelIVMassOfTestSampleError.TabIndex = 43;
            labelIVMassOfTestSampleError.Text = "Required!";
            // 
            // labelIVTitreValueError
            // 
            labelIVTitreValueError.AutoSize = true;
            labelIVTitreValueError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelIVTitreValueError.Location = new Point(45, 369);
            labelIVTitreValueError.Name = "labelIVTitreValueError";
            labelIVTitreValueError.Size = new Size(73, 20);
            labelIVTitreValueError.TabIndex = 42;
            labelIVTitreValueError.Text = "Required!";
            // 
            // labelIVBlankValueError
            // 
            labelIVBlankValueError.AutoSize = true;
            labelIVBlankValueError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelIVBlankValueError.Location = new Point(42, 271);
            labelIVBlankValueError.Name = "labelIVBlankValueError";
            labelIVBlankValueError.Size = new Size(73, 20);
            labelIVBlankValueError.TabIndex = 41;
            labelIVBlankValueError.Text = "Required!";
            // 
            // materialButtonClearIV
            // 
            materialButtonClearIV.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonClearIV.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonClearIV.Cursor = Cursors.Hand;
            materialButtonClearIV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonClearIV.Depth = 0;
            materialButtonClearIV.HighEmphasis = true;
            materialButtonClearIV.Icon = null;
            materialButtonClearIV.Location = new Point(193, 395);
            materialButtonClearIV.Margin = new Padding(5);
            materialButtonClearIV.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonClearIV.Name = "materialButtonClearIV";
            materialButtonClearIV.NoAccentTextColor = Color.Empty;
            materialButtonClearIV.Size = new Size(66, 36);
            materialButtonClearIV.TabIndex = 40;
            materialButtonClearIV.Text = "Clear";
            materialButtonClearIV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonClearIV.UseAccentColor = true;
            materialButtonClearIV.UseVisualStyleBackColor = true;
            materialButtonClearIV.Click += materialButtonClearIV_Click;
            // 
            // materialTextBoxMassOfTestSampleIV
            // 
            materialTextBoxMassOfTestSampleIV.AnimateReadOnly = false;
            materialTextBoxMassOfTestSampleIV.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfTestSampleIV.Depth = 0;
            materialTextBoxMassOfTestSampleIV.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfTestSampleIV.Hint = "Mass of Test Sample";
            materialTextBoxMassOfTestSampleIV.LeadingIcon = null;
            materialTextBoxMassOfTestSampleIV.Location = new Point(42, 108);
            materialTextBoxMassOfTestSampleIV.MaxLength = 50;
            materialTextBoxMassOfTestSampleIV.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfTestSampleIV.Multiline = false;
            materialTextBoxMassOfTestSampleIV.Name = "materialTextBoxMassOfTestSampleIV";
            materialTextBoxMassOfTestSampleIV.Size = new Size(247, 50);
            materialTextBoxMassOfTestSampleIV.TabIndex = 33;
            materialTextBoxMassOfTestSampleIV.Text = "";
            materialTextBoxMassOfTestSampleIV.TrailingIcon = null;
            materialTextBoxMassOfTestSampleIV.KeyPress += materialTextBoxMassOfTestSampleIV_KeyPress;
            // 
            // materialButtonCalculateIV
            // 
            materialButtonCalculateIV.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonCalculateIV.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonCalculateIV.Cursor = Cursors.Hand;
            materialButtonCalculateIV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonCalculateIV.Depth = 0;
            materialButtonCalculateIV.HighEmphasis = true;
            materialButtonCalculateIV.Icon = null;
            materialButtonCalculateIV.Location = new Point(66, 395);
            materialButtonCalculateIV.Margin = new Padding(5);
            materialButtonCalculateIV.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonCalculateIV.Name = "materialButtonCalculateIV";
            materialButtonCalculateIV.NoAccentTextColor = Color.Empty;
            materialButtonCalculateIV.Size = new Size(103, 36);
            materialButtonCalculateIV.TabIndex = 32;
            materialButtonCalculateIV.Text = "Calculate";
            materialButtonCalculateIV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonCalculateIV.UseAccentColor = true;
            materialButtonCalculateIV.UseVisualStyleBackColor = true;
            materialButtonCalculateIV.Click += materialButtonCalculateIV_Click;
            // 
            // textBoxIodineValueResult
            // 
            textBoxIodineValueResult.BackColor = SystemColors.Window;
            textBoxIodineValueResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxIodineValueResult.Enabled = false;
            textBoxIodineValueResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxIodineValueResult.ForeColor = SystemColors.WindowText;
            textBoxIodineValueResult.Location = new Point(42, 47);
            textBoxIodineValueResult.Name = "textBoxIodineValueResult";
            textBoxIodineValueResult.Size = new Size(250, 47);
            textBoxIodineValueResult.TabIndex = 2;
            textBoxIodineValueResult.TextAlign = HorizontalAlignment.Center;
            // 
            // materialTextBoxTitreValueForIV
            // 
            materialTextBoxTitreValueForIV.AnimateReadOnly = false;
            materialTextBoxTitreValueForIV.BorderStyle = BorderStyle.None;
            materialTextBoxTitreValueForIV.Depth = 0;
            materialTextBoxTitreValueForIV.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxTitreValueForIV.Hint = "Titre Value";
            materialTextBoxTitreValueForIV.LeadingIcon = null;
            materialTextBoxTitreValueForIV.Location = new Point(42, 300);
            materialTextBoxTitreValueForIV.MaxLength = 50;
            materialTextBoxTitreValueForIV.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxTitreValueForIV.Multiline = false;
            materialTextBoxTitreValueForIV.Name = "materialTextBoxTitreValueForIV";
            materialTextBoxTitreValueForIV.Size = new Size(250, 50);
            materialTextBoxTitreValueForIV.TabIndex = 1;
            materialTextBoxTitreValueForIV.Text = "";
            materialTextBoxTitreValueForIV.TrailingIcon = null;
            materialTextBoxTitreValueForIV.KeyPress += materialTextBoxTitreValueForIV_KeyPress;
            // 
            // materialTextBoxBlankValue
            // 
            materialTextBoxBlankValue.AnimateReadOnly = false;
            materialTextBoxBlankValue.BorderStyle = BorderStyle.None;
            materialTextBoxBlankValue.Depth = 0;
            materialTextBoxBlankValue.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxBlankValue.Hint = "Blank Value";
            materialTextBoxBlankValue.LeadingIcon = null;
            materialTextBoxBlankValue.Location = new Point(42, 202);
            materialTextBoxBlankValue.MaxLength = 50;
            materialTextBoxBlankValue.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxBlankValue.Multiline = false;
            materialTextBoxBlankValue.Name = "materialTextBoxBlankValue";
            materialTextBoxBlankValue.Size = new Size(250, 50);
            materialTextBoxBlankValue.TabIndex = 0;
            materialTextBoxBlankValue.Text = "";
            materialTextBoxBlankValue.TrailingIcon = null;
            materialTextBoxBlankValue.KeyPress += materialTextBoxBlankValue_KeyPress;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Control;
            groupBox4.Controls.Add(labelMassOfEmptyPanError);
            groupBox4.Controls.Add(labelMassOfUndriedSampleError);
            groupBox4.Controls.Add(labelMassofDriedSampleError);
            groupBox4.Controls.Add(materialButtonClearMoistureContent);
            groupBox4.Controls.Add(materialTextBoxMassOfEmptyPan);
            groupBox4.Controls.Add(materialButtonCalculateMoistureContent);
            groupBox4.Controls.Add(textBoxMoistureContentResult);
            groupBox4.Controls.Add(materialTextBoxMassOfUndriedSample);
            groupBox4.Controls.Add(materialTextBoxMassOfDriedSample);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(79, 636);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(334, 453);
            groupBox4.TabIndex = 35;
            groupBox4.TabStop = false;
            groupBox4.Text = "Percentage of Moisture Content";
            // 
            // labelMassOfEmptyPanError
            // 
            labelMassOfEmptyPanError.AutoSize = true;
            labelMassOfEmptyPanError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelMassOfEmptyPanError.Location = new Point(45, 178);
            labelMassOfEmptyPanError.Name = "labelMassOfEmptyPanError";
            labelMassOfEmptyPanError.Size = new Size(73, 20);
            labelMassOfEmptyPanError.TabIndex = 44;
            labelMassOfEmptyPanError.Text = "Required!";
            // 
            // labelMassOfUndriedSampleError
            // 
            labelMassOfUndriedSampleError.AutoSize = true;
            labelMassOfUndriedSampleError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelMassOfUndriedSampleError.Location = new Point(42, 276);
            labelMassOfUndriedSampleError.Name = "labelMassOfUndriedSampleError";
            labelMassOfUndriedSampleError.Size = new Size(73, 20);
            labelMassOfUndriedSampleError.TabIndex = 43;
            labelMassOfUndriedSampleError.Text = "Required!";
            // 
            // labelMassofDriedSampleError
            // 
            labelMassofDriedSampleError.AutoSize = true;
            labelMassofDriedSampleError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelMassofDriedSampleError.Location = new Point(45, 369);
            labelMassofDriedSampleError.Name = "labelMassofDriedSampleError";
            labelMassofDriedSampleError.Size = new Size(73, 20);
            labelMassofDriedSampleError.TabIndex = 42;
            labelMassofDriedSampleError.Text = "Required!";
            // 
            // materialButtonClearMoistureContent
            // 
            materialButtonClearMoistureContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonClearMoistureContent.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonClearMoistureContent.Cursor = Cursors.Hand;
            materialButtonClearMoistureContent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonClearMoistureContent.Depth = 0;
            materialButtonClearMoistureContent.HighEmphasis = true;
            materialButtonClearMoistureContent.Icon = null;
            materialButtonClearMoistureContent.Location = new Point(193, 397);
            materialButtonClearMoistureContent.Margin = new Padding(5);
            materialButtonClearMoistureContent.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonClearMoistureContent.Name = "materialButtonClearMoistureContent";
            materialButtonClearMoistureContent.NoAccentTextColor = Color.Empty;
            materialButtonClearMoistureContent.Size = new Size(66, 36);
            materialButtonClearMoistureContent.TabIndex = 41;
            materialButtonClearMoistureContent.Text = "Clear";
            materialButtonClearMoistureContent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonClearMoistureContent.UseAccentColor = true;
            materialButtonClearMoistureContent.UseVisualStyleBackColor = true;
            materialButtonClearMoistureContent.Click += materialButtonClearMoistureContent_Click;
            // 
            // materialTextBoxMassOfEmptyPan
            // 
            materialTextBoxMassOfEmptyPan.AnimateReadOnly = false;
            materialTextBoxMassOfEmptyPan.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfEmptyPan.Depth = 0;
            materialTextBoxMassOfEmptyPan.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfEmptyPan.Hint = "Mass of Empty Pan";
            materialTextBoxMassOfEmptyPan.LeadingIcon = null;
            materialTextBoxMassOfEmptyPan.Location = new Point(45, 112);
            materialTextBoxMassOfEmptyPan.MaxLength = 50;
            materialTextBoxMassOfEmptyPan.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfEmptyPan.Multiline = false;
            materialTextBoxMassOfEmptyPan.Name = "materialTextBoxMassOfEmptyPan";
            materialTextBoxMassOfEmptyPan.Size = new Size(247, 50);
            materialTextBoxMassOfEmptyPan.TabIndex = 33;
            materialTextBoxMassOfEmptyPan.Text = "";
            materialTextBoxMassOfEmptyPan.TrailingIcon = null;
            materialTextBoxMassOfEmptyPan.KeyPress += materialTextBoxMassOfEmptyPan_KeyPress;
            // 
            // materialButtonCalculateMoistureContent
            // 
            materialButtonCalculateMoistureContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonCalculateMoistureContent.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonCalculateMoistureContent.Cursor = Cursors.Hand;
            materialButtonCalculateMoistureContent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonCalculateMoistureContent.Depth = 0;
            materialButtonCalculateMoistureContent.HighEmphasis = true;
            materialButtonCalculateMoistureContent.Icon = null;
            materialButtonCalculateMoistureContent.Location = new Point(66, 397);
            materialButtonCalculateMoistureContent.Margin = new Padding(5);
            materialButtonCalculateMoistureContent.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonCalculateMoistureContent.Name = "materialButtonCalculateMoistureContent";
            materialButtonCalculateMoistureContent.NoAccentTextColor = Color.Empty;
            materialButtonCalculateMoistureContent.Size = new Size(103, 36);
            materialButtonCalculateMoistureContent.TabIndex = 32;
            materialButtonCalculateMoistureContent.Text = "Calculate";
            materialButtonCalculateMoistureContent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonCalculateMoistureContent.UseAccentColor = true;
            materialButtonCalculateMoistureContent.UseVisualStyleBackColor = true;
            materialButtonCalculateMoistureContent.Click += materialButtonCalculateMoistureContent_Click;
            // 
            // textBoxMoistureContentResult
            // 
            textBoxMoistureContentResult.BackColor = SystemColors.Window;
            textBoxMoistureContentResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxMoistureContentResult.Enabled = false;
            textBoxMoistureContentResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMoistureContentResult.ForeColor = SystemColors.WindowText;
            textBoxMoistureContentResult.Location = new Point(42, 47);
            textBoxMoistureContentResult.Name = "textBoxMoistureContentResult";
            textBoxMoistureContentResult.Size = new Size(250, 47);
            textBoxMoistureContentResult.TabIndex = 2;
            textBoxMoistureContentResult.TextAlign = HorizontalAlignment.Center;
            // 
            // materialTextBoxMassOfUndriedSample
            // 
            materialTextBoxMassOfUndriedSample.AnimateReadOnly = false;
            materialTextBoxMassOfUndriedSample.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfUndriedSample.Depth = 0;
            materialTextBoxMassOfUndriedSample.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfUndriedSample.Hint = "Mass of Undried Sample";
            materialTextBoxMassOfUndriedSample.LeadingIcon = null;
            materialTextBoxMassOfUndriedSample.Location = new Point(42, 207);
            materialTextBoxMassOfUndriedSample.MaxLength = 50;
            materialTextBoxMassOfUndriedSample.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfUndriedSample.Multiline = false;
            materialTextBoxMassOfUndriedSample.Name = "materialTextBoxMassOfUndriedSample";
            materialTextBoxMassOfUndriedSample.Size = new Size(250, 50);
            materialTextBoxMassOfUndriedSample.TabIndex = 1;
            materialTextBoxMassOfUndriedSample.Text = "";
            materialTextBoxMassOfUndriedSample.TrailingIcon = null;
            materialTextBoxMassOfUndriedSample.KeyPress += materialTextBoxMassOfUndriedSample_KeyPress;
            // 
            // materialTextBoxMassOfDriedSample
            // 
            materialTextBoxMassOfDriedSample.AnimateReadOnly = false;
            materialTextBoxMassOfDriedSample.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfDriedSample.Depth = 0;
            materialTextBoxMassOfDriedSample.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfDriedSample.Hint = "Mass of Dried Sample";
            materialTextBoxMassOfDriedSample.LeadingIcon = null;
            materialTextBoxMassOfDriedSample.Location = new Point(42, 300);
            materialTextBoxMassOfDriedSample.MaxLength = 50;
            materialTextBoxMassOfDriedSample.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfDriedSample.Multiline = false;
            materialTextBoxMassOfDriedSample.Name = "materialTextBoxMassOfDriedSample";
            materialTextBoxMassOfDriedSample.Size = new Size(250, 50);
            materialTextBoxMassOfDriedSample.TabIndex = 0;
            materialTextBoxMassOfDriedSample.Text = "";
            materialTextBoxMassOfDriedSample.TrailingIcon = null;
            materialTextBoxMassOfDriedSample.KeyPress += materialTextBoxMassOfDriedSample_KeyPress;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Control;
            groupBox5.Controls.Add(labelFatContentMassOfTestSampleError);
            groupBox5.Controls.Add(labelFatContentMassOfGlasswareUsedError);
            groupBox5.Controls.Add(labelFatContentMassOfExtractedOilError);
            groupBox5.Controls.Add(materialButtonClearFatContent);
            groupBox5.Controls.Add(materialTextBoxMassOfTestSampleFatContent);
            groupBox5.Controls.Add(materialButtonCalculateFatContent);
            groupBox5.Controls.Add(textBoxFatContentResult);
            groupBox5.Controls.Add(materialTextBoxMassOfGlasswareFatContent);
            groupBox5.Controls.Add(materialTextBoxMassOfExtractedOil);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(471, 636);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(334, 453);
            groupBox5.TabIndex = 36;
            groupBox5.TabStop = false;
            groupBox5.Text = "Percentage of Fat Content";
            // 
            // labelFatContentMassOfTestSampleError
            // 
            labelFatContentMassOfTestSampleError.AutoSize = true;
            labelFatContentMassOfTestSampleError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFatContentMassOfTestSampleError.Location = new Point(42, 365);
            labelFatContentMassOfTestSampleError.Name = "labelFatContentMassOfTestSampleError";
            labelFatContentMassOfTestSampleError.Size = new Size(73, 20);
            labelFatContentMassOfTestSampleError.TabIndex = 45;
            labelFatContentMassOfTestSampleError.Text = "Required!";
            // 
            // labelFatContentMassOfGlasswareUsedError
            // 
            labelFatContentMassOfGlasswareUsedError.AutoSize = true;
            labelFatContentMassOfGlasswareUsedError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFatContentMassOfGlasswareUsedError.Location = new Point(42, 175);
            labelFatContentMassOfGlasswareUsedError.Name = "labelFatContentMassOfGlasswareUsedError";
            labelFatContentMassOfGlasswareUsedError.Size = new Size(73, 20);
            labelFatContentMassOfGlasswareUsedError.TabIndex = 44;
            labelFatContentMassOfGlasswareUsedError.Text = "Required!";
            // 
            // labelFatContentMassOfExtractedOilError
            // 
            labelFatContentMassOfExtractedOilError.AutoSize = true;
            labelFatContentMassOfExtractedOilError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFatContentMassOfExtractedOilError.Location = new Point(42, 271);
            labelFatContentMassOfExtractedOilError.Name = "labelFatContentMassOfExtractedOilError";
            labelFatContentMassOfExtractedOilError.Size = new Size(73, 20);
            labelFatContentMassOfExtractedOilError.TabIndex = 43;
            labelFatContentMassOfExtractedOilError.Text = "Required!";
            // 
            // materialButtonClearFatContent
            // 
            materialButtonClearFatContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonClearFatContent.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonClearFatContent.Cursor = Cursors.Hand;
            materialButtonClearFatContent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonClearFatContent.Depth = 0;
            materialButtonClearFatContent.HighEmphasis = true;
            materialButtonClearFatContent.Icon = null;
            materialButtonClearFatContent.Location = new Point(193, 397);
            materialButtonClearFatContent.Margin = new Padding(5);
            materialButtonClearFatContent.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonClearFatContent.Name = "materialButtonClearFatContent";
            materialButtonClearFatContent.NoAccentTextColor = Color.Empty;
            materialButtonClearFatContent.Size = new Size(66, 36);
            materialButtonClearFatContent.TabIndex = 41;
            materialButtonClearFatContent.Text = "Clear";
            materialButtonClearFatContent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonClearFatContent.UseAccentColor = true;
            materialButtonClearFatContent.UseVisualStyleBackColor = true;
            materialButtonClearFatContent.Click += materialButtonClearFatContent_Click;
            // 
            // materialTextBoxMassOfTestSampleFatContent
            // 
            materialTextBoxMassOfTestSampleFatContent.AnimateReadOnly = false;
            materialTextBoxMassOfTestSampleFatContent.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfTestSampleFatContent.Depth = 0;
            materialTextBoxMassOfTestSampleFatContent.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfTestSampleFatContent.Hint = "Mass of Test Sample";
            materialTextBoxMassOfTestSampleFatContent.LeadingIcon = null;
            materialTextBoxMassOfTestSampleFatContent.Location = new Point(42, 299);
            materialTextBoxMassOfTestSampleFatContent.MaxLength = 50;
            materialTextBoxMassOfTestSampleFatContent.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfTestSampleFatContent.Multiline = false;
            materialTextBoxMassOfTestSampleFatContent.Name = "materialTextBoxMassOfTestSampleFatContent";
            materialTextBoxMassOfTestSampleFatContent.Size = new Size(247, 50);
            materialTextBoxMassOfTestSampleFatContent.TabIndex = 33;
            materialTextBoxMassOfTestSampleFatContent.Text = "";
            materialTextBoxMassOfTestSampleFatContent.TrailingIcon = null;
            materialTextBoxMassOfTestSampleFatContent.KeyPress += materialTextBoxMassOfTestSampleFatContent_KeyPress;
            // 
            // materialButtonCalculateFatContent
            // 
            materialButtonCalculateFatContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonCalculateFatContent.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonCalculateFatContent.Cursor = Cursors.Hand;
            materialButtonCalculateFatContent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonCalculateFatContent.Depth = 0;
            materialButtonCalculateFatContent.HighEmphasis = true;
            materialButtonCalculateFatContent.Icon = null;
            materialButtonCalculateFatContent.Location = new Point(66, 397);
            materialButtonCalculateFatContent.Margin = new Padding(5);
            materialButtonCalculateFatContent.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonCalculateFatContent.Name = "materialButtonCalculateFatContent";
            materialButtonCalculateFatContent.NoAccentTextColor = Color.Empty;
            materialButtonCalculateFatContent.Size = new Size(103, 36);
            materialButtonCalculateFatContent.TabIndex = 32;
            materialButtonCalculateFatContent.Text = "Calculate";
            materialButtonCalculateFatContent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonCalculateFatContent.UseAccentColor = true;
            materialButtonCalculateFatContent.UseVisualStyleBackColor = true;
            materialButtonCalculateFatContent.Click += materialButtonCalculateFatContent_Click;
            // 
            // textBoxFatContentResult
            // 
            textBoxFatContentResult.BackColor = SystemColors.Window;
            textBoxFatContentResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxFatContentResult.Enabled = false;
            textBoxFatContentResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxFatContentResult.ForeColor = SystemColors.WindowText;
            textBoxFatContentResult.Location = new Point(42, 47);
            textBoxFatContentResult.Name = "textBoxFatContentResult";
            textBoxFatContentResult.Size = new Size(250, 47);
            textBoxFatContentResult.TabIndex = 2;
            textBoxFatContentResult.TextAlign = HorizontalAlignment.Center;
            // 
            // materialTextBoxMassOfGlasswareFatContent
            // 
            materialTextBoxMassOfGlasswareFatContent.AnimateReadOnly = false;
            materialTextBoxMassOfGlasswareFatContent.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfGlasswareFatContent.Depth = 0;
            materialTextBoxMassOfGlasswareFatContent.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfGlasswareFatContent.Hint = "Mass of Glassware with Oil";
            materialTextBoxMassOfGlasswareFatContent.LeadingIcon = null;
            materialTextBoxMassOfGlasswareFatContent.Location = new Point(42, 106);
            materialTextBoxMassOfGlasswareFatContent.MaxLength = 50;
            materialTextBoxMassOfGlasswareFatContent.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfGlasswareFatContent.Multiline = false;
            materialTextBoxMassOfGlasswareFatContent.Name = "materialTextBoxMassOfGlasswareFatContent";
            materialTextBoxMassOfGlasswareFatContent.Size = new Size(250, 50);
            materialTextBoxMassOfGlasswareFatContent.TabIndex = 1;
            materialTextBoxMassOfGlasswareFatContent.Text = "";
            materialTextBoxMassOfGlasswareFatContent.TrailingIcon = null;
            materialTextBoxMassOfGlasswareFatContent.KeyPress += materialTextBoxMassOfGlasswareFatContent_KeyPress;
            // 
            // materialTextBoxMassOfExtractedOil
            // 
            materialTextBoxMassOfExtractedOil.AnimateReadOnly = false;
            materialTextBoxMassOfExtractedOil.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfExtractedOil.Depth = 0;
            materialTextBoxMassOfExtractedOil.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfExtractedOil.Hint = "Mass of Empty Glassware";
            materialTextBoxMassOfExtractedOil.LeadingIcon = null;
            materialTextBoxMassOfExtractedOil.Location = new Point(42, 202);
            materialTextBoxMassOfExtractedOil.MaxLength = 50;
            materialTextBoxMassOfExtractedOil.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfExtractedOil.Multiline = false;
            materialTextBoxMassOfExtractedOil.Name = "materialTextBoxMassOfExtractedOil";
            materialTextBoxMassOfExtractedOil.Size = new Size(250, 50);
            materialTextBoxMassOfExtractedOil.TabIndex = 0;
            materialTextBoxMassOfExtractedOil.Text = "";
            materialTextBoxMassOfExtractedOil.TrailingIcon = null;
            materialTextBoxMassOfExtractedOil.KeyPress += materialTextBoxMassOfExtractedOil_KeyPress;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.Control;
            groupBox6.Controls.Add(labelPVMassOfTestSampleError);
            groupBox6.Controls.Add(labelPVVolumeOFTitrantOFBlankError);
            groupBox6.Controls.Add(labelPVVolumeOfTitrantOfSampleError);
            groupBox6.Controls.Add(materialButtonClearPeroxideValue);
            groupBox6.Controls.Add(materialTextBoxMassOfTestSamplePV);
            groupBox6.Controls.Add(materialButtonCalculatePV);
            groupBox6.Controls.Add(textBoxPeroxideValueResult);
            groupBox6.Controls.Add(materialTextBoxVolumeOfTitrantOfBlank);
            groupBox6.Controls.Add(materialTextBoxVolumeOfTitrantSample);
            groupBox6.FlatStyle = FlatStyle.Flat;
            groupBox6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(867, 636);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(334, 453);
            groupBox6.TabIndex = 36;
            groupBox6.TabStop = false;
            groupBox6.Text = "Peroxide Value (PV)";
            // 
            // labelPVMassOfTestSampleError
            // 
            labelPVMassOfTestSampleError.AutoSize = true;
            labelPVMassOfTestSampleError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPVMassOfTestSampleError.Location = new Point(42, 177);
            labelPVMassOfTestSampleError.Name = "labelPVMassOfTestSampleError";
            labelPVMassOfTestSampleError.Size = new Size(73, 20);
            labelPVMassOfTestSampleError.TabIndex = 46;
            labelPVMassOfTestSampleError.Text = "Required!";
            // 
            // labelPVVolumeOFTitrantOFBlankError
            // 
            labelPVVolumeOFTitrantOFBlankError.AutoSize = true;
            labelPVVolumeOFTitrantOFBlankError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPVVolumeOFTitrantOFBlankError.Location = new Point(42, 370);
            labelPVVolumeOFTitrantOFBlankError.Name = "labelPVVolumeOFTitrantOFBlankError";
            labelPVVolumeOFTitrantOFBlankError.Size = new Size(73, 20);
            labelPVVolumeOFTitrantOFBlankError.TabIndex = 45;
            labelPVVolumeOFTitrantOFBlankError.Text = "Required!";
            // 
            // labelPVVolumeOfTitrantOfSampleError
            // 
            labelPVVolumeOfTitrantOfSampleError.AutoSize = true;
            labelPVVolumeOfTitrantOfSampleError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPVVolumeOfTitrantOfSampleError.Location = new Point(42, 273);
            labelPVVolumeOfTitrantOfSampleError.Name = "labelPVVolumeOfTitrantOfSampleError";
            labelPVVolumeOfTitrantOfSampleError.Size = new Size(73, 20);
            labelPVVolumeOfTitrantOfSampleError.TabIndex = 44;
            labelPVVolumeOfTitrantOfSampleError.Text = "Required!";
            // 
            // materialButtonClearPeroxideValue
            // 
            materialButtonClearPeroxideValue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonClearPeroxideValue.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonClearPeroxideValue.Cursor = Cursors.Hand;
            materialButtonClearPeroxideValue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonClearPeroxideValue.Depth = 0;
            materialButtonClearPeroxideValue.HighEmphasis = true;
            materialButtonClearPeroxideValue.Icon = null;
            materialButtonClearPeroxideValue.Location = new Point(193, 397);
            materialButtonClearPeroxideValue.Margin = new Padding(5);
            materialButtonClearPeroxideValue.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonClearPeroxideValue.Name = "materialButtonClearPeroxideValue";
            materialButtonClearPeroxideValue.NoAccentTextColor = Color.Empty;
            materialButtonClearPeroxideValue.Size = new Size(66, 36);
            materialButtonClearPeroxideValue.TabIndex = 41;
            materialButtonClearPeroxideValue.Text = "Clear";
            materialButtonClearPeroxideValue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonClearPeroxideValue.UseAccentColor = true;
            materialButtonClearPeroxideValue.UseVisualStyleBackColor = true;
            materialButtonClearPeroxideValue.Click += materialButtonClearPeroxideValue_Click;
            // 
            // materialTextBoxMassOfTestSamplePV
            // 
            materialTextBoxMassOfTestSamplePV.AnimateReadOnly = false;
            materialTextBoxMassOfTestSamplePV.BorderStyle = BorderStyle.None;
            materialTextBoxMassOfTestSamplePV.Depth = 0;
            materialTextBoxMassOfTestSamplePV.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMassOfTestSamplePV.Hint = "Mass of Test Sample";
            materialTextBoxMassOfTestSamplePV.LeadingIcon = null;
            materialTextBoxMassOfTestSamplePV.Location = new Point(42, 111);
            materialTextBoxMassOfTestSamplePV.MaxLength = 50;
            materialTextBoxMassOfTestSamplePV.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMassOfTestSamplePV.Multiline = false;
            materialTextBoxMassOfTestSamplePV.Name = "materialTextBoxMassOfTestSamplePV";
            materialTextBoxMassOfTestSamplePV.Size = new Size(247, 50);
            materialTextBoxMassOfTestSamplePV.TabIndex = 33;
            materialTextBoxMassOfTestSamplePV.Text = "";
            materialTextBoxMassOfTestSamplePV.TrailingIcon = null;
            materialTextBoxMassOfTestSamplePV.KeyPress += materialTextBoxMassOfTestSamplePV_KeyPress;
            // 
            // materialButtonCalculatePV
            // 
            materialButtonCalculatePV.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonCalculatePV.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonCalculatePV.Cursor = Cursors.Hand;
            materialButtonCalculatePV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonCalculatePV.Depth = 0;
            materialButtonCalculatePV.HighEmphasis = true;
            materialButtonCalculatePV.Icon = null;
            materialButtonCalculatePV.Location = new Point(66, 397);
            materialButtonCalculatePV.Margin = new Padding(5);
            materialButtonCalculatePV.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonCalculatePV.Name = "materialButtonCalculatePV";
            materialButtonCalculatePV.NoAccentTextColor = Color.Empty;
            materialButtonCalculatePV.Size = new Size(103, 36);
            materialButtonCalculatePV.TabIndex = 32;
            materialButtonCalculatePV.Text = "Calculate";
            materialButtonCalculatePV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonCalculatePV.UseAccentColor = true;
            materialButtonCalculatePV.UseVisualStyleBackColor = true;
            materialButtonCalculatePV.Click += materialButtonCalculatePV_Click;
            // 
            // textBoxPeroxideValueResult
            // 
            textBoxPeroxideValueResult.BackColor = SystemColors.Window;
            textBoxPeroxideValueResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxPeroxideValueResult.Enabled = false;
            textBoxPeroxideValueResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPeroxideValueResult.ForeColor = SystemColors.WindowText;
            textBoxPeroxideValueResult.Location = new Point(42, 47);
            textBoxPeroxideValueResult.Name = "textBoxPeroxideValueResult";
            textBoxPeroxideValueResult.Size = new Size(250, 47);
            textBoxPeroxideValueResult.TabIndex = 2;
            textBoxPeroxideValueResult.TextAlign = HorizontalAlignment.Center;
            // 
            // materialTextBoxVolumeOfTitrantOfBlank
            // 
            materialTextBoxVolumeOfTitrantOfBlank.AnimateReadOnly = false;
            materialTextBoxVolumeOfTitrantOfBlank.BorderStyle = BorderStyle.None;
            materialTextBoxVolumeOfTitrantOfBlank.Depth = 0;
            materialTextBoxVolumeOfTitrantOfBlank.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxVolumeOfTitrantOfBlank.Hint = "Volume of Titrant of Blank";
            materialTextBoxVolumeOfTitrantOfBlank.LeadingIcon = null;
            materialTextBoxVolumeOfTitrantOfBlank.Location = new Point(42, 301);
            materialTextBoxVolumeOfTitrantOfBlank.MaxLength = 50;
            materialTextBoxVolumeOfTitrantOfBlank.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxVolumeOfTitrantOfBlank.Multiline = false;
            materialTextBoxVolumeOfTitrantOfBlank.Name = "materialTextBoxVolumeOfTitrantOfBlank";
            materialTextBoxVolumeOfTitrantOfBlank.Size = new Size(250, 50);
            materialTextBoxVolumeOfTitrantOfBlank.TabIndex = 1;
            materialTextBoxVolumeOfTitrantOfBlank.Text = "";
            materialTextBoxVolumeOfTitrantOfBlank.TrailingIcon = null;
            materialTextBoxVolumeOfTitrantOfBlank.KeyPress += materialTextBoxVolumeOfTitrantOfBlank_KeyPress;
            // 
            // materialTextBoxVolumeOfTitrantSample
            // 
            materialTextBoxVolumeOfTitrantSample.AnimateReadOnly = false;
            materialTextBoxVolumeOfTitrantSample.BorderStyle = BorderStyle.None;
            materialTextBoxVolumeOfTitrantSample.Depth = 0;
            materialTextBoxVolumeOfTitrantSample.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxVolumeOfTitrantSample.Hint = "Volume of Titrant of Sample";
            materialTextBoxVolumeOfTitrantSample.LeadingIcon = null;
            materialTextBoxVolumeOfTitrantSample.Location = new Point(42, 204);
            materialTextBoxVolumeOfTitrantSample.MaxLength = 50;
            materialTextBoxVolumeOfTitrantSample.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxVolumeOfTitrantSample.Multiline = false;
            materialTextBoxVolumeOfTitrantSample.Name = "materialTextBoxVolumeOfTitrantSample";
            materialTextBoxVolumeOfTitrantSample.Size = new Size(250, 50);
            materialTextBoxVolumeOfTitrantSample.TabIndex = 0;
            materialTextBoxVolumeOfTitrantSample.Text = "";
            materialTextBoxVolumeOfTitrantSample.TrailingIcon = null;
            materialTextBoxVolumeOfTitrantSample.KeyPress += materialTextBoxVolumeOfTitrantSample_KeyPress;
            // 
            // labelConcentrationOfNaOH
            // 
            labelConcentrationOfNaOH.AutoSize = true;
            labelConcentrationOfNaOH.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelConcentrationOfNaOH.Location = new Point(334, 21);
            labelConcentrationOfNaOH.Name = "labelConcentrationOfNaOH";
            labelConcentrationOfNaOH.Size = new Size(0, 23);
            labelConcentrationOfNaOH.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(122, 21);
            label5.Name = "label5";
            label5.Size = new Size(208, 23);
            label5.TabIndex = 38;
            label5.Text = "Concentration of NaOH :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(123, 61);
            label7.Name = "label7";
            label7.Size = new Size(209, 23);
            label7.TabIndex = 39;
            label7.Text = "Normality of Na₂S₂O₃    :";
            // 
            // labelNormalityOfNaSO
            // 
            labelNormalityOfNaSO.AutoSize = true;
            labelNormalityOfNaSO.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelNormalityOfNaSO.Location = new Point(337, 61);
            labelNormalityOfNaSO.Name = "labelNormalityOfNaSO";
            labelNormalityOfNaSO.Size = new Size(0, 23);
            labelNormalityOfNaSO.TabIndex = 43;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(materialButtonSetVariables);
            groupBox7.Controls.Add(labelNormalityOfNaSO);
            groupBox7.Controls.Add(labelConcentrationOfNaOH);
            groupBox7.Controls.Add(label5);
            groupBox7.Controls.Add(label7);
            groupBox7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(308, 70);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(674, 103);
            groupBox7.TabIndex = 44;
            groupBox7.TabStop = false;
            groupBox7.Text = "Variables";
            // 
            // AnalysisCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 1096);
            ClientSize = new Size(1388, 1102);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AnalysisCalculatorForm";
            Padding = new Padding(3, 85, 3, 4);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Analysis Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButtonSetVariables;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfSampleTaken;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxTitreValueForFFA;
        private TextBox textBoxFFAResult;
        private MaterialSkin.Controls.MaterialButton materialButtonCalculateFFA;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfGlasswareUsed;
        private MaterialSkin.Controls.MaterialButton materialButtonCalculateAcetoneContent;
        private TextBox textBoxAcetoneContentResult;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfUnevaporatedSample;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfEvaporatedSample;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfTestSampleIV;
        private MaterialSkin.Controls.MaterialButton materialButtonCalculateIV;
        private TextBox textBoxIodineValueResult;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxTitreValueForIV;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxBlankValue;
        private GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfEmptyPan;
        private MaterialSkin.Controls.MaterialButton materialButtonCalculateMoistureContent;
        private TextBox textBoxMoistureContentResult;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfUndriedSample;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfDriedSample;
        private GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfTestSampleFatContent;
        private MaterialSkin.Controls.MaterialButton materialButtonCalculateFatContent;
        private TextBox textBoxFatContentResult;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfGlasswareFatContent;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfExtractedOil;
        private GroupBox groupBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMassOfTestSamplePV;
        private MaterialSkin.Controls.MaterialButton materialButtonCalculatePV;
        private TextBox textBoxPeroxideValueResult;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxVolumeOfTitrantOfBlank;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxVolumeOfTitrantSample;
        private Label labelConcentrationOfNaOH;
        private Label label5;
        private Label label7;
        private Label labelNormalityOfNaSO;
        private GroupBox groupBox7;
        private MaterialSkin.Controls.MaterialButton materialButtonClearFFA;
        private Label labelFFAMassOfSampleTakenError;
        private Label labelFFATitreValueError;
        private Label labelAcetoneContentMassOfGlasswareUsedError;
        private Label labelAcetoneContentMassOfUnevaporatedSampleError;
        private Label labelAcetoneContentMassOfEvaporatedSampleError;
        private MaterialSkin.Controls.MaterialButton materialButtonClearAcetoneContent;
        private Label labelIVMassOfTestSampleError;
        private Label labelIVTitreValueError;
        private Label labelIVBlankValueError;
        private MaterialSkin.Controls.MaterialButton materialButtonClearIV;
        private Label labelMassOfEmptyPanError;
        private Label labelMassOfUndriedSampleError;
        private Label labelMassofDriedSampleError;
        private MaterialSkin.Controls.MaterialButton materialButtonClearMoistureContent;
        private MaterialSkin.Controls.MaterialButton materialButtonClearFatContent;
        private MaterialSkin.Controls.MaterialButton materialButtonClearPeroxideValue;
        private Label labelFatContentMassOfTestSampleError;
        private Label labelFatContentMassOfGlasswareUsedError;
        private Label labelFatContentMassOfExtractedOilError;
        private Label labelPVMassOfTestSampleError;
        private Label labelPVVolumeOFTitrantOFBlankError;
        private Label labelPVVolumeOfTitrantOfSampleError;
    }
}