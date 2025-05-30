namespace VehicleMaintenanceSystem.UserDashPanels
{
    partial class ViewVehiclePanel
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
            dataGridViewVehicles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehicles).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVehicles
            // 
            dataGridViewVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehicles.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewVehicles.Location = new Point(12, 12);
            dataGridViewVehicles.Name = "dataGridViewVehicles";
            dataGridViewVehicles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewVehicles.ScrollBars = ScrollBars.None;
            dataGridViewVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVehicles.Size = new Size(760, 387);
            dataGridViewVehicles.TabIndex = 0;
            dataGridViewVehicles.CellContentDoubleClick += dataGridViewVehicles_SelectionChanged;
            // 
            // ViewVehiclePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(dataGridViewVehicles);
            Name = "ViewVehiclePanel";
            Text = "UserViewVehiclePanel";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehicles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewVehicles;
    }
}