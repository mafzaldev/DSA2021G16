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
    public partial class PerformanceReport : Form
    {
        public PerformanceReport()
        {
            InitializeComponent();
        }

        private void PerformanceReport_Load(object sender, EventArgs e)
        {
            populateEmployeesData();
        }

        public void populateEmployeesData()
        {
            EmpAmb_CRUD EmpCRUD = EmpAmb_CRUD.instance();
            employee[] allEmployees = EmpCRUD.getAllEmployees();
            int idx = 0;
            while (idx != allEmployees.Length && allEmployees[idx] != null)
            {
                employee emp = allEmployees[idx];
                Console.WriteLine(allEmployees.Length);
                string[] row = { emp.getname().ToString(), emp.getemptype().ToString(), emp.getScore().ToString(),emp.getattendance().ToString() };
                employeesTable.Rows.Add(row);
                idx++;
            }
        }
    }
}
