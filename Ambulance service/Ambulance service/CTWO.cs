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

namespace Ambulance_service
{
    public partial class CTWO : Form
    {
        private Package service;
        public static int servicesAlloted = 0;
        private Random random = new Random();
        private int currentcallseconds = 0;
        private int currentcallminutes = 0;
        private static CTWO CTWOMain;
        private CTWO()
        {
            InitializeComponent();
        }

        public static CTWO instance() {
            if (CTWOMain == null){
                CTWOMain = new CTWO();
            }
            return CTWOMain;
        }

        private void CTWO_Load(object sender, EventArgs e)
        {
            callgen.Enabled = true;
            allotServiceLabel.Enabled = false;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (presenceCheck()) {
                ECF_Factory ecffact = ECF_Factory.instance();
                Random randCode = new Random();
                ecffact.AddtoList(randCode.Next(10, 999), CallerNameTxtBox.Text, LocationTxtBox.Text, NumberTxtBox.Text, NatureTxtBox.Text, service, HospitalTxtBox.Text);
                resetTxtBoxes();
            }
        }
        
        private void resetTxtBoxes() {
            CallerNameTxtBox.Text = "Name of Caller";
            CallerNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            LocationTxtBox.Text = "Location";
            LocationTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            NumberTxtBox.Text = "Phone Number";
            NumberTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            NatureTxtBox.Text = "Nature of Emergency";
            NatureTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            HospitalTxtBox.Text = "Hospital Name";
            HospitalTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
        }
        
        private bool presenceCheck() {
            if (CallerNameTxtBox.Text=="Name of Caller") {
                return false;
            }
            if (NatureTxtBox.Text == "Nature of Emergency") {
                return false;
            }
            if (NumberTxtBox.Text == "Phone Number") {
                return false;
            }
            if (LocationTxtBox.Text == "Location") {
                return false;
            }
            if (HospitalTxtBox.Text == "Hospital Name") {
                return false;
            }
            return true;
        }

        private void NameofCaller_clicked(object sender, EventArgs e)
        {
            CallerNameTxtBox.Text = "";
            CallerNameTxtBox.ForeColor = Color.Black;
        }

        private void CallerName_leave(object sender, EventArgs e)
        {
            if(CallerNameTxtBox.Text==""){
                CallerNameTxtBox.Text = "Name of Caller";
                CallerNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void Emergency_Clicked(object sender, EventArgs e)
        {
            NatureTxtBox.Text = "";
            NatureTxtBox.ForeColor = Color.Black;
        }

        private void Nature_leave(object sender, EventArgs e)
        {
            if (NatureTxtBox.Text == "") {
                NatureTxtBox.Text = "Nature of emergency";
                NatureTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void Phone_clicked(object sender, EventArgs e)
        {
            NumberTxtBox.Text = "";
            NumberTxtBox.ForeColor = Color.Black;
        }

        private void phone_leave(object sender, EventArgs e)
        {
            if(NumberTxtBox.Text  == ""){
                NumberTxtBox.Text = "Phone Number";
                NumberTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void location_clicked(object sender, EventArgs e)
        {
            LocationTxtBox.Text = "";
            LocationTxtBox.ForeColor = Color.Black;
        }

        private void location_leave(object sender, EventArgs e)
        {
            if (LocationTxtBox.Text == "") {
                LocationTxtBox.Text = "Location";
                LocationTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void Hospital_clicked(object sender, EventArgs e)
        {
            HospitalTxtBox.Text = "";
            HospitalTxtBox.ForeColor = Color.Black;
        }

        private void hospital_leave(object sender, EventArgs e)
        {
            if(HospitalTxtBox.Text == "") {
                HospitalTxtBox.Text = "Hospital Name";
                HospitalTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void callGenerate(object sender, EventArgs e)
        {
            
            if (attendCall1.Visible == false)
            {
                attendCall1.Visible = true;
                endCall1.Visible = true;
            }
            else if (attendCall2.Visible == false)
            {
                attendCall2.Visible = true;
                endCall2.Visible = true;
            }
            else if (attendCall3.Visible == false)
            {
                attendCall3.Visible = true;
                endCall3.Visible = true;
            }
            else if (attendCall4.Visible == false) {
                attendCall4.Visible = true;
                endCall4.Visible = true;
            }
            else if (attendCall5.Visible == false) {
                attendCall5.Visible = true;
                endCall5.Visible = true;
            }
            else if (attendCall6.Visible==false) {
                attendCall6.Visible = true;
                endCall6.Visible = true;
            }
            callgen.Interval = random.Next(4999,10001);
        }

        private void receivecall1(object sender, EventArgs e)
        {
            callspan.Enabled = true;
            allotServiceLabel.Enabled = true;
        }

        private void endCall1_clicked(object sender, EventArgs e)
        {
            callspan.Enabled = false;
            currentcallminutes = 0;
            currentcallseconds = 0;
            attendCall1.Visible = false;
            endCall1.Visible = false;
        }

        private void incrementspan(object sender, EventArgs e)
        {
            if (currentcallseconds < 60)
            {
                currentcallseconds = currentcallseconds + 1;
            }
            else {
                currentcallminutes += 1;
                currentcallseconds = 0;
            }

            durationLabel.Text = "Duration: 0" + currentcallminutes.ToString() + ":" + currentcallseconds.ToString();
        }

        private void CTWO_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void endCall2_clicked(object sender, EventArgs e)
        {
            callspan.Enabled = false;
            currentcallminutes = 0;
            currentcallseconds = 0;
            attendCall2.Visible = false;
            endCall2.Visible = false;
        }

        private void endCall3_clicked(object sender, EventArgs e)
        {
            callspan.Enabled = false;
            currentcallminutes = 0;
            currentcallseconds = 0;
            attendCall3.Visible = false;
            endCall3.Visible = false;
        }

        private void endCall4_clicked(object sender, EventArgs e)
        {
            callspan.Enabled = false;
            currentcallminutes = 0;
            currentcallseconds = 0;
            attendCall4.Visible = false;
            endCall4.Visible = false;
        }

        private void endCall5_clicked(object sender, EventArgs e)
        {
            callspan.Enabled = false;
            currentcallminutes = 0;
            currentcallseconds = 0;
            attendCall5.Visible = false;
            endCall5.Visible = false;
        }

        private void endCall6_clicked(object sender, EventArgs e)
        {
            callspan.Enabled = false;
            currentcallminutes = 0;
            currentcallseconds = 0;
            attendCall6.Visible = false;
            endCall6.Visible = false;
        }

        private void AllotService_clicked(object sender, EventArgs e)
        {
            EmpAmb_CRUD crud = EmpAmb_CRUD.instance();
            
            if (servicesAlloted % 3 == 0) {
                service = crud.useQueue1();
            }
            else if (servicesAlloted % 3 == 1) {
                service = crud.useQueue2();
            }
            else if (servicesAlloted%3 == 2) {
                service = crud.useQueue3();
            }
            allotServiceLabel.Enabled = false;
            servicesAlloted++;
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.instance().Show();
        }

        private void allotHospLabel_Click(object sender, EventArgs e)
        {

        }
    }
}