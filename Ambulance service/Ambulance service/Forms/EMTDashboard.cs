using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambulance_service.Classes;
using System.Windows.Forms;

namespace Ambulance_service.Forms
{
    public partial class EMTDashboard : Form
    {
        ECF_Factory ecffact = ECF_Factory.instance();
        public EMTDashboard()
        {
            InitializeComponent();
            populateData();
        }


        public void populateData()
        {
            ECFLinkedList allECFs = ecffact.getlist();
            ECF ECFNode = allECFs.getHead();
            while(ECFNode != null)
            {
                string[] row = {ECFNode.getEmergencyCode().ToString(), ECFNode.getLocation(),ECFNode.getstatus().ToString()};
                ECFTable.Rows.Add(row);
                ECFNode = ECFNode.getNext();
            }
        }

        private void openERF(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = ECFTable.CurrentCell.RowIndex;
            int emergencyCode = int.Parse(ECFTable.Rows[rowindex].Cells[0].Value.ToString());
            EMT EMTERF = EMT.instance();
            EMTERF.OpenERFPanel(emergencyCode);
        }
    }
}