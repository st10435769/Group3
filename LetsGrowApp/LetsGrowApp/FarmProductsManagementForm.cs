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
    public partial class FarmProductsManagementForm : Form
    {
        public FarmProductsManagementForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection("Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FarmProducts", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            int quantity;
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                using (SqlConnection conn = new SqlConnection("Server=tcp:assigning.database.windows.net,1433;Initial Catalog=Ndivhuwo;Persist Security Info=False;User ID=admin1;Password=Ndibs@1305;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    string query = "INSERT INTO FarmProducts (ProductName, Quantity) VALUES (@ProductName, @Quantity)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadProducts();
                txtProductName.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide(); // Hide the farm products management form
        }
    }


}

