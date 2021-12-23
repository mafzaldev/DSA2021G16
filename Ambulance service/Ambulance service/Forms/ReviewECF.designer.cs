
namespace Ambulance_service.Forms
{
    partial class ReviewECF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewECF));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.revECFTable = new System.Windows.Forms.DataGridView();
            this.emergencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.victimName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revECFTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(560, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "REVIEW ECFs";
            // 
            // revECFTable
            // 
            this.revECFTable.AllowUserToAddRows = false;
            this.revECFTable.AllowUserToDeleteRows = false;
            this.revECFTable.AllowUserToResizeColumns = false;
            this.revECFTable.AllowUserToResizeRows = false;
            this.revECFTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.revECFTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.revECFTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emergencyCode,
            this.victimName,
            this.currentStatus});
            this.revECFTable.Location = new System.Drawing.Point(31, 130);
            this.revECFTable.Name = "revECFTable";
            this.revECFTable.Size = new System.Drawing.Size(629, 461);
            this.revECFTable.TabIndex = 13;
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
            // currentStatus
            // 
            this.currentStatus.HeaderText = "Current Status";
            this.currentStatus.Name = "currentStatus";
            // 
            // ReviewECF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 621);
            this.Controls.Add(this.revECFTable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ReviewECF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewECF";
            this.Load += new System.EventHandler(this.ReviewECF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revECFTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView revECFTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn victimName;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStatus;
    }
}