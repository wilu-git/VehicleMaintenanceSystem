namespace VehicleMaintenanceSystem.Database_Editors
{
    partial class VehicleInformationEditForm
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
            btnCancel = new Button();
            txtVehicleID = new TextBox();
            btnUpdate = new Button();
            labelColor = new Label();
            txtColor = new TextBox();
            labelYear = new Label();
            txtYear = new TextBox();
            label3 = new Label();
            txtModel = new TextBox();
            label2 = new Label();
            txtMake = new TextBox();
            labelVIN = new Label();
            txtVIN = new TextBox();
            labelID = new Label();
            label4 = new Label();
            txtRegistrationNumber = new TextBox();
            label5 = new Label();
            txtEngineConfiguration = new TextBox();
            labelVehicleType = new Label();
            txtVehicleType = new TextBox();
            labelWheelDriveType = new Label();
            txtWheelDriveType = new TextBox();
            labelFuelType = new Label();
            txtFuelType = new TextBox();
            label6 = new Label();
            txtMileage = new TextBox();
            labelUID = new Label();
            txtUserID = new TextBox();
            label7 = new Label();
            txtTransmissionType = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 28);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 47;
            label1.Text = "Vehicle Information Edit";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(248, 570);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 39);
            btnCancel.TabIndex = 46;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtVehicleID
            // 
            txtVehicleID.Enabled = false;
            txtVehicleID.Location = new Point(135, 65);
            txtVehicleID.Name = "txtVehicleID";
            txtVehicleID.Size = new Size(249, 23);
            txtVehicleID.TabIndex = 45;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(135, 570);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 39);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(39, 281);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(36, 15);
            labelColor.TabIndex = 43;
            labelColor.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(135, 281);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(249, 23);
            txtColor.TabIndex = 42;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(39, 247);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(29, 15);
            labelYear.TabIndex = 41;
            labelYear.Text = "Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(135, 244);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(249, 23);
            txtYear.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 215);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 39;
            label3.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(135, 212);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(249, 23);
            txtModel.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 178);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 37;
            label2.Text = "Make";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(135, 175);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(249, 23);
            txtMake.TabIndex = 36;
            // 
            // labelVIN
            // 
            labelVIN.AutoSize = true;
            labelVIN.Location = new Point(39, 140);
            labelVIN.Name = "labelVIN";
            labelVIN.Size = new Size(26, 15);
            labelVIN.TabIndex = 35;
            labelVIN.Text = "VIN";
            labelVIN.UseMnemonic = false;
            // 
            // txtVIN
            // 
            txtVIN.Location = new Point(135, 137);
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(249, 23);
            txtVIN.TabIndex = 34;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(39, 68);
            labelID.Name = "labelID";
            labelID.Size = new Size(58, 15);
            labelID.TabIndex = 33;
            labelID.Text = "Vehicle ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 503);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 57;
            label4.Text = "Registration #";
            // 
            // txtRegistrationNumber
            // 
            txtRegistrationNumber.Location = new Point(135, 500);
            txtRegistrationNumber.Name = "txtRegistrationNumber";
            txtRegistrationNumber.Size = new Size(249, 23);
            txtRegistrationNumber.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 463);
            label5.Name = "label5";
            label5.Size = new Size(81, 30);
            label5.TabIndex = 55;
            label5.Text = "Engine \r\nConfiguration";
            // 
            // txtEngineConfiguration
            // 
            txtEngineConfiguration.Location = new Point(135, 463);
            txtEngineConfiguration.Name = "txtEngineConfiguration";
            txtEngineConfiguration.Size = new Size(249, 23);
            txtEngineConfiguration.TabIndex = 54;
            // 
            // labelVehicleType
            // 
            labelVehicleType.AutoSize = true;
            labelVehicleType.Location = new Point(39, 396);
            labelVehicleType.Name = "labelVehicleType";
            labelVehicleType.Size = new Size(71, 15);
            labelVehicleType.TabIndex = 53;
            labelVehicleType.Text = "Vehicle Type";
            // 
            // txtVehicleType
            // 
            txtVehicleType.Location = new Point(135, 396);
            txtVehicleType.Name = "txtVehicleType";
            txtVehicleType.Size = new Size(249, 23);
            txtVehicleType.TabIndex = 52;
            // 
            // labelWheelDriveType
            // 
            labelWheelDriveType.AutoSize = true;
            labelWheelDriveType.Location = new Point(39, 359);
            labelWheelDriveType.Name = "labelWheelDriveType";
            labelWheelDriveType.Size = new Size(70, 15);
            labelWheelDriveType.TabIndex = 51;
            labelWheelDriveType.Text = "Wheel Drive";
            // 
            // txtWheelDriveType
            // 
            txtWheelDriveType.Location = new Point(135, 359);
            txtWheelDriveType.Name = "txtWheelDriveType";
            txtWheelDriveType.Size = new Size(249, 23);
            txtWheelDriveType.TabIndex = 50;
            // 
            // labelFuelType
            // 
            labelFuelType.AutoSize = true;
            labelFuelType.Location = new Point(39, 321);
            labelFuelType.Name = "labelFuelType";
            labelFuelType.Size = new Size(56, 15);
            labelFuelType.TabIndex = 49;
            labelFuelType.Text = "Fuel Type";
            labelFuelType.UseMnemonic = false;
            // 
            // txtFuelType
            // 
            txtFuelType.Location = new Point(135, 321);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new Size(249, 23);
            txtFuelType.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 541);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 59;
            label6.Text = "Mileage";
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(135, 538);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(249, 23);
            txtMileage.TabIndex = 58;
            // 
            // labelUID
            // 
            labelUID.AutoSize = true;
            labelUID.Location = new Point(39, 99);
            labelUID.Name = "labelUID";
            labelUID.Size = new Size(41, 15);
            labelUID.TabIndex = 61;
            labelUID.Text = "UserID";
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Location = new Point(135, 99);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(249, 23);
            txtUserID.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 423);
            label7.Name = "label7";
            label7.Size = new Size(75, 30);
            label7.TabIndex = 63;
            label7.Text = "Transmission\r\nType";
            // 
            // txtTransmissionType
            // 
            txtTransmissionType.Location = new Point(135, 430);
            txtTransmissionType.Name = "txtTransmissionType";
            txtTransmissionType.Size = new Size(249, 23);
            txtTransmissionType.TabIndex = 62;
            // 
            // VehicleInformationEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 621);
            Controls.Add(label7);
            Controls.Add(txtTransmissionType);
            Controls.Add(labelUID);
            Controls.Add(txtUserID);
            Controls.Add(label6);
            Controls.Add(txtMileage);
            Controls.Add(label4);
            Controls.Add(txtRegistrationNumber);
            Controls.Add(label5);
            Controls.Add(txtEngineConfiguration);
            Controls.Add(labelVehicleType);
            Controls.Add(txtVehicleType);
            Controls.Add(labelWheelDriveType);
            Controls.Add(txtWheelDriveType);
            Controls.Add(labelFuelType);
            Controls.Add(txtFuelType);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(txtVehicleID);
            Controls.Add(btnUpdate);
            Controls.Add(labelColor);
            Controls.Add(txtColor);
            Controls.Add(labelYear);
            Controls.Add(txtYear);
            Controls.Add(label3);
            Controls.Add(txtModel);
            Controls.Add(label2);
            Controls.Add(txtMake);
            Controls.Add(labelVIN);
            Controls.Add(txtVIN);
            Controls.Add(labelID);
            Name = "VehicleInformationEdit";
            Text = "VehicleInformationEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private TextBox txtVehicleID;
        private Button btnUpdate;
        private Label labelColor;
        private TextBox txtColor;
        private Label labelYear;
        private TextBox txtYear;
        private Label label3;
        private TextBox txtModel;
        private Label label2;
        private TextBox txtMake;
        private Label labelVIN;
        private TextBox txtVIN;
        private Label labelID;
        private Label label4;
        private TextBox txtRegistrationNumber;
        private Label label5;
        private TextBox txtEngineConfiguration;
        private Label labelVehicleType;
        private TextBox txtVehicleType;
        private Label labelWheelDriveType;
        private TextBox txtWheelDriveType;
        private Label labelFuelType;
        private TextBox txtFuelType;
        private Label label6;
        private TextBox txtMileage;
        private Label labelUID;
        private TextBox txtUserID;
        private Label label7;
        private TextBox txtTransmissionType;
    }
}