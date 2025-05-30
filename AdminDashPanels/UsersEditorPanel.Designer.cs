namespace VehicleMaintenanceSystem
{
    partial class UsersEditorPanel
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
            btnEdit = new Button();
            btnDelete = new Button();
            dataGridUsers = new DataGridView();
            btnSearch = new Button();
            btnAddUser = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(602, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 25);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(690, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 24);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridUsers
            // 
            dataGridUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.Location = new Point(12, 49);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUsers.Size = new Size(760, 350);
            dataGridUsers.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(100, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 25);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(12, 12);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(82, 25);
            btnAddUser.TabIndex = 5;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(188, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(395, 23);
            txtSearch.TabIndex = 6;
            // 
            // UsersEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(txtSearch);
            Controls.Add(btnAddUser);
            Controls.Add(btnSearch);
            Controls.Add(dataGridUsers);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Name = "UsersEditor";
            Text = "AdminDashSubUsers";
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridUsers;
        private Button btnSearch;
        private Button btnAddUser;
        private TextBox txtSearch;
    }
}