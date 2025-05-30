namespace VehicleMaintenanceSystem
{
    partial class AdminDash
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
            panelButtons = new Panel();
            btnUsersEditor = new Button();
            btnVehiclesEditor = new Button();
            button4 = new Button();
            button3 = new Button();
            btnManageData = new Button();
            panelContainer = new Panel();
            button1 = new Button();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(button1);
            panelButtons.Controls.Add(btnUsersEditor);
            panelButtons.Controls.Add(btnVehiclesEditor);
            panelButtons.Controls.Add(button4);
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(btnManageData);
            panelButtons.Dock = DockStyle.Left;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(170, 461);
            panelButtons.TabIndex = 0;
            // 
            // btnUsersEditor
            // 
            btnUsersEditor.Location = new Point(23, 74);
            btnUsersEditor.Name = "btnUsersEditor";
            btnUsersEditor.Size = new Size(130, 69);
            btnUsersEditor.TabIndex = 7;
            btnUsersEditor.Text = "Users";
            btnUsersEditor.UseVisualStyleBackColor = true;
            btnUsersEditor.Click += btnUsersEditor_Click;
            // 
            // btnVehiclesEditor
            // 
            btnVehiclesEditor.Location = new Point(23, 149);
            btnVehiclesEditor.Name = "btnVehiclesEditor";
            btnVehiclesEditor.Size = new Size(130, 69);
            btnVehiclesEditor.TabIndex = 6;
            btnVehiclesEditor.Text = "Vehicles";
            btnVehiclesEditor.UseVisualStyleBackColor = true;
            btnVehiclesEditor.Click += btnVehiclesEditor_Click;
            // 
            // button4
            // 
            button4.Location = new Point(23, 356);
            button4.Name = "button4";
            button4.Size = new Size(130, 69);
            button4.TabIndex = 5;
            button4.Text = "Vehicle Out";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(23, 281);
            button3.Name = "button3";
            button3.Size = new Size(130, 69);
            button3.TabIndex = 4;
            button3.Text = "Assign Mechanic";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnManageData
            // 
            btnManageData.Location = new Point(1, 24);
            btnManageData.Name = "btnManageData";
            btnManageData.Size = new Size(170, 44);
            btnManageData.TabIndex = 0;
            btnManageData.Text = "Manage Data";
            btnManageData.UseVisualStyleBackColor = true;
            btnManageData.Click += btnManageData_Click;
            // 
            // panelContainer
            // 
            panelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(170, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(814, 461);
            panelContainer.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(3, 231);
            button1.Name = "button1";
            button1.Size = new Size(170, 44);
            button1.TabIndex = 8;
            button1.Text = "Manage Data";
            button1.UseVisualStyleBackColor = true;
            // 
            // AdminDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(panelContainer);
            Controls.Add(panelButtons);
            Name = "AdminDash";
            Text = "AdminCRUD";
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button btnManageData;
        private Button btnVehiclesEditor;
        private Button button4;
        private Button button3;
        private Panel panelContainer;
        private Button btnUsersEditor;
        private Button button1;
    }
}