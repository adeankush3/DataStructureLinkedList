using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    internal class Stack
    {
        public Node top;

        public Stack()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            System.Console.WriteLine(data + " pushed to stack.");
        }

        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                System.Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        public void Peek()
        {
            if (this.top == null)
            {
                System.Console.WriteLine("stack is empty");
                return;
            }
            System.Console.WriteLine(this.top.data + "  is the element is top of the stack");
        }

        public void Pop()
        {
            if (this.top == null)
            {
                System.Console.WriteLine("Stack is empty");
                return;
            }
            System.Console.WriteLine(this.top.data + " poped from the stack");
            this.top = this.top.next;
        }

        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            System.Console.WriteLine("Stack is empty now");
        }
    }
}
