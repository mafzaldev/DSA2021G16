using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_service
{
    public partial class LoginForm : Form
    {
        private  static EmpAmb_CRUD EmpCRUD = EmpAmb_CRUD.instance();
        private static LoginForm LoginFormMain;
        private LoginForm()
        {
            InitializeComponent();
        }

        public static LoginForm instance()
        {
            if (LoginFormMain == null)
            {
                LoginFormMain = new LoginForm();
            }
            return LoginFormMain;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var allEmployees = Properties.Resources.allEmployees;
            var allEmployeesArray = allEmployees.Replace("\r", "").Split('\n');
            for (int idx = 0; idx < allEmployeesArray.Length; idx++)
            {
                Console.WriteLine(allEmployeesArray[idx]);
                string[] values = allEmployeesArray[idx].Split(',');
                EmpCRUD.addemp(values[0], values[1], values[2], values[3], values[4], values[5], values[6], int.Parse(values[7]), int.Parse(values[8]));
            }
        }

        private void initiateLogin_Click(object sender, EventArgs e)
        {
            employee[] AllEmployees = EmpCRUD.getAllEmployees();
            int idx = 0;
            while (idx != AllEmployees.Length && AllEmployees[idx] != null)
            {
                employee emp = AllEmployees[idx];
                if (userNameInput.Text == "abdul" && passWordInput.Text == "1234")
                {
                    this.Hide();
                    CRI.instance().Show();
                }

                else if (userNameInput.Text == emp.getUsername() && passWordInput.Text == emp.getPassword())
                {
                    if(emp.getemptype() == designation.CTWO)
                    {
                        this.Hide();
                        CTWO.instance().Show();
                    }

                    else if (emp.getemptype() == designation.EMT)
                    {
                        this.Hide();
                        EMT.instance().Show();
                    }

                    else if (emp.getemptype() == designation.Doctor)
                    {
                        this.Hide();
                        Doctor.instance().Show();
                    }
                    emp.IncrementAttendance();
                }
                idx++;
            }
            userNameInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            userNameInput.Text = "Username";
            passWordInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            passWordInput.Text = "Password";
        }

        private void username_clicked(object sender, EventArgs e)
        {
            userNameInput.Text = "";
            userNameInput.ForeColor = Color.Black;
        }

        private void username_leave(object sender, EventArgs e)
        {
            if(userNameInput.Text == ""){
                userNameInput.Text = "Username";
                userNameInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void password_clicked(object sender, EventArgs e)
        {
            passWordInput.Text = "";
            passWordInput.ForeColor = Color.Black;
        }

        private void password_leave(object sender, EventArgs e)
        {
            if (passWordInput.Text == "")
            {
                passWordInput.Text = "Password";
                passWordInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VictimSearch.instance().Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void EnterCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) {
                initiateLogin_Click(new object(),new EventArgs());
            }
        }
    }
}