
namespace Ambulance_service
{
    partial class CRI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRI));
            this.Navbar = new System.Windows.Forms.PictureBox();
            this.welcomeLBL = new System.Windows.Forms.Label();
            this.addEmpLabel = new System.Windows.Forms.Label();
            this.remEmpLabel = new System.Windows.Forms.Label();
            this.addAmbLabel = new System.Windows.Forms.Label();
            this.remAmbLabel = new System.Windows.Forms.Label();
            this.revEmpLabel = new System.Windows.Forms.Label();
            this.revECFLabel = new System.Windows.Forms.Label();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.logoutLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Navbar)).BeginInit();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.Image = ((System.Drawing.Image)(resources.GetObject("Navbar.Image")));
            this.Navbar.Location = new System.Drawing.Point(1, 1);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(202, 660);
            this.Navbar.TabIndex = 0;
            this.Navbar.TabStop = false;
            // 
            // welcomeLBL
            // 
            this.welcomeLBL.AutoSize = true;
            this.welcomeLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.welcomeLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLBL.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.welcomeLBL.Location = new System.Drawing.Point(18, 37);
            this.welcomeLBL.Name = "welcomeLBL";
            this.welcomeLBL.Size = new System.Drawing.Size(132, 32);
            this.welcomeLBL.TabIndex = 5;
            this.welcomeLBL.Text = "WELCOME";
            this.welcomeLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // addEmpLabel
            // 
            this.addEmpLabel.AutoSize = true;
            this.addEmpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.addEmpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addEmpLabel.Location = new System.Drawing.Point(18, 85);
            this.addEmpLabel.Name = "addEmpLabel";
            this.addEmpLabel.Size = new System.Drawing.Size(121, 21);
            this.addEmpLabel.TabIndex = 6;
            this.addEmpLabel.Text = "Add employee";
            this.addEmpLabel.Click += new System.EventHandler(this.addEmpLabel_Click);
            // 
            // remEmpLabel
            // 
            this.remEmpLabel.AutoSize = true;
            this.remEmpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.remEmpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remEmpLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.remEmpLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.remEmpLabel.Location = new System.Drawing.Point(18, 117);
            this.remEmpLabel.Name = "remEmpLabel";
            this.remEmpLabel.Size = new System.Drawing.Size(152, 21);
            this.remEmpLabel.TabIndex = 7;
            this.remEmpLabel.Text = "Remove employee";
            this.remEmpLabel.Click += new System.EventHandler(this.remEmpLabel_Click);
            // 
            // addAmbLabel
            // 
            this.addAmbLabel.AutoSize = true;
            this.addAmbLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.addAmbLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAmbLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addAmbLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addAmbLabel.Location = new System.Drawing.Point(18, 149);
            this.addAmbLabel.Name = "addAmbLabel";
            this.addAmbLabel.Size = new System.Drawing.Size(130, 21);
            this.addAmbLabel.TabIndex = 8;
            this.addAmbLabel.Text = "Add ambulance";
            this.addAmbLabel.Click += new System.EventHandler(this.addAmbLabel_Click);
            // 
            // remAmbLabel
            // 
            this.remAmbLabel.AutoSize = true;
            this.remAmbLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.remAmbLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remAmbLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.remAmbLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.remAmbLabel.Location = new System.Drawing.Point(18, 181);
            this.remAmbLabel.Name = "remAmbLabel";
            this.remAmbLabel.Size = new System.Drawing.Size(161, 21);
            this.remAmbLabel.TabIndex = 9;
            this.remAmbLabel.Text = "Remove ambulance";
            this.remAmbLabel.Click += new System.EventHandler(this.remAmbLabel_Click);
            // 
            // revEmpLabel
            // 
            this.revEmpLabel.AutoSize = true;
            this.revEmpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.revEmpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.revEmpLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.revEmpLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.revEmpLabel.Location = new System.Drawing.Point(18, 213);
            this.revEmpLabel.Name = "revEmpLabel";
            this.revEmpLabel.Size = new System.Drawing.Size(152, 21);
            this.revEmpLabel.TabIndex = 10;
            this.revEmpLabel.Text = "Review employees";
            this.revEmpLabel.Click += new System.EventHandler(this.revEmpLabel_Click);
            // 
            // revECFLabel
            // 
            this.revECFLabel.AutoSize = true;
            this.revECFLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.revECFLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.revECFLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.revECFLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.revECFLabel.Location = new System.Drawing.Point(18, 245);
            this.revECFLabel.Name = "revECFLabel";
            this.revECFLabel.Size = new System.Drawing.Size(103, 21);
            this.revECFLabel.TabIndex = 11;
            this.revECFLabel.Text = "Review ECFs";
            this.revECFLabel.Click += new System.EventHandler(this.revECFLabel_Click);
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Location = new System.Drawing.Point(209, 1);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(774, 660);
            this.mainContentPanel.TabIndex = 12;
            this.mainContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContentPanel_Paint);
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.logoutLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.logoutLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutLbl.Location = new System.Drawing.Point(18, 276);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(70, 21);
            this.logoutLbl.TabIndex = 13;
            this.logoutLbl.Text = "Log Out";
            this.logoutLbl.Click += new System.EventHandler(this.logoutLbl_Click);
            // 
            // CRI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.logoutLbl);
            this.Controls.Add(this.revECFLabel);
            this.Controls.Add(this.revEmpLabel);
            this.Controls.Add(this.remAmbLabel);
            this.Controls.Add(this.addAmbLabel);
            this.Controls.Add(this.remEmpLabel);
            this.Controls.Add(this.addEmpLabel);
            this.Controls.Add(this.welcomeLBL);
            this.Controls.Add(this.Navbar);
            this.Controls.Add(this.mainContentPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "CRI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRI Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CRI_FormClosing);
            this.Load += new System.EventHandler(this.CRI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Navbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Navbar;
        private System.Windows.Forms.Label welcomeLBL;
        private System.Windows.Forms.Label addEmpLabel;
        private System.Windows.Forms.Label remEmpLabel;
        private System.Windows.Forms.Label addAmbLabel;
        private System.Windows.Forms.Label remAmbLabel;
        private System.Windows.Forms.Label revEmpLabel;
        private System.Windows.Forms.Label revECFLabel;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Label logoutLbl;
    }
}