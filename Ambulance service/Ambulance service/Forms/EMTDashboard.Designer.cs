
namespace Ambulance_service.Forms
{
    partial class EMTDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.ECFTable = new System.Windows.Forms.DataGridView();
            this.EmergencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ECFTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "WELCOME EMT";
            // 
            // ECFTable
            // 
            this.ECFTable.AllowUserToAddRows = false;
            this.ECFTable.AllowUserToDeleteRows = false;
            this.ECFTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ECFTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmergencyCode,
            this.LocationColumn,
            this.StatusColumn,
            this.ButtonColumn});
            this.ECFTable.Location = new System.Drawing.Point(5, 58);
            this.ECFTable.Name = "ECFTable";
            this.ECFTable.ReadOnly = true;
            this.ECFTable.Size = new System.Drawing.Size(740, 410);
            this.ECFTable.TabIndex = 16;
            this.ECFTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.openERF);
            // 
            // EmergencyCode
            // 
            this.EmergencyCode.HeaderText = "Emergency Code";
            this.EmergencyCode.Name = "EmergencyCode";
            this.EmergencyCode.ReadOnly = true;
            this.EmergencyCode.Width = 200;
            // 
            // LocationColumn
            // 
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            this.LocationColumn.Width = 175;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 150;
            // 
            // ButtonColumn
            // 
            this.ButtonColumn.HeaderText = "ERFs";
            this.ButtonColumn.Name = "ButtonColumn";
            this.ButtonColumn.ReadOnly = true;
            this.ButtonColumn.Text = "Open ERF";
            this.ButtonColumn.UseColumnTextForButtonValue = true;
            this.ButtonColumn.Width = 170;
            // 
            // EMTDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 480);
            this.Controls.Add(this.ECFTable);
            this.Controls.Add(this.label1);
            this.Name = "EMTDashboard";
            this.Text = "EMT Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.ECFTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ECFTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmergencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumn;
    }
}