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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LetsGrowApp
{
    public partial class OrganizationManagementForm : Form
    {
        public OrganizationManagementForm()
        {
            InitializeComponent();
           
        }

        private string connectionString = "Server=tcp:khulanathidb.database.windows.net,1433;Initial Catalog=KhulaNathiDb;Persist Security Info=False;User ID=khulanathiAdmin;Password=Khulanath!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private void OrganizationsManagementForm_Load(object sender, EventArgs e)
        {
            LoadOrganizations();
        }

        private void LoadOrganizations()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Organizations", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewOrganizations.DataSource = dt;
            }
        }

        private void btnAddOrganization_Click(object sender, EventArgs e)
        {
            string orgName = txtName.Text.Trim();
            string contactInfo = txtContactInfo.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(orgName) || string.IsNullOrEmpty(contactInfo) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all the input options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Organizations (Name, ContactInfo, Description) VALUES (@Name, @ContactInfo, @Description)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", orgName);
                    cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    cmd.Parameters.AddWithValue("@Description", description);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Organization added successfully!");
                }
                LoadOrganizations();
                txtName.Clear();
                txtContactInfo.Clear();
                txtDescription.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while adding the organization.\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditOrganization_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrganizations.CurrentRow != null)
            {
                int organizationId = Convert.ToInt32(dataGridViewOrganizations.CurrentRow.Cells["Id"].Value);
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Organizations SET Name = @Name, ContactInfo = @ContactInfo, Description = @Description WHERE Id = @Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", organizationId);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@ContactInfo", txtContactInfo.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Organization updated successfully!");
                    }
                    LoadOrganizations();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while updating the organization.\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an organization to edit.");
            }
        }

        private void btnDeleteOrganization_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrganizations.CurrentRow != null)
            {
                int organizationId = Convert.ToInt32(dataGridViewOrganizations.CurrentRow.Cells["Id"].Value);
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Organizations WHERE Id = @Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", organizationId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Organization deleted successfully!");
                    }
                    LoadOrganizations();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting the organization.\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an organization to delete.");
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }

}

