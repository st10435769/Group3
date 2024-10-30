using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LetsGrowApp
{
    public partial class DonationsManagementForm : Form
    {
        private string connectionString = "Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public DonationsManagementForm()
        {
            InitializeComponent();
            LoadDonations();
        }

        // Load all donations from the database
        private void LoadDonations()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Donations";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvDonations.DataSource = dt;
                    }
                }
            }
        }

        // Add a new donation
        private void btnAddDonation_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Donations (DonationID, Amount, Date, DonorID, OrganizationID) VALUES (@DonationID, @Amount, @Date, @DonorID, @OrganizationID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DonationID", txtDonationID.Text);
                    command.Parameters.AddWithValue("@Amount", txtAmount.Text);
                    command.Parameters.AddWithValue("@Date", dtpDate.Value);
                    command.Parameters.AddWithValue("@DonorID", txtDonorID.Text);
                    command.Parameters.AddWithValue("@OrganizationID", txtOrganizationID.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadDonations();
            MessageBox.Show("Donation added successfully!");
        }

        // Edit a donation
        private void btnEditDonation_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Donations SET Amount = @Amount, Date = @Date, DonorID = @DonorID, OrganizationID = @OrganizationID WHERE DonationID = @DonationID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DonationID", txtDonationID.Text);
                    command.Parameters.AddWithValue("@Amount", txtAmount.Text);
                    command.Parameters.AddWithValue("@Date", dtpDate.Value);
                    command.Parameters.AddWithValue("@DonorID", txtDonorID.Text);
                    command.Parameters.AddWithValue("@OrganizationID", txtOrganizationID.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadDonations();
            MessageBox.Show("Donation updated successfully!");
        }

        // Delete a donation
        private void btnDeleteDonation_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Donations WHERE DonationID = @DonationID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DonationID", txtDonationID.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadDonations();
            MessageBox.Show("Donation deleted successfully!");
        }

        // Populate the textboxes when a row is selected
        private void dgvDonations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDonations.Rows[e.RowIndex];
                txtDonationID.Text = row.Cells["DonationID"].Value.ToString();
                txtAmount.Text = row.Cells["Amount"].Value.ToString();
                dtpDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                txtDonorID.Text = row.Cells["DonorID"].Value.ToString();
                txtOrganizationID.Text = row.Cells["OrganizationID"].Value.ToString();
            }
        }

private void DonationsManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
