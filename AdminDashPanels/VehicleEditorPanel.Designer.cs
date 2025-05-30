namespace VehicleMaintenanceSystem.Database_Editors
{
    partial class VehicleEditorPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            btnAddVehicle = new Button();
            btnSearchByUser = new Button();
            dataGridVehicles = new DataGridView();
            btnDeleteVehicle = new Button();
            btnEditVehicle = new Button();
            btnSearchbyVehicleName = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridVehicles).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(584, 23);
            txtSearch.TabIndex = 12;
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Location = new Point(602, 14);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(82, 25);
            btnAddVehicle.TabIndex = 11;
            btnAddVehicle.Text = "Add";
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // btnSearchByUser
            // 
            btnSearchByUser.Location = new Point(12, 40);
            btnSearchByUser.Name = "btnSearchByUser";
            btnSearchByUser.Size = new Size(100, 25);
            btnSearchByUser.TabIndex = 10;
            btnSearchByUser.Text = "Search by user";
            btnSearchByUser.UseVisualStyleBackColor = true;
            btnSearchByUser.Click += btnSearchByUser_Click;
            // 
            // dataGridVehicles
            // 
            dataGridVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVehicles.Location = new Point(12, 77);
            dataGridVehicles.Name = "dataGridVehicles";
            dataGridVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVehicles.Size = new Size(760, 331);
            dataGridVehicles.TabIndex = 9;
            // 
            // btnDeleteVehicle
            // 
            btnDeleteVehicle.Location = new Point(644, 41);
            btnDeleteVehicle.Name = "btnDeleteVehicle";
            btnDeleteVehicle.Size = new Size(82, 24);
            btnDeleteVehicle.TabIndex = 8;
            btnDeleteVehicle.Text = "Delete";
            btnDeleteVehicle.UseVisualStyleBackColor = true;
            btnDeleteVehicle.Click += btnDeleteVehicle_Click;
            // 
            // btnEditVehicle
            // 
            btnEditVehicle.Location = new Point(690, 14);
            btnEditVehicle.Name = "btnEditVehicle";
            btnEditVehicle.Size = new Size(82, 25);
            btnEditVehicle.TabIndex = 7;
            btnEditVehicle.Text = "Edit";
            btnEditVehicle.UseVisualStyleBackColor = true;
            btnEditVehicle.Click += btnEditVehicle_Click;
            // 
            // btnSearchbyVehicleName
            // 
            btnSearchbyVehicleName.Location = new Point(118, 40);
            btnSearchbyVehicleName.Name = "btnSearchbyVehicleName";
            btnSearchbyVehicleName.Size = new Size(147, 25);
            btnSearchbyVehicleName.TabIndex = 13;
            btnSearchbyVehicleName.Text = "Search by Vehicle name";
            btnSearchbyVehicleName.UseVisualStyleBackColor = true;
            btnSearchbyVehicleName.Click += btnSearchbyVehicleName_Click;
            // 
            // VehicleEditorPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(btnSearchbyVehicleName);
            Controls.Add(txtSearch);
            Controls.Add(btnAddVehicle);
            Controls.Add(btnSearchByUser);
            Controls.Add(dataGridVehicles);
            Controls.Add(btnDeleteVehicle);
            Controls.Add(btnEditVehicle);
            Name = "VehicleEditorPanel";
            Text = "VehicleEditorPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridVehicles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnAddVehicle;
        private Button btnSearchByUser;
        private DataGridView dataGridVehicles;
        private Button btnDeleteVehicle;
        private Button btnEditVehicle;
        private Button btnSearchbyVehicleName;
    }
}