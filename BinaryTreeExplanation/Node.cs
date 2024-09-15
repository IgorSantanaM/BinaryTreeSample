using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinaryTreeExplanation
{
    public class Node
    {
        public int value { get; set; }
        public Node leftChild { get; set; }

        public Node rightChild { get; set; }

        public Node(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"Node = {value}";
        }
    }
}
