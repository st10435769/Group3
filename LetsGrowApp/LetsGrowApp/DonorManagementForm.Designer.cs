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
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 47);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 43);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Location = new System.Drawing.Point(45, 101);
            this.lblContactInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(79, 16);
            this.lblContactInfo.TabIndex = 2;
            this.lblContactInfo.Text = "Contact Info:";
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(184, 97);
            this.txtContactInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(199, 22);
            this.txtContactInfo.TabIndex = 3;
            // 
            // btnAddDonor
            // 
            this.btnAddDonor.Location = new System.Drawing.Point(45, 142);
            this.btnAddDonor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(100, 28);
            this.btnAddDonor.TabIndex = 4;
            this.btnAddDonor.Text = "Add Donor";
            this.btnAddDonor.UseVisualStyleBackColor = true;
            this.btnAddDonor.Click += new System.EventHandler(this.btnAddDonor_Click);
            // 
            // btnEditDonor
            // 
            this.btnEditDonor.Location = new System.Drawing.Point(184, 142);
            this.btnEditDonor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditDonor.Name = "btnEditDonor";
            this.btnEditDonor.Size = new System.Drawing.Size(100, 28);
            this.btnEditDonor.TabIndex = 5;
            this.btnEditDonor.Text = "Edit Donor";
            this.btnEditDonor.UseVisualStyleBackColor = true;
            this.btnEditDonor.Click += new System.EventHandler(this.btnEditDonor_Click);
            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.Location = new System.Drawing.Point(324, 142);
            this.btnDeleteDonor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteDonor.TabIndex = 6;
            this.btnDeleteDonor.Text = "Delete Donor";
            this.btnDeleteDonor.UseVisualStyleBackColor = true;
            this.btnDeleteDonor.Click += new System.EventHandler(this.btnDeleteDonor_Click);
            // 
            // dataGridViewDonors
            // 
            this.dataGridViewDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonors.Location = new System.Drawing.Point(45, 197);
            this.dataGridViewDonors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDonors.Name = "dataGridViewDonors";
            this.dataGridViewDonors.RowHeadersWidth = 51;
            this.dataGridViewDonors.Size = new System.Drawing.Size(747, 246);
            this.dataGridViewDonors.TabIndex = 7;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(13, 463);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(118, 41);
            this.btnBackToMain.TabIndex = 8;
            this.btnBackToMain.Text = "Back";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // DonorManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.dataGridViewDonors);
            this.Controls.Add(this.btnDeleteDonor);
            this.Controls.Add(this.btnEditDonor);
            this.Controls.Add(this.btnAddDonor);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DonorManagementForm";
            this.Text = "Manage Donors";
            this.Load += new System.EventHandler(this.DonorManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonors)).EndInit();
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
