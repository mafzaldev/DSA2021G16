using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class Driver_Queue
    {
        private employee front = null;
        private employee rear = null;
        public void enqueue(employee driver)
        {
            if (this.rear == null)
            {
                this.rear = driver;
                this.front = driver;
            }
            else
            {
                this.rear.next = driver;
                this.rear = driver;
            }
        }
        public employee dequeue()
        {
            if (this.front == null)
            {
                return null;
            }
            employee driver = this.front;
            this.front = this.front.next;
            if (this.front == null)
            {
                this.rear = null;
            }
            return driver;
        }
        public void deleteNode(employee emp)
        {
            employee node = front;
            bool deleted = false;
            while (node != null && deleted == false)
            {
                if (node == emp)
                {
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
