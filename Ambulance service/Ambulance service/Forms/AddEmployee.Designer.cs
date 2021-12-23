
namespace Ambulance_service.Forms
{
    partial class AddEmployee
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
            this.EmpNameTxtBox = new System.Windows.Forms.TextBox();
            this.cnicTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneNumTxtBox = new System.Windows.Forms.TextBox();
            this.EmpTypeBox = new System.Windows.Forms.ComboBox();
            this.EmpShift = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddEmpbutton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.cniclabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.numberlabel = new System.Windows.Forms.Label();
            this.typelabel = new System.Windows.Forms.Label();
            this.shiftlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD EMPLOYEE";
            // 
            // EmpNameTxtBox
            // 
            this.EmpNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmpNameTxtBox.Location = new System.Drawing.Point(28, 142);
            this.EmpNameTxtBox.Name = "EmpNameTxtBox";
            this.EmpNameTxtBox.Size = new System.Drawing.Size(261, 33);
            this.EmpNameTxtBox.TabIndex = 2;
            this.EmpNameTxtBox.Text = "Full Name";
            this.EmpNameTxtBox.Click += new System.EventHandler(this.fullname_click);
            this.EmpNameTxtBox.Leave += new System.EventHandler(this.fullname_leave);
            // 
            // cnicTxtBox
            // 
            this.cnicTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cnicTxtBox.Location = new System.Drawing.Point(28, 201);
            this.cnicTxtBox.Name = "cnicTxtBox";
            this.cnicTxtBox.Size = new System.Drawing.Size(261, 33);
            this.cnicTxtBox.TabIndex = 3;
            this.cnicTxtBox.Text = "CNIC";
            this.cnicTxtBox.Click += new System.EventHandler(this.cnic_clicked);
            this.cnicTxtBox.Leave += new System.EventHandler(this.cnic_leave);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.usernameTxtBox.Location = new System.Drawing.Point(28, 260);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(261, 33);
            this.usernameTxtBox.TabIndex = 4;
            this.usernameTxtBox.Text = "Username";
            this.usernameTxtBox.Click += new System.EventHandler(this.username_clicked);
            this.usernameTxtBox.Leave += new System.EventHandler(this.username_leave);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordTxtBox.Location = new System.Drawing.Point(28, 319);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(261, 33);
            this.passwordTxtBox.TabIndex = 5;
            this.passwordTxtBox.Text = "Password";
            this.passwordTxtBox.Click += new System.EventHandler(this.password_clicked);
            this.passwordTxtBox.Leave += new System.EventHandler(this.password_leave);
            // 
            // PhoneNumTxtBox
            // 
            this.PhoneNumTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PhoneNumTxtBox.Location = new System.Drawing.Point(28, 378);
            this.PhoneNumTxtBox.Name = "PhoneNumTxtBox";
            this.PhoneNumTxtBox.Size = new System.Drawing.Size(261, 33);
            this.PhoneNumTxtBox.TabIndex = 6;
            this.PhoneNumTxtBox.Text = "Phone Number";
            this.PhoneNumTxtBox.Click += new System.EventHandler(this.number_clicked);
            this.PhoneNumTxtBox.Leave += new System.EventHandler(this.number_leave);
            // 
            // EmpTypeBox
            // 
            this.EmpTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpTypeBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpTypeBox.FormattingEnabled = true;
            this.EmpTypeBox.Items.AddRange(new object[] {
            "CTWO",
            "EMT",
            "Driver",
            "Doctor"});
            this.EmpTypeBox.Location = new System.Drawing.Point(370, 142);
            this.EmpTypeBox.Name = "EmpTypeBox";
            this.EmpTypeBox.Size = new System.Drawing.Size(261, 33);
            this.EmpTypeBox.TabIndex = 7;
            // 
            // EmpShift
            // 
            this.EmpShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpShift.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpShift.FormattingEnabled = true;
            this.EmpShift.Items.AddRange(new object[] {
            "Day",
            "Evening",
            "Night"});
            this.EmpShift.Location = new System.Drawing.Point(28, 453);
            this.EmpShift.Name = "EmpShift";
            this.EmpShift.Size = new System.Drawing.Size(261, 33);
            this.EmpShift.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Shift";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ambulance_service.Properties.Resources.RESCUE_1122;
            this.pictureBox1.Location = new System.Drawing.Point(560, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // AddEmpbutton
            // 
            this.AddEmpbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmpbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddEmpbutton.Location = new System.Drawing.Point(28, 510);
            this.AddEmpbutton.Name = "AddEmpbutton";
            this.AddEmpbutton.Size = new System.Drawing.Size(146, 36);
            this.AddEmpbutton.TabIndex = 12;
            this.AddEmpbutton.Text = "Add Employee";
            this.AddEmpbutton.UseVisualStyleBackColor = true;
            this.AddEmpbutton.Click += new System.EventHandler(this.AddEmp_clicked);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.ForeColor = System.Drawing.Color.Red;
            this.namelabel.Location = new System.Drawing.Point(26, 178);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(160, 13);
            this.namelabel.TabIndex = 13;
            this.namelabel.Text = "Enter the Name of the Employee";
            this.namelabel.Visible = false;
            // 
            // cniclabel
            // 
            this.cniclabel.AutoSize = true;
            this.cniclabel.ForeColor = System.Drawing.Color.Red;
            this.cniclabel.Location = new System.Drawing.Point(26, 237);
            this.cniclabel.Name = "cniclabel";
            this.cniclabel.Size = new System.Drawing.Size(157, 13);
            this.cniclabel.TabIndex = 14;
            this.cniclabel.Text = "Enter the CNIC of the Employee";
            this.cniclabel.Visible = false;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.ForeColor = System.Drawing.Color.Red;
            this.usernamelabel.Location = new System.Drawing.Point(26, 296);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(180, 13);
            this.usernamelabel.TabIndex = 15;
            this.usernamelabel.Text = "Enter the Username of the Employee";
            this.usernamelabel.Visible = false;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.ForeColor = System.Drawing.Color.Red;
            this.passwordlabel.Location = new System.Drawing.Point(26, 355);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(178, 13);
            this.passwordlabel.TabIndex = 16;
            this.passwordlabel.Text = "Enter the Password of the Employee";
            this.passwordlabel.Visible = false;
            // 
            // numberlabel
            // 
            this.numberlabel.AutoSize = true;
            this.numberlabel.ForeColor = System.Drawing.Color.Red;
            this.numberlabel.Location = new System.Drawing.Point(26, 414);
            this.numberlabel.Name = "numberlabel";
            this.numberlabel.Size = new System.Drawing.Size(194, 13);
            this.numberlabel.TabIndex = 17;
            this.numberlabel.Text = "Enter a Phone Number of the Employee";
            this.numberlabel.Visible = false;
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.ForeColor = System.Drawing.Color.Red;
            this.typelabel.Location = new System.Drawing.Point(367, 178);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(73, 13);
            this.typelabel.TabIndex = 18;
            this.typelabel.Text = "Select a Type";
            this.typelabel.Visible = false;
            // 
            // shiftlabel
            // 
            this.shiftlabel.AutoSize = true;
            this.shiftlabel.ForeColor = System.Drawing.Color.Red;
            this.shiftlabel.Location = new System.Drawing.Point(26, 489);
            this.shiftlabel.Name = "shiftlabel";
            this.shiftlabel.Size = new System.Drawing.Size(70, 13);
            this.shiftlabel.TabIndex = 19;
            this.shiftlabel.Text = "Select a Shift";
            this.shiftlabel.Visible = false;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 621);
            this.Controls.Add(this.shiftlabel);
            this.Controls.Add(this.typelabel);
            this.Controls.Add(this.numberlabel);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.cniclabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.AddEmpbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmpShift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpTypeBox);
            this.Controls.Add(this.PhoneNumTxtBox);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.cnicTxtBox);
            this.Controls.Add(this.EmpNameTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpNameTxtBox;
        private System.Windows.Forms.TextBox cnicTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox PhoneNumTxtBox;
        private System.Windows.Forms.ComboBox EmpTypeBox;
        private System.Windows.Forms.ComboBox EmpShift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddEmpbutton;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label cniclabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label numberlabel;
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.Label shiftlabel;
    }
}