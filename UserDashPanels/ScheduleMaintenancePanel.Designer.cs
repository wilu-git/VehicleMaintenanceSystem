namespace VehicleMaintenanceSystem.UserDashPanels
{
    partial class ScheduleMaintenancePanel
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
            dtpDate = new DateTimePicker();
            txtDescription = new TextBox();
            cmbMaintenanceType = new ComboBox();
            cmbTimeSlot = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            btnPickVehicle = new Button();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(73, 117);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(299, 23);
            dtpDate.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(73, 276);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(299, 109);
            txtDescription.TabIndex = 1;
            // 
            // cmbMaintenanceType
            // 
            cmbMaintenanceType.FormattingEnabled = true;
            cmbMaintenanceType.Location = new Point(73, 171);
            cmbMaintenanceType.Name = "cmbMaintenanceType";
            cmbMaintenanceType.Size = new Size(299, 23);
            cmbMaintenanceType.TabIndex = 2;
            // 
            // cmbTimeSlot
            // 
            cmbTimeSlot.FormattingEnabled = true;
            cmbTimeSlot.Location = new Point(73, 222);
            cmbTimeSlot.Name = "cmbTimeSlot";
            cmbTimeSlot.Size = new Size(299, 23);
            cmbTimeSlot.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 99);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "Pick Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 153);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 5;
            label2.Text = "Maintenance Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 203);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 6;
            label3.Text = "Schedule Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 258);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Description";
            // 
            // button1
            // 
            button1.Location = new Point(144, 408);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 8;
            button1.Text = "Request Maintenance";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 18);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 9;
            label5.Text = "Schedule a Maintenance";
            // 
            // btnPickVehicle
            // 
            btnPickVehicle.Location = new Point(73, 58);
            btnPickVehicle.Name = "btnPickVehicle";
            btnPickVehicle.Size = new Size(299, 23);
            btnPickVehicle.TabIndex = 10;
            btnPickVehicle.Text = "Pick a Vehicle";
            btnPickVehicle.UseVisualStyleBackColor = true;
            btnPickVehicle.Click += btnPickVehicle_Click;
            // 
            // ScheduleMaintenancePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 450);
            Controls.Add(btnPickVehicle);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTimeSlot);
            Controls.Add(cmbMaintenanceType);
            Controls.Add(txtDescription);
            Controls.Add(dtpDate);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScheduleMaintenancePanel";
            Text = "ScheduleMaintenancePanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private TextBox txtDescription;
        private ComboBox cmbMaintenanceType;
        private ComboBox cmbTimeSlot;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Button btnPickVehicle;
    }
}