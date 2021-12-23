using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class Ambulance
    {
        private string ambulanceID;
        private string NumberPlate;
        private VehicleType vehicle;
        public Ambulance next = null;
        public Ambulance prev = null;
        public Ambulance(string ambulanceID,string NumberPlate,VehicleType vehicle) {
            this.ambulanceID = ambulanceID;
            this.NumberPlate = NumberPlate;
            this.vehicle = vehicle;
        }
        public string getambulanceID() {
            return this.ambulanceID;
        }
        public string getNumberPlate() {
            return this.NumberPlate;
        }
        public VehicleType getvehicletype() {
            return this.vehicle;
        }
    }
}
