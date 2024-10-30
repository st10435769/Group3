namespace LetsGrowApp
{
    partial class DonationsManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddDonation;
        private System.Windows.Forms.Button btnEditDonation;
        private System.Windows.Forms.Button btnDeleteDonation;
        private System.Windows.Forms.DataGridView dgvDonations;
        private System.Windows.Forms.TextBox txtDonationID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDonorID;
        private System.Windows.Forms.TextBox txtOrganizationID;
        private System.Windows.Forms.Label lblDonationID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDonorID;
        private System.Windows.Forms.Label lblOrganizationID;

        private void InitializeComponent()
        {
            this.btnAddDonation = new System.Windows.Forms.Button();
            this.btnEditDonation = new System.Windows.Forms.Button();
            this.btnDeleteDonation = new System.Windows.Forms.Button();
            this.dgvDonations = new System.Windows.Forms.DataGridView();
            this.txtDonationID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDonorID = new System.Windows.Forms.TextBox();
            this.txtOrganizationID = new System.Windows.Forms.TextBox();
            this.lblDonationID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDonorID = new System.Windows.Forms.Label();
            this.lblOrganizationID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDonation
            // 
            this.btnAddDonation.Location = new System.Drawing.Point(12, 350);
            this.btnAddDonation.Name = "btnAddDonation";
            this.btnAddDonation.Size = new System.Drawing.Size(75, 23);
            this.btnAddDonation.TabIndex = 0;
            this.btnAddDonation.Text = "Add";
            this.btnAddDonation.UseVisualStyleBackColor = true;
            this.btnAddDonation.Click += new System.EventHandler(this.btnAddDonation_Click);
            // 
            // btnEditDonation
            // 
            this.btnEditDonation.Location = new System.Drawing.Point(110, 350);
            this.btnEditDonation.Name = "btnEditDonation";
            this.btnEditDonation.Size = new System.Drawing.Size(75, 23);
            this.btnEditDonation.TabIndex = 1;
            this.btnEditDonation.Text = "Edit";
            this.btnEditDonation.UseVisualStyleBackColor = true;
            this.btnEditDonation.Click += new System.EventHandler(this.btnEditDonation_Click);
            // 
            // btnDeleteDonation
            // 
            this.btnDeleteDonation.Location = new System.Drawing.Point(210, 350);
            this.btnDeleteDonation.Name = "btnDeleteDonation";
            this.btnDeleteDonation.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDonation.TabIndex = 2;
            this.btnDeleteDonation.Text = "Delete";
            this.btnDeleteDonation.UseVisualStyleBackColor = true;
            this.btnDeleteDonation.Click += new System.EventHandler(this.btnDeleteDonation_Click);
            // 
            // dgvDonations
            // 
            this.dgvDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonations.Location = new System.Drawing.Point(12, 12);
            this.dgvDonations.Name = "dgvDonations";
            this.dgvDonations.Size = new System.Drawing.Size(500, 150);
            this.dgvDonations.TabIndex = 3;
            this.dgvDonations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonations_CellClick);
            // 
            // txtDonationID
            // 
            this.txtDonationID.Location = new System.Drawing.Point(90, 180);
            this.txtDonationID.Name = "txtDonationID";
            this.txtDonationID.Size = new System.Drawing.Size(100, 20);
            this.txtDonationID.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(90, 210);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(90, 240);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // txtDonorID
            // 
            this.txtDonorID.Location = new System.Drawing.Point(90, 270);
            this.txtDonorID.Name = "txtDonorID";
            this.txtDonorID.Size = new System.Drawing.Size(100, 20);
            this.txtDonorID.TabIndex = 7;
            // 
            // txtOrganizationID
            // 
            this.txtOrganizationID.Location = new System.Drawing.Point(90, 300);
            this.txtOrganizationID.Name = "txtOrganizationID";
            this.txtOrganizationID.Size = new System.Drawing.Size(100, 20);
            this.txtOrganizationID.TabIndex = 8;
            // 
            // lblDonationID
            // 
            this.lblDonationID.AutoSize = true;
            this.lblDonationID.Location = new System.Drawing.Point(10, 180);
            this.lblDonationID.Name = "lblDonationID";
            this.lblDonationID.Size = new System.Drawing.Size(64, 13);
            this.lblDonationID.TabIndex = 9;
            this.lblDonationID.Text = "Donation ID";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(10, 210);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 240);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date";
            // 
            // lblDonorID
            // 
            this.lblDonorID.AutoSize = true;
            this.lblDonorID.Location = new System.Drawing.Point(10, 270);
            this.lblDonorID.Name = "lblDonorID";
            this.lblDonorID.Size = new System.Drawing.Size(50, 13);
            this.lblDonorID.TabIndex = 12;
            this.lblDonorID.Text = "Donor ID";
            // 
            // lblOrganizationID
            // 
            this.lblOrganizationID.AutoSize = true;
            this.lblOrganizationID.Location = new System.Drawing.Point(10, 300);
            this.lblOrganizationID.Name = "lblOrganizationID";
            this.lblOrganizationID.Size = new System.Drawing.Size(80, 13);
            this.lblOrganizationID.TabIndex = 13;
            this.lblOrganizationID.Text = "Organization ID";
            // 
            // DonationsManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(639, 484);
            this.Controls.Add(this.lblOrganizationID);
            this.Controls.Add(this.lblDonorID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDonationID);
            this.Controls.Add(this.txtOrganizationID);
            this.Controls.Add(this.txtDonorID);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDonationID);
            this.Controls.Add(this.dgvDonations);
            this.Controls.Add(this.btnDeleteDonation);
            this.Controls.Add(this.btnEditDonation);
            this.Controls.Add(this.btnAddDonation);
            this.Name = "DonationsManagementForm";
            this.Text = "Manage Donations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
