using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsGrowApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDonors_Click(object sender, EventArgs e)
        {
            DonorManagementForm donorForm = new DonorManagementForm();
            donorForm.Show();
            this.Hide(); // Hide the main form
        }

        private void btnOrganizations_Click(object sender, EventArgs e)
        {
            OrganizationManagementForm orgForm = new OrganizationManagementForm();
            orgForm.Show();
            this.Hide(); // Hide the main form
        }

        private void btnFarmProducts_Click(object sender, EventArgs e)
        {
            FarmProductsManagementForm farmForm = new FarmProductsManagementForm();
            farmForm.Show();
            this.Hide(); // Hide the main form
        }

        private void btnDonations_Click(object sender, EventArgs e)
        {
            DonationsManagementForm donationForm = new DonationsManagementForm();
            donationForm.Show();
            this.Hide(); // Hide the main form
        }
    }
}
