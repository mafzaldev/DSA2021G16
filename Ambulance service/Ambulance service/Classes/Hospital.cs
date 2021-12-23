using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ambulance_service
{
    class Hospital
    {
        public Hospital left = null;
        public Hospital right = null;
        public Hospital parent = null;
        private string username;
        private string password;
        private string location;
        private string HospitalName = "";
        private int beddings;
        private ArrayList allottedECFs = new ArrayList();
        public Hospital(string location,string name, int beddings) {
            this.location = location;
            this.HospitalName = name;
            this.beddings = beddings;
        }
        public string gethospitalname(){
            return this.HospitalName;
        }
        public int getbeddings() {
            return this.beddings;
        }
        public string getlocation() {
            return this.location;
        }
        /*
        public ECF getallottedForms() {
            return new ECF("","",0);
        }
        */
        public void appendECFlist() { 
        }
        public string getpassword() {
            return this.password;
        }
        public string getusername() {
            return this.username;
        }

    }
}
