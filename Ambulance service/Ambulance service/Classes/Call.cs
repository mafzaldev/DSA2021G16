using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_service
{
    class Call
    {
        private int phonenumber;
        private int duration;
        public Call next=null;
        public Call prev = null;
        public void starttimer() { 
        }
        public void endtimer() { }

    }
}
