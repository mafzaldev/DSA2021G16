using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class AmbulanceQueue
    {
        public Ambulance front = null;
        public Ambulance rear = null;
        public void enqueue(Ambulance amb)
        {
            if (this.rear == null)
            {
                this.rear = amb;
                this.front = amb;
            }
            else
            {
                this.rear.next = amb;
                amb.prev = this.rear;
                this.rear = amb;
                
            }
        }
        public Ambulance dequeue()
        {
            if (this.front == null)
            {
                return null;
            }
            Ambulance amb = this.front;
            this.front = this.front.next;
            if (this.front == null)
            {
                this.rear = null;
            }
            return amb;
        }
        public int getnumberofambulances() {
            Ambulance amb = front;
            int count = 0;
            while (amb != null) {
                count++;
                amb = amb.next;
            }
            return count;
        }
        public void DeleteNode(Ambulance amb) {
            Ambulance node = front;
            bool deleted = false;
            while (node!=null && deleted==false) {
                if (node==amb) {
                    node.prev.next = node.next;
                    node.next.prev = node.prev;
                    node.prev = null;
                    node.next = null;
                    deleted = true;
                }
            }
        }
    }
}
