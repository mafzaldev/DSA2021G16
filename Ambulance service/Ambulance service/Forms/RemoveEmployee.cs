using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_service
{
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
        {
            InitializeComponent();
        }

        private void name_clicked(object sender, EventArgs e)
        {
            EmpNameTxtBox.Text = "";
            EmpNameTxtBox.ForeColor = Color.Black;
        }

        private void name_leave(object sender, EventArgs e)
        {
            if(EmpNameTxtBox.Text == ""){
                EmpNameTxtBox.Text = "Full Name";
                EmpNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void remove_clicked(object sender, EventArgs e)
        {
            if(presencecheck()){
                EmpAmb_CRUD crud = EmpAmb_CRUD.instance();
                crud.deleteemp(EmpNameTxtBox.Text);
                resettextbox();
            }
        }

        private void resettextbox() {
            EmpNameTxtBox.Text = "Full Name";
            EmpNameTxtBox.ForeColor = Color.Black;
        }
        private bool presencecheck() {
            if (EmpNameTxtBox.Text == "Full Name") {
                return false;
            }
            return true;
        }
    }
}
