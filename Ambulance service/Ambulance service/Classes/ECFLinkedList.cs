using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service.Classes
{
    class ECFLinkedList
    {
        private ECF head;
        private static ECFLinkedList ListInstance = null;
        private ECFLinkedList()
        {
            head = null;
        }

        public ECF getHead()
        {
            return head;
        }

        public static ECFLinkedList instance()
        {
            if (ListInstance == null)
            {
                ListInstance = new ECFLinkedList();
            }
            return ListInstance;
        }

        public void insertECF(ECF ECFInstance)
        {
            ECF ECFHead = head;
            if (head == null)
            {
                head = ECFInstance;
            }
            else
            {
                while (ECFHead.getNext() != null)
                {
                    ECFHead = ECFHead.getNext();
                }
                ECFHead.setNext(ECFInstance);
            }
        }

        public void deleteECF(string victimName)
        {
            ECF ECFHead = head;
            if (head == null) { }
            else
            {
                while (ECFHead.getNext() != null)
                {
                    if (ECFHead.getNext().getVictimName() == victimName)
                    {
                        ECFHead.setNext(ECFHead.getNext().getNext());
                    }
                    ECFHead.setNext(ECFHead.getNext());
                }
            }
        }

        public ECF searchECF(int emergencyCode)
        {
            ECF ECFHead = head;
            while (ECFHead != null && emergencyCode != ECFHead.getEmergencyCode())
            {
                ECFHead = ECFHead.getNext();
            }
            return ECFHead;
        }

        private void displayList()
        {
            ECF ECFHead = head;
            while (ECFHead != null)
            {
                Console.WriteLine(ECFHead.getCallerName());
                ECFHead = ECFHead.getNext();
            }
        }
    }
}