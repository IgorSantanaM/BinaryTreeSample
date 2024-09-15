using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeExplanation
{
    public class Tree
    {
        
        private Node root;

        public void Insert(int value)
        {

            var node = new Node(value);

            if(root == null)
            {
                root = node;
                return;
            }
            var current = root;
            while (true)
            {
                if(value < current.value)
                {
                    if(current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if(current.rightChild is null)
                    {
                        current.rightChild = node; 
                        break;
                    }

                    current = current.rightChild;
                }
            }
        }
        public bool Find(int value)
        {
            var current = root;
            while (current != null)
            {
                if (value < current.value)
                    current = current.leftChild;
                    else if(value > current.value)
                       current = current.rightChild;
               else 
                 return true; 
            }
            return false;
        }
    }
}
