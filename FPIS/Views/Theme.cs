using MaterialSkin;
using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    internal class Theme
    {
        public static MaterialForm FormInstance { get; set; }
        public static ColorScheme Set(Themes preferredTheme)
        {
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            Color childControlsColor = Color.FromArgb(33, 33, 33);
            skinManager.AddFormToManage(FormInstance);
            switch (preferredTheme)
            {
                case Themes.LIGHT:
                    skinManager.ColorScheme = new ColorScheme(Primary.DeepPurple900, Primary.DeepPurple900, Primary.DeepPurple900, Accent.DeepPurple700, TextShade.WHITE);
                    childControlsColor = Color.FromArgb(49, 27, 146);
                    break;
                case Themes.DARK:
                    skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Green700, TextShade.WHITE);
                    childControlsColor = Color.FromArgb(38, 50, 56);
                    break;
            }
            skinManager.Theme = preferredTheme;
            SetChildren(FormInstance, childControlsColor);
            return skinManager.ColorScheme;
        }

        private static int SetChildren(MaterialForm form, Color color)
        {
            int totalNumberOfControlsThemed = 0;
            foreach (var control in form.Controls)
            {
                if (control is MaterialDivider)
                {
                    ((MaterialDivider)control).BackColor = color;
                    totalNumberOfControlsThemed++;
                }
            }
            return totalNumberOfControlsThemed;
        }
    }
}
