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
            materialDivider1.BackColor = Color.FromArgb(38, 50, 56);
            return skinManager.ColorScheme;
        }
    }
}
