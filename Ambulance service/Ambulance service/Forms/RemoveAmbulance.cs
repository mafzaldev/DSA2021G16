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
    public partial class RemoveAmbulance : Form
    {
        public RemoveAmbulance()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private bool presencecheck() {
            if (textBox2.Text=="Unique ID") {
                return false;
            }
            return true;
        }

        private void Remove_clicked(object sender, EventArgs e)
        {
            if (presencecheck()) {
                EmpAmb_CRUD crud = EmpAmb_CRUD.instance();
                crud.deleteambulance(textBox2.Text);
                resettextbox();
            }
        }
        private void resettextbox() {
            textBox2.Text = "Unique ID";
            textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
        }
    }
}
