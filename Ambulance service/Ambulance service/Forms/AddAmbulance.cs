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
    public partial class AddAmbulance : Form
    {
        public AddAmbulance()
        {
            InitializeComponent();
        }

        private void ID_clicked(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }

        private void ID_leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "") {
                textBox2.Text = "Unique ID";
                textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void numPlate_clicked(object sender, EventArgs e)
        {
            userNameInput.Text = "";
            userNameInput.ForeColor = Color.Black;
        }

        private void numPlate_leave(object sender, EventArgs e)
        {
            if (userNameInput.Text == "") {
                userNameInput.Text = "Number Plate";
                userNameInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void Addambulance_clicked(object sender, EventArgs e)
        {
            if (presencecheck()) {
                EmpAmb_CRUD crud = EmpAmb_CRUD.instance();
                VehicleType vantype;
                if (ambType1.Checked)
                {
                    vantype = VehicleType.Bolan;
                }
                else if (ambType2.Checked)
                {
                    vantype = VehicleType.Hiace;
                }
                else if (ambType3.Checked)
                {
                    vantype = VehicleType.APV;
                }
                else {
                    vantype = VehicleType.Kaarvan;
                }
                crud.addambulance(textBox2.Text,userNameInput.Text,vantype);
                resetcheckboxes();
            }
        }
        private void resetcheckboxes() {
            ambType1.Checked = false;
            ambType2.Checked = false;
            ambType3.Checked = false;
            ambType4.Checked = false;
            textBox2.Text = "Unique ID";
            textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            userNameInput.Text = "Password";
            userNameInput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
        }
        private bool presencecheck() {
            if (textBox2.Text == "Unique ID" || userNameInput.Text == "Number Plate") {
                return false;
            }
            if (ambType1.Checked==false && ambType2.Checked == false && ambType3.Checked == false && ambType4.Checked == false) {
                return false;
            }
            return true;
        }
        
    }
}
