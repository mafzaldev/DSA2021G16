
namespace Ambulance_service
{
    partial class RemoveEmployee
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpNameTxtBox = new System.Windows.Forms.TextBox();
            this.AddEmpbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ambulance_service.Properties.Resources.RESCUE_1122;
            this.pictureBox1.Location = new System.Drawing.Point(560, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "REMOVE EMPLOYEE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the name of the employee to remove";
            // 
            // EmpNameTxtBox
            // 
            this.EmpNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmpNameTxtBox.Location = new System.Drawing.Point(31, 167);
            this.EmpNameTxtBox.Name = "EmpNameTxtBox";
            this.EmpNameTxtBox.Size = new System.Drawing.Size(299, 33);
            this.EmpNameTxtBox.TabIndex = 4;
            this.EmpNameTxtBox.Text = "Full Name";
            this.EmpNameTxtBox.Click += new System.EventHandler(this.name_clicked);
            this.EmpNameTxtBox.Leave += new System.EventHandler(this.name_leave);
            // 
            // AddEmpbutton
            // 
            this.AddEmpbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddEmpbutton.Location = new System.Drawing.Point(31, 217);
            this.AddEmpbutton.Name = "AddEmpbutton";
            this.AddEmpbutton.Size = new System.Drawing.Size(162, 36);
            this.AddEmpbutton.TabIndex = 13;
            this.AddEmpbutton.Text = "Remove Employee";
            this.AddEmpbutton.UseVisualStyleBackColor = true;
            this.AddEmpbutton.Click += new System.EventHandler(this.remove_clicked);
            // 
            // RemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 621);
            this.Controls.Add(this.AddEmpbutton);
            this.Controls.Add(this.EmpNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(771, 660);
            this.MinimumSize = new System.Drawing.Size(771, 660);
            this.Name = "RemoveEmployee";
            this.Text = "RemoveEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpNameTxtBox;
        private System.Windows.Forms.Button AddEmpbutton;
    }
}