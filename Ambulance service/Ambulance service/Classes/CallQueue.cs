using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class CallQueue
    {
        private Call front;
        private Call rear;
        public void enqueue(Call callinstance) {
            if (this.rear == null)
            {
                this.rear = callinstance;
                this.front = callinstance;
            }
            else
            {
                this.rear.next = callinstance;
                callinstance.prev = this.rear;
                this.rear = callinstance;

            }
        }
        public Call dequeue() {
            if (this.front == null)
            {
                return null;
            }
            Call node = this.front;
            this.front = this.front.next;
            if (this.front == null)
            {
                this.rear = null;
            }
            return node;
        }
    }
}
