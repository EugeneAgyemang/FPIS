using FPIS.Views;
using MaterialSkin;
using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS
{
    public partial class Startup : MaterialForm
    {
        public Startup()
        {
            InitializeComponent();
            Theme.Instance = this;
            Theme.Set(Themes.LIGHT);
        }
    }
}
