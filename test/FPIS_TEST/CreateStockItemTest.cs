using FPIS.Views;

namespace FPIS_TEST
{
    [TestClass]
    public class CreateStockItemTest
    {
        [TestMethod]
        public void ClearFormFields_Test()
        {
            CreateStockItem form = new();
            

            form.materialTextBoxStockItemName.Text = "Some Stock Item";
            form.materialComboBoxUnitOfMeasurement.Text = "Fake Unit";
            form.materialComboBoxStockItemType.Text = "Some Type";
            form.ClearFormFields();

            Assert.AreEqual("", form.materialTextBoxStockItemName.Text);
            Assert.AreEqual("", form.materialComboBoxUnitOfMeasurement.Text);
            Assert.AreEqual("", form.materialComboBoxStockItemType.Text);
        }

        [TestMethod]
        public void ClearErrorLabels_Test()
        {
            CreateStockItem form = new();

            form.labelStockItemName.Text = "Error :)";
            form.labelUnitOfMeasurement.Text = "Error :";
            form.labelStockItemType.Text = "Error :";
            form.ClearErrorLabels();

            Assert.AreEqual("", form.labelStockItemName.Text);
            Assert.AreEqual("", form.labelUnitOfMeasurement.Text);
            Assert.AreEqual("", form.labelStockItemType.Text);
        }

        [TestMethod]
        public void ValidateStockItemName_No_Input_Test()
        {
            CreateStockItem form = new()
            {
                _isDataValid = true
            };

            form.ValidateStockItemName("");

            Assert.IsFalse(form._isDataValid);
            Assert.AreEqual("Stock Item Name is required!", form.labelStockItemName.Text);
        }


        [TestMethod]
        public void ValidateStockItemName_Yes_Input_Test()
        {
            CreateStockItem form = new()
            {
                _isDataValid = true
            };
            form.labelStockItemName.Text = "";

            form.ValidateStockItemName("Some Stock Item Name");

            Assert.IsTrue(form._isDataValid);
            Assert.AreEqual("", form.labelStockItemName.Text);
        }

    }
}
