using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsGrowApp
{
    public partial class DonorManagementForm : Form
    {
        public DonorManagementForm()
        {
            InitializeComponent();
           
        }

        private string connectionString = "Server=tcp:khulanathidb.database.windows.net,1433;Initial Catalog=KhulaNathiDb;Persist Security Info=False;User ID=khulanathiAdmin;Password=Khulanath!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private void DonorManagementForm_Load(object sender, EventArgs e)
        {
            LoadDonors();
        }

        private void LoadDonors()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Donors", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDonors.DataSource = dt;
            }
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            string donorName = txtName.Text.Trim();
            string contactInfo = txtContactInfo.Text.Trim();

            if (string.IsNullOrEmpty(donorName) || string.IsNullOrEmpty(contactInfo))
            {
                MessageBox.Show("Please fill in all the input options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Donors (Name, ContactInfo) VALUES (@Name, @ContactInfo)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", donorName);
                    cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor added successfully!");
                    LoadDonors();
                }

                txtName.Clear();
                txtContactInfo.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while adding the donor.\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditDonor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDonors.CurrentRow != null)
            {
                int donorId = Convert.ToInt32(dataGridViewDonors.CurrentRow.Cells["Id"].Value);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Donors SET Name = @Name, ContactInfo = @ContactInfo WHERE Id = @Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", donorId);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@ContactInfo", txtContactInfo.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Donor updated successfully!");
                        LoadDonors();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while updating the donor.\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a donor to edit.");
            }
        }

        private void btnDeleteDonor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDonors.CurrentRow != null)
            {
                int donorId = Convert.ToInt32(dataGridViewDonors.CurrentRow.Cells["Id"].Value);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Donors WHERE Id = @Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", donorId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Donor deleted successfully!");
                        LoadDonors();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting the donor.\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a donor to delete.");
            }
        }
        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide(); // Hide the donor management form
        }
    }
}

