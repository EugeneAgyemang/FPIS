using FPIS.Views;

namespace FPIS_TEST
{
    [TestClass]
    public class CreateProductFormTest
    {
        [TestMethod]
        public void ClearFormFields_Test()
        {
            CreateProductForm form = new();

            form.materialTextBoxProductName.Text = "Hello World";
            form.ClearFormFields();

            Assert.AreEqual("", form.materialTextBoxProductName.Text);
        }

        [TestMethod]
        public void ClearErrorLabels_Test()
        {
            CreateProductForm form = new();

            form.materialLabelProductNameError.Text = "Error :)";
            form.ClearErrorLabels();

            Assert.AreEqual("", form.materialLabelProductNameError.Text);
        }

        [TestMethod]
        public void ValidateProductName_No_Input_Test()
        {
            CreateProductForm form = new()
            {
                _isDataValid = true
            };

            form.ValidateProductName("");

            Assert.IsFalse(form._isDataValid);
            Assert.AreEqual("Name is required!", form.materialLabelProductNameError.Text);
        }


        [TestMethod]
        public void ValidateProductName_Yes_Input_Test()
        {
            CreateProductForm form = new()
            {
                _isDataValid = true
            };
            form.materialLabelProductNameError.Text = ""; // remove every text

            form.ValidateProductName("Some Name");

            Assert.IsTrue(form._isDataValid);
            Assert.AreEqual("", form.materialLabelProductNameError.Text);
        }
    }
}
