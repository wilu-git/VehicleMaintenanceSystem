namespace VehicleMaintenanceSystem
{
    partial class EntryPoint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            btnLogin = new Button();
            labeldonthaveaccount = new Label();
            btnSignup = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 36);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "VMS LOGO";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(65, 124);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(63, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(214, 23);
            txtPassword.TabIndex = 2;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(65, 106);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(37, 15);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(63, 196);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(129, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // labeldonthaveaccount
            // 
            labeldonthaveaccount.AutoSize = true;
            labeldonthaveaccount.Location = new Point(65, 262);
            labeldonthaveaccount.Name = "labeldonthaveaccount";
            labeldonthaveaccount.Size = new Size(131, 15);
            labeldonthaveaccount.TabIndex = 6;
            labeldonthaveaccount.Text = "Don't have an account?";
            // 
            // btnSignup
            // 
            btnSignup.AutoSize = true;
            btnSignup.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.CornflowerBlue;
            btnSignup.Location = new Point(202, 262);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(73, 15);
            btnSignup.TabIndex = 7;
            btnSignup.Text = "Sign up here";
            btnSignup.Click += labelSignup_Click;
            // 
            // EntryPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(334, 411);
            Controls.Add(btnSignup);
            Controls.Add(labeldonthaveaccount);
            Controls.Add(btnLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "EntryPoint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMC VMS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label labelLogin;
        private Label labelPassword;
        private Button btnLogin;
        private Label labeldonthaveaccount;
        private Label btnSignup;
    }
}
