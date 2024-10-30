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
    public partial class OrganizationManagementForm : Form
    {
        public OrganizationManagementForm()
        {
            InitializeComponent();
           
        }

        private void OrganizationsManagementForm_Load(object sender, EventArgs e)
        {
            LoadOrganizations();
        }

        private void LoadOrganizations()
        {
            using (SqlConnection conn = new SqlConnection("Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Organizations", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewOrganizations.DataSource = dt;
            }
        }


        private void btnAddOrganization_Click(object sender, EventArgs e)
        {
            string orgName = txtName.Text;
            string contactInfo = txtContactInfo.Text;
            string description = txtDescription.Text;

            using (SqlConnection conn = new SqlConnection("Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                string query = "INSERT INTO Organizations (Name, ContactInfo, Description) VALUES (@Name, @ContactInfo, @Description)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@ContactInfo", txtContactInfo.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Organization added successfully!");
                LoadOrganizations();
            }

            LoadOrganizations();
            txtName.Clear();
            txtContactInfo.Clear();
            txtDescription.Clear();
        }

        private void btnEditOrganization_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrganizations.CurrentRow != null)
            {
                int organizationId = Convert.ToInt32(dataGridViewOrganizations.CurrentRow.Cells["Id"].Value); // Assuming there's an Id column
                using (SqlConnection conn = new SqlConnection("Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
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
                    LoadOrganizations();
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
                int organizationId = Convert.ToInt32(dataGridViewOrganizations.CurrentRow.Cells["Id"].Value); // Assuming there's an Id column
                using (SqlConnection conn = new SqlConnection("Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    string query = "DELETE FROM Organizations WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", organizationId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Organization deleted successfully!");
                    LoadOrganizations();
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
            this.Hide(); // Hide the donor management form
        }
    }

    }

