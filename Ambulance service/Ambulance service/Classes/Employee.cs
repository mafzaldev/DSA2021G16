using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class employee
    {
        private string name;
        private string username;
        private string password;
        private string phonenumber;
        private string CNIC;
        private ShiftTime shift;
        private designation desig;
        public bool status = false;
        private int score;
        private int attendance;
        public employee next;
        public employee prev;
        public employee(string name, string username, string password, string phonenumber, string CNIC, ShiftTime shift, designation desig, int score, int attendance) {
            this.name = name;
            this.username = username;
            this.password = password;
            this.phonenumber = phonenumber;
            this.CNIC = CNIC;
            this.shift = shift;
            this.desig = desig;
            this.score = score;
            this.attendance = attendance;
        }

        public string getname(){
            return this.name;
        }
        
        public string getUsername(){
            return this.username;
        }

        public string getPassword(){
            return this.password;
        }

        public designation getemptype() {
            return this.desig;
        }

        public int getScore(){
            return this.score;
        }

        public int getattendance() {
            return this.attendance;
        }

        public void IncrementAttendance() {
            this.attendance++;
        }
    }
}