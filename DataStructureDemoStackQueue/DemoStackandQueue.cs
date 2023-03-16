using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemoStackQueue
{
    public class StackLinkedList
    {
        private Node top;
        public StackLinkedList() //consturctor
        {
            this.top = null;
        }
            internal void Push(int Value)//Method to add elements in stack
            {
                Node node = new Node(Value);
                if (this.top == null)
                {
                    node.next = null;
                }
                else
                {
                    node.next = this.top;
                }
                this.top = node;
                Console.WriteLine("{0} Push to the stack", Value);
            }
        public void Display()
        {
            Node temp = this.top;
            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            
        }
    }
}
