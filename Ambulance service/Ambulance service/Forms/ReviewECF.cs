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

namespace Ambulance_service.Forms
{
    public partial class ReviewECF : Form
    {
        public ReviewECF()
        {
            InitializeComponent();
        }

        private void ReviewECF_Load(object sender, EventArgs e)
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
                string[] row = { ECFNode.getEmergencyCode().ToString(), ECFNode.getVictimName(), ECFNode.getstatus().ToString() };
                revECFTable.Rows.Add(row);
                ECFNode = ECFNode.getNext();
            }
        }
    }
}
