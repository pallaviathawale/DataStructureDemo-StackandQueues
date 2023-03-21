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

        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);

        }
        internal void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value Popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        internal void IsEmpty()
        {
            while(this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
