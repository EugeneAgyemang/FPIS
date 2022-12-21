using MaterialSkin;
using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            SetTheme(Themes.LIGHT);
        }

        private ColorScheme SetTheme(Themes materialSkinTheme)
        {
            MaterialSkinManager skinManager = Instance;
            skinManager.AddFormToManage(this);
            switch (materialSkinTheme)
            {
                case Themes.LIGHT:
                    skinManager.ColorScheme = new ColorScheme(Primary.Purple900, Primary.Purple900, Primary.Purple900, Accent.Purple700, TextShade.WHITE);
                    break;
                case Themes.DARK:
                    skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Green700, TextShade.WHITE);
                    break;
            }
            skinManager.Theme = materialSkinTheme;
            return skinManager.ColorScheme;
        }
    }
}
