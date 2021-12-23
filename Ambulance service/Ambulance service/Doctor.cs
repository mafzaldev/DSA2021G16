using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambulance_service.Classes;

namespace Ambulance_service
{
    public partial class Doctor : Form
    {
        private static Doctor DoctorFormMain;
        private Doctor()
        {
            InitializeComponent();
        }

        public static Doctor instance()
        {
            if (DoctorFormMain == null)
            {
                DoctorFormMain = new Doctor();
            }
            return DoctorFormMain;
        }

        private void Doctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            LoginForm.instance().Show();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            populateData();
        }

        public void populateData()
        {
            ECF_Factory ecffact = ECF_Factory.instance();
            ECFLinkedList allECFs = ecffact.getlist();
            ECF ECFNode = allECFs.getHead();
            while (ECFNode != null)
            {
                string[] row = { ECFNode.getEmergencyCode().ToString(), ECFNode.getVictimName(), ECFNode.getPhoneNumber().ToString() };
                completeECFTable.Rows.Add(row);
                ECFNode = ECFNode.getNext();
            }
        }
    }
}