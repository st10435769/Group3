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
        private System.Windows.Forms.Button btnBack;

        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 41);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddDonation
            // 
            this.btnAddDonation.Location = new System.Drawing.Point(300, 240);
            this.btnAddDonation.Name = "btnAddDonation";
            this.btnAddDonation.Size = new System.Drawing.Size(100, 30);
            this.btnAddDonation.TabIndex = 10;
            this.btnAddDonation.Text = "Add Donation";
            this.btnAddDonation.UseVisualStyleBackColor = true;
            this.btnAddDonation.Click += new System.EventHandler(this.btnAddDonation_Click);
            // 
            // btnEditDonation
            // 
            this.btnEditDonation.Location = new System.Drawing.Point(300, 280);
            this.btnEditDonation.Name = "btnEditDonation";
            this.btnEditDonation.Size = new System.Drawing.Size(100, 30);
            this.btnEditDonation.TabIndex = 11;
            this.btnEditDonation.Text = "Edit Donation";
            this.btnEditDonation.UseVisualStyleBackColor = true;
            this.btnEditDonation.Click += new System.EventHandler(this.btnEditDonation_Click);
            // 
            // btnDeleteDonation
            // 
            this.btnDeleteDonation.Location = new System.Drawing.Point(300, 320);
            this.btnDeleteDonation.Name = "btnDeleteDonation";
            this.btnDeleteDonation.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteDonation.TabIndex = 12;
            this.btnDeleteDonation.Text = "Delete Donation";
            this.btnDeleteDonation.UseVisualStyleBackColor = true;
            this.btnDeleteDonation.Click += new System.EventHandler(this.btnDeleteDonation_Click);
            // 
            // dgvDonations
            // 
            this.dgvDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonations.Location = new System.Drawing.Point(12, 50);
            this.dgvDonations.Name = "dgvDonations";
            this.dgvDonations.RowHeadersWidth = 51;
            this.dgvDonations.Size = new System.Drawing.Size(560, 150);
            this.dgvDonations.TabIndex = 1;
            this.dgvDonations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonations_CellClick);
            // 
            // txtDonationID
            // 
            this.txtDonationID.Location = new System.Drawing.Point(120, 210);
            this.txtDonationID.Name = "txtDonationID";
            this.txtDonationID.Size = new System.Drawing.Size(150, 22);
            this.txtDonationID.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(120, 240);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 22);
            this.txtAmount.TabIndex = 14;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(120, 270);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(150, 22);
            this.dtpDate.TabIndex = 16;
            // 
            // txtDonorID
            // 
            this.txtDonorID.Location = new System.Drawing.Point(120, 300);
            this.txtDonorID.Name = "txtDonorID";
            this.txtDonorID.Size = new System.Drawing.Size(150, 22);
            this.txtDonorID.TabIndex = 18;
            // 
            // txtOrganizationID
            // 
            this.txtOrganizationID.Location = new System.Drawing.Point(120, 330);
            this.txtOrganizationID.Name = "txtOrganizationID";
            this.txtOrganizationID.Size = new System.Drawing.Size(150, 22);
            this.txtOrganizationID.TabIndex = 20;
            // 
            // lblDonationID
            // 
            this.lblDonationID.Location = new System.Drawing.Point(20, 210);
            this.lblDonationID.Name = "lblDonationID";
            this.lblDonationID.Size = new System.Drawing.Size(80, 20);
            this.lblDonationID.TabIndex = 0;
            this.lblDonationID.Text = "Donation ID:";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(20, 240);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(80, 20);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Amount:";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(20, 270);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 20);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date:";
            // 
            // lblDonorID
            // 
            this.lblDonorID.Location = new System.Drawing.Point(20, 300);
            this.lblDonorID.Name = "lblDonorID";
            this.lblDonorID.Size = new System.Drawing.Size(80, 20);
            this.lblDonorID.TabIndex = 17;
            this.lblDonorID.Text = "Donor ID:";
            // 
            // lblOrganizationID
            // 
            this.lblOrganizationID.Location = new System.Drawing.Point(20, 330);
            this.lblOrganizationID.Name = "lblOrganizationID";
            this.lblOrganizationID.Size = new System.Drawing.Size(100, 20);
            this.lblOrganizationID.TabIndex = 19;
            this.lblOrganizationID.Text = "Organization ID:";
            // 
            // DonationsManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddDonation);
            this.Controls.Add(this.btnEditDonation);
            this.Controls.Add(this.btnDeleteDonation);
            this.Controls.Add(this.dgvDonations);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDonorID);
            this.Controls.Add(this.txtDonorID);
            this.Controls.Add(this.lblOrganizationID);
            this.Controls.Add(this.txtOrganizationID);
            this.Name = "DonationsManagementForm";
            this.Text = "Manage Donations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
