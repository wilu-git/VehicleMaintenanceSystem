namespace VehicleMaintenanceSystem
{
    partial class UserDash
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
            btnMaintenanceHistory = new Button();
            btnScheduleMaintenance = new Button();
            btnViewVehicles = new Button();
            btnHome = new Button();
            panelButtons = new Panel();
            btnAccountSettings = new Button();
            panelContainer = new Panel();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // btnMaintenanceHistory
            // 
            btnMaintenanceHistory.Location = new Point(21, 272);
            btnMaintenanceHistory.Name = "btnMaintenanceHistory";
            btnMaintenanceHistory.Size = new Size(161, 55);
            btnMaintenanceHistory.TabIndex = 4;
            btnMaintenanceHistory.Text = "Maintenance History";
            btnMaintenanceHistory.UseVisualStyleBackColor = true;
            // 
            // btnScheduleMaintenance
            // 
            btnScheduleMaintenance.Location = new Point(21, 186);
            btnScheduleMaintenance.Name = "btnScheduleMaintenance";
            btnScheduleMaintenance.Size = new Size(161, 55);
            btnScheduleMaintenance.TabIndex = 5;
            btnScheduleMaintenance.Text = "Schedule Maintenance";
            btnScheduleMaintenance.UseVisualStyleBackColor = true;
            btnScheduleMaintenance.Click += btnScheduleMaintenance_Click;
            // 
            // btnViewVehicles
            // 
            btnViewVehicles.Location = new Point(21, 106);
            btnViewVehicles.Name = "btnViewVehicles";
            btnViewVehicles.Size = new Size(161, 55);
            btnViewVehicles.TabIndex = 6;
            btnViewVehicles.Text = "View Vehicles";
            btnViewVehicles.UseVisualStyleBackColor = true;
            btnViewVehicles.Click += btnViewVehicles_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(21, 25);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(161, 55);
            btnHome.TabIndex = 7;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnAccountSettings);
            panelButtons.Controls.Add(btnHome);
            panelButtons.Controls.Add(btnScheduleMaintenance);
            panelButtons.Controls.Add(btnViewVehicles);
            panelButtons.Controls.Add(btnMaintenanceHistory);
            panelButtons.Dock = DockStyle.Left;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(200, 461);
            panelButtons.TabIndex = 8;
            // 
            // btnAccountSettings
            // 
            btnAccountSettings.Location = new Point(21, 357);
            btnAccountSettings.Name = "btnAccountSettings";
            btnAccountSettings.Size = new Size(161, 55);
            btnAccountSettings.TabIndex = 8;
            btnAccountSettings.Text = "Account Settings";
            btnAccountSettings.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(200, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(784, 461);
            panelContainer.TabIndex = 9;
            // 
            // UserDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(panelContainer);
            Controls.Add(panelButtons);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "UserDash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboard";
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnMaintenanceHistory;
        private Button btnScheduleMaintenance;
        private Button btnViewVehicles;
        private Button btnHome;
        private Panel panelButtons;
        private Button btnAccountSettings;
        private Panel panelContainer;
    }
}