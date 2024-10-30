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

        private void DonorManagementForm_Load(object sender, EventArgs e)
        {
            LoadDonors();
        }

        private void LoadDonors()
        {
            using (SqlConnection conn = new SqlConnection("Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Donors", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDonors.DataSource = dt;
            }
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            string donorName = txtName.Text;
            string contactInfo = txtContactInfo.Text;

            using (SqlConnection conn = new SqlConnection("Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                string query = "INSERT INTO Donors (Name, ContactInfo) VALUES (@Name, @ContactInfo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@ContactInfo", txtContactInfo.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Donor added successfully!");
                LoadDonors();
            }

            LoadDonors();
            txtName.Clear();
            txtContactInfo.Clear();
        }

        private void btnEditDonor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDonors.CurrentRow != null)
            {
                int donorId = Convert.ToInt32(dataGridViewDonors.CurrentRow.Cells["Id"].Value); // Assuming there's an Id column
                using (SqlConnection conn = new SqlConnection("Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
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
            else
            {
                MessageBox.Show("Please select a donor to edit.");
            }
        }

        private void btnDeleteDonor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDonors.CurrentRow != null)
            {
                int donorId = Convert.ToInt32(dataGridViewDonors.CurrentRow.Cells["Id"].Value); // Assuming there's an Id column
                using (SqlConnection conn = new SqlConnection("Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
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

