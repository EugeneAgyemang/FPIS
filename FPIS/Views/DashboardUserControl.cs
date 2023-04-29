using FPIS.Models;
using FPIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPIS.Views
{
    public partial class DashboardUserControl : UserControl
    {
        AppDbContext appDbContext = new AppDbContext();
        public DashboardUserControl()
        {
            InitializeComponent();
            LoadUsers();
            LoadSamples();
            LoadSampleResults();
            LoadPendingSamples();
        }
        private void LoadUsers()
        {
            RegisteredUsersControl.Text = $"{appDbContext.Users.Count()}";
        }
        private void LoadSamples()
        {
            SamplesControl.Text = $"{appDbContext.Samples.Count()}";
        }
        private void LoadSampleResults()
        {
            SampleResultsControl.Text = $"{appDbContext.SampleResults.Count()}"; ;
        }

        private void LoadPendingSamples()
        {
            SamplesPendingControl.Text = $"{appDbContext.Samples.Count() - appDbContext.SampleResults.Count()}"; ;
        }
    }
}
