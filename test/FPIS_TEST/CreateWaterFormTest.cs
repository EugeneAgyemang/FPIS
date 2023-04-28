using FPIS.Views;
using Moq;

namespace FPIS_TEST
{
    [TestClass]
    public class CreaetWaterFormTest
    {
        [TestMethod]
        public void ClearFormFields_Test()
        {
            CreateWaterForm form = new();

            form.materialTextBoxWaterName.Text = "Hello World";
            form.ClearFormFields();

            Assert.AreEqual("", form.materialTextBoxWaterName.Text);
        }

        [TestMethod]
        public void ClearErrorLabels_Test()
        {
            CreateWaterForm form = new();

            form.materialLabelWaterNameError.Text = "Error :)";
            form.ClearErrorLabels();

            Assert.AreEqual("", form.materialLabelWaterNameError.Text);
        }

        [TestMethod]
        public void ValidateWaterName_No_Input_Test()
        {
            CreateWaterForm form = new();

            form.materialTextBoxWaterName.Text = "";

            form.ValidateWaterName();

            Assert.IsFalse(form.IsDataValid);
            Assert.AreEqual("Water name is required!", form.materialLabelWaterNameError.Text);
        }


        [TestMethod]
        public void ValidateWaterName_Yes_Input_Test()
        {
            CreateWaterForm form = new();
            form.materialTextBoxWaterName.Text = "Some Name";

            form.ValidateWaterName();

            Assert.IsTrue(form.IsDataValid);
            Assert.AreEqual("", form.materialLabelWaterNameError.Text);
        }
    }
}
