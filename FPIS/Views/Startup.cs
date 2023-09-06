using FPIS.Views;
using MaterialSkin;
using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS
{
    public partial class Startup : Form
    {
        int timeElpased = 0;
        int timer = 0;
        public Startup()
        {
            Random random = new Random();
            timer = random.Next(4, 8);
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElpased++;

            if (Caption.Text.Contains("....."))
            {
                Caption.Text = "Loading";
            }
            Caption.Text += ".";
            if ((timeElpased / 2) == timer)
            {
                timer1.Stop();
                Hide();
                new Login().Show();
            }
        }
    }
}
