using FPIS.Views;
using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS
{
    public partial class Register : MaterialForm
    {
        public Register()
        {
            InitializeComponent();
            Theme.Instance = this;
            Theme.Set(Themes.LIGHT);
        }
    }
}
