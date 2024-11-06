using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LetsGrowApp
{
    public partial class DonationsManagementForm : Form
    {
        private string connectionString = "Server=tcp:khulanathidb.database.windows.net,1433;Initial Catalog=KhulaNathiDb;Persist Security Info=False;User ID=khulanathiAdmin;Password=Khulanath!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public DonationsManagementForm()
        {
            InitializeComponent();
            LoadDonations();
        }

        private void LoadDonations()
        {
            try
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
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading donations: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDonation_Click(object sender, EventArgs e)
        {

            try
            {
                if (!decimal.TryParse(txtAmount.Text, out decimal amount))
                {
                    MessageBox.Show("Please enter a valid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtDonorID.Text, out int donorId))
                {
                    MessageBox.Show("Please enter a valid Donor ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsDonorExists(donorId))
                {
                    MessageBox.Show("The specified Donor ID does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtOrganizationID.Text, out int organizationId))
                {
                    MessageBox.Show("Please enter a valid Organization ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidForeignKey(donorId, organizationId))
                {
                    MessageBox.Show("Invalid DonorID or OrganizationID. Please ensure they exist.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Donations (Amount, Date, DonorID, OrganizationID) VALUES (@Amount, @Date, @DonorID, @OrganizationID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@Date", dtpDate.Value);
                        command.Parameters.AddWithValue("@DonorID", donorId);
                        command.Parameters.AddWithValue("@OrganizationID", organizationId);
                        command.ExecuteNonQuery();
                    }
                }
                LoadDonations();
                MessageBox.Show("Donation added successfully!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error adding donation: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool IsValidForeignKey(int donorId, int organizationId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string validationQuery = "SELECT COUNT(1) FROM Donors WHERE Id = @DonorID;" +
                                         "SELECT COUNT(1) FROM Organizations WHERE Id = @OrganizationID;";
                using (SqlCommand cmd = new SqlCommand(validationQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@DonorID", donorId);
                    cmd.Parameters.AddWithValue("@OrganizationID", organizationId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        bool donorExists = reader.GetInt32(0) > 0;
                        reader.NextResult();
                        reader.Read();
                        bool organizationExists = reader.GetInt32(0) > 0;

                        return donorExists && organizationExists;
                    }
                }
            }
        }

        private void btnEditDonation_Click(object sender, EventArgs e)
        {

            try
            {
                if (!int.TryParse(txtDonationID.Text, out int donationId) ||
                    !decimal.TryParse(txtAmount.Text, out decimal amount) ||
                    !int.TryParse(txtDonorID.Text, out int donorId) ||
                    !int.TryParse(txtOrganizationID.Text, out int organizationId))
                {
                    MessageBox.Show("Please ensure all fields have valid values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Donations SET Amount = @Amount, Date = @Date, DonorID = @DonorID, OrganizationID = @OrganizationID WHERE DonationID = @DonationID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DonationID", donationId);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@Date", dtpDate.Value);
                        command.Parameters.AddWithValue("@DonorID", donorId);
                        command.Parameters.AddWithValue("@OrganizationID", organizationId);
                        command.ExecuteNonQuery();
                    }
                }
                LoadDonations();
                MessageBox.Show("Donation updated successfully!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error updating donation: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("One or more fields are in an incorrect format.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsDonorExists(int donorId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Donors WHERE Id = @DonorID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DonorID", donorId);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

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

        private void dgvDonations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected donation data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

    }
}
