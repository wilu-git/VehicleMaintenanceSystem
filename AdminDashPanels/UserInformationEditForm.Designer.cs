namespace VehicleMaintenanceSystem.Database_Editors
{
    partial class UserInformationEditForm
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
            btnUpdate = new Button();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            labelFirstName = new Label();
            txtFirstName = new TextBox();
            labelID = new Label();
            txtID = new TextBox();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(48, 427);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 54);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 331);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 26;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(108, 328);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 23);
            txtPassword.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 277);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 24;
            label4.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(108, 277);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 23);
            txtUsername.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 226);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 22;
            label3.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(108, 223);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(249, 23);
            txtPhoneNumber.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 182);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 20;
            label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(108, 179);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(249, 23);
            txtLastName.TabIndex = 19;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(14, 129);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(64, 15);
            labelFirstName.TabIndex = 18;
            labelFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(108, 129);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(249, 23);
            txtFirstName.TabIndex = 17;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(18, 77);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 15);
            labelID.TabIndex = 16;
            labelID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(108, 77);
            txtID.Name = "txtID";
            txtID.Size = new Size(249, 23);
            txtID.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(225, 427);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 54);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 23);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 32;
            label1.Text = "User Information Edit";
            // 
            // UserInformationEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(txtID);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(labelFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(labelID);
            Name = "UserInformationEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserInformationEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label5;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label2;
        private TextBox txtLastName;
        private Label labelFirstName;
        private TextBox txtFirstName;
        private Label labelID;
        private TextBox txtID;
        private Button btnCancel;
        private Label label1;
    }
}