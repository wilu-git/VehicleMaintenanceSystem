namespace VehicleMaintenanceSystem
{
    partial class UserDashboard
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
            btnAddVehicle = new Button();
            btnViewVehicle = new Button();
            btnRequestMaintenance = new Button();
            btnViewVehicles = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Location = new Point(235, 176);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(90, 82);
            btnAddVehicle.TabIndex = 3;
            btnAddVehicle.Text = "Add Vehicle";
            btnAddVehicle.UseVisualStyleBackColor = true;
            // 
            // btnViewVehicle
            // 
            btnViewVehicle.Location = new Point(12, 134);
            btnViewVehicle.Name = "btnViewVehicle";
            btnViewVehicle.Size = new Size(90, 82);
            btnViewVehicle.TabIndex = 4;
            btnViewVehicle.Text = "View History";
            btnViewVehicle.UseVisualStyleBackColor = true;
            // 
            // btnRequestMaintenance
            // 
            btnRequestMaintenance.Location = new Point(12, 239);
            btnRequestMaintenance.Name = "btnRequestMaintenance";
            btnRequestMaintenance.Size = new Size(90, 82);
            btnRequestMaintenance.TabIndex = 5;
            btnRequestMaintenance.Text = "Request Maintenance";
            btnRequestMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnViewVehicles
            // 
            btnViewVehicles.Location = new Point(12, 347);
            btnViewVehicles.Name = "btnViewVehicles";
            btnViewVehicles.Size = new Size(90, 82);
            btnViewVehicles.TabIndex = 6;
            btnViewVehicles.Text = "View Vehicles";
            btnViewVehicles.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 22);
            button1.Name = "button1";
            button1.Size = new Size(90, 82);
            button1.TabIndex = 7;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnViewVehicles);
            Controls.Add(btnRequestMaintenance);
            Controls.Add(btnViewVehicle);
            Controls.Add(btnAddVehicle);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddVehicle;
        private Button btnViewVehicle;
        private Button btnRequestMaintenance;
        private Button btnViewVehicles;
        private Button button1;
    }
}