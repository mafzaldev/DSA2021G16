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
    public partial class VictimSearch : Form
    {
        private static VictimSearch VictimSearchMain;
        private VictimSearch()
        {
            InitializeComponent();
        }

        public static VictimSearch instance()
        {
            if (VictimSearchMain == null)
            {
                VictimSearchMain = new VictimSearch();
            }
            return VictimSearchMain;
        }
        
        private void VictimSearch_Load(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm nextForm = LoginForm.instance();
            nextForm.Show();
        }

        private void victim_clicked(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }

        private void victim_leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "") {
                textBox2.Text = "Victim's Name";
                textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }
    }
}