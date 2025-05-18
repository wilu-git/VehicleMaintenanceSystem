namespace VehicleMaintenanceSystem
{
    partial class Signup
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
            label1 = new Label();
            txtFirstName = new TextBox();
            labelFirstName = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            label7 = new Label();
            btnSignin = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 26);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Create New Account";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(62, 78);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(249, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.KeyPress += NameTextBox_KeyPress;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(62, 60);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(64, 15);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 110);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(62, 128);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(249, 23);
            txtLastName.TabIndex = 3;
            txtLastName.KeyPress += NameTextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 154);
            label3.Name = "label3";
            label3.Size = new Size(202, 15);
            label3.TabIndex = 6;
            label3.Text = "Phone Number (Format: 09*******53)";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(62, 172);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(249, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 216);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(62, 234);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 23);
            txtUsername.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 276);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(62, 294);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 23);
            txtPassword.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 332);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 12;
            label6.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(62, 350);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(249, 23);
            txtConfirmPassword.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(125, 445);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 54);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(46, 402);
            label7.Name = "label7";
            label7.Size = new Size(186, 21);
            label7.TabIndex = 14;
            label7.Text = "Already have an account?";
            // 
            // btnSignin
            // 
            btnSignin.AutoSize = true;
            btnSignin.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSignin.ForeColor = Color.DeepSkyBlue;
            btnSignin.Location = new Point(228, 402);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(93, 21);
            btnSignin.TabIndex = 15;
            btnSignin.Text = "Sign in here";
            btnSignin.Click += buttonSignin_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(384, 561);
            Controls.Add(btnSignin);
            Controls.Add(label7);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(txtConfirmPassword);
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
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Signup";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            Load += Signup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label labelFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label4;
        private TextBox txtUsername;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Label label7;
        private Label btnSignin;
    }
}