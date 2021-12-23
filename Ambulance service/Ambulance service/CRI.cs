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
    public partial class CRI : Form
    {
        private Form currentPanel;
        private static CRI LoginFormMain;
        private CRI()
        {
            InitializeComponent();
        }

        public static CRI instance()
        {
            if (LoginFormMain == null)
            {
                LoginFormMain = new CRI();
            }
            return LoginFormMain;
        }

        private void openNextPanel(Form nextPanel, object sender)
        {
            if (currentPanel != null)
            {
                currentPanel.Close();
            }
            currentPanel = nextPanel;
            nextPanel.TopLevel = false;
            nextPanel.FormBorderStyle = FormBorderStyle.None;
            nextPanel.Dock = DockStyle.Fill;
            this.mainContentPanel.Controls.Add(nextPanel);
            this.mainContentPanel.Tag = nextPanel;
            nextPanel.BringToFront();
            nextPanel.Show();
        }

        private void CRI_Load(object sender, EventArgs e)
        {
            openNextPanel(new Forms.CRIDashboard(), sender);
        }

        private void addEmpLabel_Click(object sender, EventArgs e)
        {
            openNextPanel(new Forms.AddEmployee(), sender);
        }

        private void remEmpLabel_Click(object sender, EventArgs e)
        {
            openNextPanel(new RemoveEmployee(), sender);
        }

        private void addAmbLabel_Click(object sender, EventArgs e)
        {
            openNextPanel(new Forms.AddAmbulance(), sender);
        }

        private void remAmbLabel_Click(object sender, EventArgs e)
        {
            openNextPanel(new Forms.RemoveAmbulance(), sender);
        }

        private void revEmpLabel_Click(object sender, EventArgs e)
        {
            openNextPanel(new Forms.PerformanceReport(), sender);
        }

        private void revECFLabel_Click(object sender, EventArgs e)
        {
            openNextPanel(new Forms.ReviewECF(), sender);
        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs es)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            openNextPanel(new Forms.CRIDashboard(), sender);
            LoginForm.instance().Show();
        }

        private void CRI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
