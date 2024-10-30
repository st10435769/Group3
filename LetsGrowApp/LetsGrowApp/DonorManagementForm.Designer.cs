namespace LetsGrowApp
{
    partial class DonorManagementForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.btnAddDonor = new System.Windows.Forms.Button();
            this.btnEditDonor = new System.Windows.Forms.Button();
            this.btnDeleteDonor = new System.Windows.Forms.Button();
            this.dataGridViewDonors = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 1;

            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Location = new System.Drawing.Point(34, 82);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(75, 13);
            this.lblContactInfo.TabIndex = 2;
            this.lblContactInfo.Text = "Contact Info:";

            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(138, 79);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(150, 20);
            this.txtContactInfo.TabIndex = 3;

            // 
            // btnAddDonor
            // 
            this.btnAddDonor.Location = new System.Drawing.Point(34, 115);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(75, 23);
            this.btnAddDonor.TabIndex = 4;
            this.btnAddDonor.Text = "Add Donor";
            this.btnAddDonor.UseVisualStyleBackColor = true;
            this.btnAddDonor.Click += new System.EventHandler(this.btnAddDonor_Click);

            // 
            // btnEditDonor
            // 
            this.btnEditDonor.Location = new System.Drawing.Point(138, 115);
            this.btnEditDonor.Name = "btnEditDonor";
            this.btnEditDonor.Size = new System.Drawing.Size(75, 23);
            this.btnEditDonor.TabIndex = 5;
            this.btnEditDonor.Text = "Edit Donor";
            this.btnEditDonor.UseVisualStyleBackColor = true;
            this.btnEditDonor.Click += new System.EventHandler(this.btnEditDonor_Click);

            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.Location = new System.Drawing.Point(243, 115);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDonor.TabIndex = 6;
            this.btnDeleteDonor.Text = "Delete Donor";
            this.btnDeleteDonor.UseVisualStyleBackColor = true;
            this.btnDeleteDonor.Click += new System.EventHandler(this.btnDeleteDonor_Click);

            // 
            // dataGridViewDonors
            // 
            this.dataGridViewDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonors.Location = new System.Drawing.Point(34, 160);
            this.dataGridViewDonors.Name = "dataGridViewDonors";
            this.dataGridViewDonors.Size = new System.Drawing.Size(284, 150);
            this.dataGridViewDonors.TabIndex = 7;

            // 
            // btnBackToMain
            // 
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnBackToMain.Location = new System.Drawing.Point(34, 370);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMain.TabIndex = 10;
            this.btnBackToMain.Text = "Back";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);

            // Add the button to the form's controls
            this.Controls.Add(this.btnBackToMain);
            // 
            // DonorManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 320);
            this.Controls.Add(this.dataGridViewDonors);
            this.Controls.Add(this.btnDeleteDonor);
            this.Controls.Add(this.btnEditDonor);
            this.Controls.Add(this.btnAddDonor);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "DonorManagementForm";
            this.Text = "Manage Donors";
            this.Load += new System.EventHandler(this.DonorManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.Button btnAddDonor;
        private System.Windows.Forms.Button btnEditDonor;
        private System.Windows.Forms.Button btnDeleteDonor;
        private System.Windows.Forms.DataGridView dataGridViewDonors;
        private System.Windows.Forms.Button btnBackToMain;
    }
}
