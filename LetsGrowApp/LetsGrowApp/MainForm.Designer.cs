using System.Windows.Forms;

namespace LetsGrowApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnDonors = new System.Windows.Forms.Button();
            this.btnOrganizations = new System.Windows.Forms.Button();
            this.btnFarmProducts = new System.Windows.Forms.Button();
            this.btnDonations = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDonors
            // 
            this.btnDonors.BackColor = System.Drawing.Color.LightGreen;
            this.btnDonors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonors.ForeColor = System.Drawing.Color.White;
            this.btnDonors.Location = new System.Drawing.Point(90, 32);
            this.btnDonors.Name = "btnDonors";
            this.btnDonors.Size = new System.Drawing.Size(200, 60);
            this.btnDonors.TabIndex = 0;
            this.btnDonors.Text = "Donors";
            this.btnDonors.UseVisualStyleBackColor = false;
            this.btnDonors.Click += new System.EventHandler(this.btnDonors_Click);
            // 
            // btnOrganizations
            // 
            this.btnOrganizations.BackColor = System.Drawing.Color.LightGreen;
            this.btnOrganizations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganizations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizations.ForeColor = System.Drawing.Color.White;
            this.btnOrganizations.Location = new System.Drawing.Point(90, 96);
            this.btnOrganizations.Name = "btnOrganizations";
            this.btnOrganizations.Size = new System.Drawing.Size(200, 60);
            this.btnOrganizations.TabIndex = 1;
            this.btnOrganizations.Text = "Organizations";
            this.btnOrganizations.UseVisualStyleBackColor = false;
            this.btnOrganizations.Click += new System.EventHandler(this.btnOrganizations_Click);
            // 
            // btnFarmProducts
            // 
            this.btnFarmProducts.BackColor = System.Drawing.Color.LightGreen;
            this.btnFarmProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFarmProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarmProducts.ForeColor = System.Drawing.Color.White;
            this.btnFarmProducts.Location = new System.Drawing.Point(90, 160);
            this.btnFarmProducts.Name = "btnFarmProducts";
            this.btnFarmProducts.Size = new System.Drawing.Size(200, 60);
            this.btnFarmProducts.TabIndex = 2;
            this.btnFarmProducts.Text = "Farm Products";
            this.btnFarmProducts.UseVisualStyleBackColor = false;
            this.btnFarmProducts.Click += new System.EventHandler(this.btnFarmProducts_Click);
            // 
            // btnDonations
            // 
            this.btnDonations.BackColor = System.Drawing.Color.LightGreen;
            this.btnDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonations.ForeColor = System.Drawing.Color.White;
            this.btnDonations.Location = new System.Drawing.Point(90, 224);
            this.btnDonations.Name = "btnDonations";
            this.btnDonations.Size = new System.Drawing.Size(200, 60);
            this.btnDonations.TabIndex = 3;
            this.btnDonations.Text = "Donations";
            this.btnDonations.UseVisualStyleBackColor = false;
            this.btnDonations.Click += new System.EventHandler(this.btnDonations_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(90, 300);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(200, 53);
            this.btnBackToMain.TabIndex = 4;
            this.btnBackToMain.Text = "Log Out";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 417);
            this.Controls.Add(this.btnDonations);
            this.Controls.Add(this.btnFarmProducts);
            this.Controls.Add(this.btnOrganizations);
            this.Controls.Add(this.btnDonors);
            this.Controls.Add(this.btnBackToMain);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Button btnDonors;
        private System.Windows.Forms.Button btnOrganizations;
        private System.Windows.Forms.Button btnFarmProducts;
        private System.Windows.Forms.Button btnDonations;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBackToMain;
    }
}
