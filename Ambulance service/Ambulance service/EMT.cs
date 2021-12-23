using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambulance_service.Forms;
using Ambulance_service.Classes;

namespace Ambulance_service
{
    public partial class EMT : Form
    {
        ECF_Factory ecffact = ECF_Factory.instance();
        private Form currentPanel;
        private static EMT EMTFormMain;
        private EMT()
        {
            InitializeComponent();
        }

        public static EMT instance()
        {
            if (EMTFormMain == null)
            {
                EMTFormMain = new EMT();
            }
            return EMTFormMain;
        }

        private void openNextPanel(Form nextPanel)
        {
            if (currentPanel != null)
            {
                currentPanel.Close();
            }
            currentPanel = nextPanel;
            nextPanel.TopLevel = false;
            nextPanel.FormBorderStyle = FormBorderStyle.None;
            nextPanel.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(nextPanel);
            this.contentPanel.Tag = nextPanel;
            nextPanel.BringToFront();
            nextPanel.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openNextPanel(new Forms.ERF());
        }

        public void OpenERFPanel(int emergencyCode)
        {
            ECFLinkedList allECFs = ecffact.getlist();
            ECF searchedECF = allECFs.searchECF(emergencyCode);
            ERF ERFScreen = new ERF();
            ERFScreen.CallerNameTxtBox.Text = searchedECF.getCallerName().ToString();
            ERFScreen.NumberTxtBox.Text = searchedECF.getPhoneNumber().ToString();
            ERFScreen.NatureTxtBox.Text = searchedECF.getNature().ToString();
            ERFScreen.LocationTxtBox.Text = searchedECF.getLocation().ToString();
            ERFScreen.HospitalTxtBox.Text = searchedECF.getHospitalName().ToString();
            openNextPanel(ERFScreen);
        }

        private void EMT_Load(object sender, EventArgs e)
        {
            openNextPanel(new Forms.EMTDashboard());
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.instance().Show();
        }

        private void EMT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           openNextPanel(new Forms.EMTDashboard());
        }
    }
}
