using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_service.Forms
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmp_clicked(object sender, EventArgs e)
        {
            if (presencecheck() == true)
            {
                EmpAmb_CRUD empcrud = EmpAmb_CRUD.instance();
                empcrud.addemp(EmpNameTxtBox.Text, usernameTxtBox.Text, passwordTxtBox.Text, PhoneNumTxtBox.Text, cnicTxtBox.Text, EmpTypeBox.Text, EmpShift.Text, 0, 0);
                resetTextBoxes();
            }
        }

        private void fullname_click(object sender, EventArgs e)
        {
            EmpNameTxtBox.Text = "";
            EmpNameTxtBox.ForeColor = Color.Black;
        }

        private void fullname_leave(object sender, EventArgs e)
        {
            if (EmpNameTxtBox.Text == "") {
                EmpNameTxtBox.Text = "Full Name";
                EmpNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }

        }

        private void cnic_clicked(object sender, EventArgs e)
        {
            cnicTxtBox.Text = "";
            cnicTxtBox.ForeColor = Color.Black;
        }

        private void cnic_leave(object sender, EventArgs e)
        {
            if (cnicTxtBox.Text == "") {
                cnicTxtBox.Text = "CNIC";
                cnicTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void username_clicked(object sender, EventArgs e)
        {
            usernameTxtBox.Text = "";
            usernameTxtBox.ForeColor = Color.Black;
        }

        private void username_leave(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text =="") {
                usernameTxtBox.Text = "Username";
                usernameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void password_clicked(object sender, EventArgs e)
        {
            passwordTxtBox.Text = "";
            passwordTxtBox.ForeColor = Color.Black;
        }

        private void password_leave(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "") {
                passwordTxtBox.Text = "Password";
                passwordTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void number_clicked(object sender, EventArgs e)
        {
            PhoneNumTxtBox.Text = "";
            PhoneNumTxtBox.ForeColor = Color.Black;
        }

        private void number_leave(object sender, EventArgs e)
        {
            if (PhoneNumTxtBox.Text =="") {
                PhoneNumTxtBox.Text = "Phone Number";
                PhoneNumTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void resetTextBoxes() {
            EmpNameTxtBox.Text = "Full Name";
            PhoneNumTxtBox.Text = "Phone Number";
            passwordTxtBox.Text = "Password";
            usernameTxtBox.Text = "Username";
            cnicTxtBox.Text = "CNIC";
            EmpTypeBox.SelectedIndex = -1;
            EmpShift.SelectedIndex = -1;
            EmpNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            PhoneNumTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            passwordTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            usernameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            cnicTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;

        }
        
        private bool presencecheck() {
            bool validcheck = true;
            if (EmpNameTxtBox.Text=="Full Name") {
                namelabel.Visible = true;
                validcheck = false;
            }
            if (cnicTxtBox.Text == "CNIC") {
                cniclabel.Visible = true;
                validcheck = false;
            }
            if (usernameTxtBox.Text == "Username")
            {
                usernamelabel.Visible = true;
                validcheck = false;
            }
            if (passwordTxtBox.Text == "Password")
            {
                passwordlabel.Visible = true;
                validcheck = false;
            }
            if (PhoneNumTxtBox.Text == "Phone Number")
            {
                numberlabel.Visible = true;
                validcheck = false;
            }
            if (EmpTypeBox.Text=="")
            {
                typelabel.Visible = true;
                validcheck = false;
            }
            if (EmpShift.Text == "")
            {
                shiftlabel.Visible = true;
                validcheck = false;
            }
            return validcheck;
        }

        private void empname_changed(object sender, EventArgs e)
        {
            EmpNameTxtBox.ForeColor = Color.Black;
        }
    }
}
