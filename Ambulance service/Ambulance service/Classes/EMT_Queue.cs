using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class EMT_Queue
    {
        private employee front = null;
        private employee rear = null;
        public void enqueue(employee emt)
        {
            if (this.rear == null)
            {
                this.rear = emt;
                this.front = emt;
            }
            else
            {
                this.rear.next = emt;
                emt.prev = this.rear;
                this.rear = emt;
            }
        }

        public employee dequeue()
        {
            if (this.front == null)
            {
                return null;
            }
            employee emt = this.front;
            this.front = this.front.next;
            if (this.front == null)
            {
                this.rear = null;
            }
            return emt;
        }
        public void deleteNode(employee emp) {
            employee node = front;
            bool deleted = false;
            while (node!=null && deleted == false) {
                if (node==emp) {
                    node.prev.next = node.next;
                    node.next.prev = node.prev;
                    node.next = null;
                    node.prev = null;
                    deleted = true;
                }
            }
        }
    }
}
