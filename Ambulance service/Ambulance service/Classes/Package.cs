using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service.Classes
{
    class Package
    {
        private Ambulance Amb;
        private employee emt;
        private employee driver;
        public Package(Ambulance Amb, employee emt, employee driver) {
            this.Amb = Amb;
            this.emt = emt;
            this.driver = driver;
        }
        public Ambulance getAmbulance() {
            return this.Amb;
        }
        public employee getEMT() {
            return this.emt;
        }
        public employee getDriver() {
            return this.driver;
        }
    }
}
