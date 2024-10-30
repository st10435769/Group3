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
            this.SuspendLayout();
            // 
            // btnDonors
            // 
            this.btnDonors.Location = new System.Drawing.Point(34, 30);
            this.btnDonors.Name = "btnDonors";
            this.btnDonors.Size = new System.Drawing.Size(75, 23);
            this.btnDonors.TabIndex = 0;
            this.btnDonors.Text = "Donors";
            this.btnDonors.UseVisualStyleBackColor = true;
            this.btnDonors.Click += new System.EventHandler(this.btnDonors_Click);
            // 
            // btnOrganizations
            // 
            this.btnOrganizations.Location = new System.Drawing.Point(34, 70);
            this.btnOrganizations.Name = "btnOrganizations";
            this.btnOrganizations.Size = new System.Drawing.Size(75, 23);
            this.btnOrganizations.TabIndex = 1;
            this.btnOrganizations.Text = "Organizations";
            this.btnOrganizations.UseVisualStyleBackColor = true;
            this.btnOrganizations.Click += new System.EventHandler(this.btnOrganizations_Click);
            // 
            // btnFarmProducts
            // 
            this.btnFarmProducts.Location = new System.Drawing.Point(34, 110);
            this.btnFarmProducts.Name = "btnFarmProducts";
            this.btnFarmProducts.Size = new System.Drawing.Size(75, 23);
            this.btnFarmProducts.TabIndex = 2;
            this.btnFarmProducts.Text = "Farm Products";
            this.btnFarmProducts.UseVisualStyleBackColor = true;
            this.btnFarmProducts.Click += new System.EventHandler(this.btnFarmProducts_Click);
            // 
            // btnDonations
            // 
            this.btnDonations.Location = new System.Drawing.Point(34, 150);
            this.btnDonations.Name = "btnDonations";
            this.btnDonations.Size = new System.Drawing.Size(75, 23);
            this.btnDonations.TabIndex = 3;
            this.btnDonations.Text = "Donations";
            this.btnDonations.UseVisualStyleBackColor = true;
            this.btnDonations.Click += new System.EventHandler(this.btnDonations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 428);
            this.Controls.Add(this.btnDonations);
            this.Controls.Add(this.btnFarmProducts);
            this.Controls.Add(this.btnOrganizations);
            this.Controls.Add(this.btnDonors);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnDonors;
        private System.Windows.Forms.Button btnOrganizations;
        private System.Windows.Forms.Button btnFarmProducts;
        private System.Windows.Forms.Button btnDonations;
    }
}
