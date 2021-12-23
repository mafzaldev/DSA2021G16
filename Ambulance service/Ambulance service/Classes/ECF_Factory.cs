using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class ECF_Factory
    {
        private static Classes.ECFLinkedList AllECFs = Classes.ECFLinkedList.instance();
        private static ECF_Factory factory;
        private static CallQueue AllCalls;
        private ECF_Factory() { }

        public static ECF_Factory instance(){
            if (factory == null){
                factory = new ECF_Factory();
            }
            return factory;
        }

        public Classes.ECFLinkedList getlist() {
            return AllECFs;
        }

        public void AddtoList(int emergencycode, string nameofcaller, string location, string number, string nature, Classes.Package service, string hospName) {
            ECF ecf = new ECF(emergencycode, nameofcaller, location, number, nature, service, hospName);
            AllECFs.insertECF(ecf);
        }
    }
}