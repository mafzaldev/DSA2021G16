using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class AreaNode
    {
        private string name;
        public Array Neighbours;
        public AreaNode(string name) {
            this.name = name;
        }
    }
}