using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_service
{
    class HospitalBST
    {
        private Hospital root;
        //public void InOrderTraversal(){}
        public Hospital search(Hospital root, string name)
        {
            if (root == null || name == root.gethospitalname())
            {
                return root;
            }
            if (string.Compare(name,root.gethospitalname())<0)
            {
                return search(root.left, name);
            }
            return search(root.right, name);
        }
        //public void maximum(){}
        //public void minimum(){}
        public void insertion(Hospital x, Hospital newhosp)
        {
            Hospital y = null;
            while (x != null)
            {
                y = x;
                if (newhosp.getbeddings() < x.getbeddings())
                {
                    x = x.left;
                }
                else
                {
                    x = x.right;
                }
            }
            newhosp.parent = y;
            if (y == null)
            {
                root = newhosp;
            }
            else if (newhosp.getbeddings() < y.getbeddings())
            {
                y.left = newhosp;
            }
            else
            {
                y.right = newhosp;
            }
        }
        //public void deletion(){}
        //public void transplant(){}
    }
}
