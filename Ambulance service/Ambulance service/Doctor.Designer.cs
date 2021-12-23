
namespace Ambulance_service
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.completeECFTable = new System.Windows.Forms.DataGridView();
            this.emergencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.victimName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientECF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.completeECFTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // completeECFTable
            // 
            this.completeECFTable.AllowUserToAddRows = false;
            this.completeECFTable.AllowUserToDeleteRows = false;
            this.completeECFTable.AllowUserToResizeColumns = false;
            this.completeECFTable.AllowUserToResizeRows = false;
            this.completeECFTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.completeECFTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.completeECFTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emergencyCode,
            this.victimName,
            this.patientECF});
            this.completeECFTable.Location = new System.Drawing.Point(39, 122);
            this.completeECFTable.Name = "completeECFTable";
            this.completeECFTable.Size = new System.Drawing.Size(751, 509);
            this.completeECFTable.TabIndex = 18;
            // 
            // emergencyCode
            // 
            this.emergencyCode.HeaderText = "Emergency Code";
            this.emergencyCode.Name = "emergencyCode";
            this.emergencyCode.ReadOnly = true;
            this.emergencyCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // victimName
            // 
            this.victimName.HeaderText = "Victim\'s Name";
            this.victimName.Name = "victimName";
            // 
            // patientECF
            // 
            this.patientECF.HeaderText = "ECF";
            this.patientECF.Name = "patientECF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "WELCOME DOCTOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(772, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.BackColor = System.Drawing.Color.White;
            this.logoutLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.logoutLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutLbl.Location = new System.Drawing.Point(885, 624);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(81, 28);
            this.logoutLbl.TabIndex = 20;
            this.logoutLbl.Text = "LogOut";
            this.logoutLbl.Click += new System.EventHandler(this.logoutLbl_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.logoutLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.completeECFTable);
            this.Controls.Add(this.label1);
            this.Name = "Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doctor_FormClosing);
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.completeECFTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn victimName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientECF;
        private System.Windows.Forms.Label logoutLbl;
        private System.Windows.Forms.DataGridView completeECFTable;
    }
}