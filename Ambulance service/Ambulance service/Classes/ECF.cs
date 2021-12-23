using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class ECF
    {
        private int emergencyCode;
        private string callerName;
        private string location;
        private string phonenumber;
        private string hospitalName;
        private string victimName;
        private string natureOfEmergency;
        private float BodyTemp;
        private string BloodPressure;
        private int pulseRate;
        private int respirationRate;
        private float height;
        private float weight;
        private bool status = true;
        private Classes.Package service;
        private ECF Next;

        public ECF(int emergencycode, string callername, string location, string phonenumber, string nature, Classes.Package service, string hospName) {
            this.callerName = callername;
            this.location = location;
            this.phonenumber = phonenumber;
            this.natureOfEmergency = nature;
            this.emergencyCode = emergencycode;
            this.hospitalName = hospName;
            this.Next = null;
            this.service = service;
        }

        public int getEmergencyCode() { return this.emergencyCode; }
        public string getCallerName() { return this.callerName; }
        public string getLocation() { return this.location; }
        public string getPhoneNumber() { return this.phonenumber; }
        public string getHospitalName() { return this.hospitalName; }
        public string getVictimName() { return this.victimName; }
        public string getNature() { return this.natureOfEmergency; }
        public ECF getNext(){ return this.Next; }
        public void setNext(ECF nextECF) { this.Next = nextECF; }
        public void setService(Classes.Package service) { this.service = service;  }
        public bool getstatus() { return this.status; }
    }
}
