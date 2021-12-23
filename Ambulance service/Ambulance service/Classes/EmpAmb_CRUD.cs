using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Ambulance_service
{
    class EmpAmb_CRUD
    {
        private static int Ambulancecount = 0;
        private static EmpAmb_CRUD empcrud;
        private static Classes.Package[] AllServices = new Classes.Package[1000];
        
        private EmpAmb_CRUD() { }
        
        public static EmpAmb_CRUD instance(){
            if (empcrud==null) {
                empcrud = new EmpAmb_CRUD();
            }
            return empcrud;
        }
        
        public static EMT_Queue AllEMT = new EMT_Queue();
        public static Driver_Queue AllDrivers = new Driver_Queue();
        public static employee[] AllEmployees = new employee[39000];  
        private int employeecounter = 0;
        public static AmbulanceQueue AmbulanceStation1 = new AmbulanceQueue();
        public static AmbulanceQueue AmbulanceStation2 = new AmbulanceQueue();
        public static AmbulanceQueue AmbulanceStation3 = new AmbulanceQueue();
        //
        //function that creates an employee type object and adds it to the appropriate data structure
        //
        public void addemp(string EmpNameTxtBox, string usernameTxtBox, string passwordTxtBox, string PhoneNumTxtBox, string cnicTxtBox, string EmpTypeBox, string EmpShift, int score, int attendance) {
            designation design = getemptype(EmpTypeBox);
            ShiftTime shift = getShift(EmpShift);

            employee emp1 = new employee(EmpNameTxtBox, usernameTxtBox, passwordTxtBox, PhoneNumTxtBox, cnicTxtBox, shift, design, score, attendance);
            
            if (designation.EMT == design)
            {
                AllEMT.enqueue(emp1);
            }
            else if (design == designation.Driver){
                AllDrivers.enqueue(emp1);
            }
            AllEmployees[employeecounter] = emp1;
            employeecounter++;
        }
        //
        //determines the employee type for object creation
        //
        private designation getemptype(string EmpTypeBox)
        {
            if (EmpTypeBox == designation.CTWO.ToString())
            {
                return designation.CTWO;
            }
            else if (EmpTypeBox == designation.EMT.ToString())
            {
                return designation.EMT;
            }
            else if (EmpTypeBox == designation.Doctor.ToString())
            {
                return designation.Doctor;
            }
            return designation.Driver;

        }
        //
        //determines the shift of the employee for object creations
        //
        private ShiftTime getShift(string EmpShift)
        {
            if (EmpShift == ShiftTime.Day.ToString())
            {
                return ShiftTime.Day;
            }
            if (EmpShift == ShiftTime.Evening.ToString())
            {
                return ShiftTime.Evening;
            }
            return ShiftTime.Night;
        }
        //
        //adds an ambulance to the database
        //
        public void addambulance(string ambulanceID,string numberplate,VehicleType vantype) {
            Ambulance amb = new Ambulance(ambulanceID, numberplate, vantype);
            if (Ambulancecount % 3 == 0)
            {
                AmbulanceStation1.enqueue(amb);
            }
            else if (Ambulancecount % 3 == 1)
            {
                AmbulanceStation2.enqueue(amb);
            }
            else {
                AmbulanceStation3.enqueue(amb);
            }
            Ambulancecount++;
        }
        //
        //deletes the employee from the database
        //
        public void deleteemp(string empname) {
            for (int i = 0; i<employeecounter;i++) {
                if(AllEmployees[i].getname() == empname){
                    if (AllEmployees[i].getemptype() == designation.EMT) {
                        //remove employee from emt queue
                        AllEMT.deleteNode(AllEmployees[i]);
                    }
                    else if (AllEmployees[i].getemptype() == designation.Driver) {
                        //remove employee from driver queue
                        AllDrivers.deleteNode(AllEmployees[i]);
                    }
                    AllEmployees[i] = null;
                    rotateEmployees(i);
                }
            }
        }
        //
        //shifts the array of the employees when one of the employee is deleted
        //
        private void rotateEmployees(int index) {
            for (int idx = index; idx < employeecounter-1; idx++) {
                AllEmployees[idx] = AllEmployees[idx + 1];
            }
        }
        //
        //deletes the ambulance from the database
        //
        public void deleteambulance(string ID) {
            bool found = false;
            Ambulance amb = AmbulanceStation1.front;
            Ambulance deletenode = null;
            AmbulanceQueue station = null;
            while (amb!=null && found == false) {
                if (amb.getambulanceID() == ID) {
                    found = true;
                    deletenode = amb;
                    station = AmbulanceStation1;
                }
                amb = amb.next;
            }
            if (found == false)
            {
                amb = AmbulanceStation2.front;
                while (amb != null && found == false)
                {
                    if (amb.getambulanceID() == ID)
                    {
                        found = true;
                        deletenode = amb;
                        station = AmbulanceStation2;
                    }
                    amb = amb.next;
                }
            }
            if (found == false) { 
                amb = AmbulanceStation3.front;
                while (amb != null && found == false)
                {
                    if (amb.getambulanceID() == ID)
                    {
                        found = true;
                        deletenode = amb;
                        station = AmbulanceStation3;
                    }
                    amb = amb.next;
                }
            }
            if (found == true) {
                station.DeleteNode(deletenode);
            }
        }
        //
        //uses the Ambulance queue 1 to form a service package
        //
        public Classes.Package useQueue1() {
            Ambulance amb = AmbulanceStation1.dequeue();
            employee emt = AllEMT.dequeue();
            employee driver = AllDrivers.dequeue();
            Classes.Package service = new Classes.Package(amb,emt,driver);
            AllServices[CTWO.servicesAlloted] = service;
            return service;
        }
        //
        //uses the Ambulance queue 2 to form a service package
        //
        public Classes.Package useQueue2() {
            Ambulance amb = AmbulanceStation2.dequeue();
            employee emt = AllEMT.dequeue();
            employee driver = AllDrivers.dequeue();
            Classes.Package service = new Classes.Package(amb, emt, driver);
            AllServices[CTWO.servicesAlloted] = service;
            return service;
        }
        //
        //uses the Ambulance queue 3 to form a service package
        //
        public Classes.Package useQueue3() {
            Ambulance amb = AmbulanceStation3.dequeue();
            employee emt = AllEMT.dequeue();
            employee driver = AllDrivers.dequeue();
            Classes.Package service = new Classes.Package(amb, emt, driver);
            AllServices[CTWO.servicesAlloted] = service;
            return service;
        }

        public employee[] getAllEmployees()
        {
            return AllEmployees;
        }

    }
}