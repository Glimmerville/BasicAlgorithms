using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }

    public class LinkedList
    {
        int length;
        Node firstNode;
        Node lastNode;

        public LinkedList()
        {
            length = 0;
            firstNode = null;
            lastNode = null;
        }

        public int Length {
            get
                {
                return length; 
                }
        }

        public void Add(int v)
        {
            Node node = new Node(v);
            if (lastNode != null)
            {
                lastNode.Next = node;
            } 
            else
            {
                firstNode = node;
            }
            lastNode = node;
            length++;
        }

        public int GetItem(int index)
        {
            Node currentNode = firstNode;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode.Value;
        }
    }
}
