using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
     public class LinkedList
     {
            internal Node head;
            internal void Add(int data)
            {
                Node node = new Node(data);
                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine("{0} Inseerted Into Linked List", node.data);
            }
            internal void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Linked List Empty");
                    return;
                }
                while (temp.next != null)
                {
                    Console.WriteLine(temp.data + "");
                    temp = temp.next;
                }
            }
            internal Node InsertAtParticularPosition(int position, int data)
            {
                if (position < 1)
                    Console.WriteLine("Invalid Positin");
                if (position == 1)
                {
                    var newNode = new Node(data);
                    newNode.next = this.head;
                    head = newNode;
                }
                else
                {
                    while (position-- != 0)
                    {
                        if (position == 1)
                        {
                            Node node = new Node(data);
                            node.next = this.head.next;
                            head.next = node;
                            break;
                        }
                        head = head.next;
                    }
                    if (position != 1)
                        Console.WriteLine("Position Out of range");
                }
                Console.WriteLine("Inserted Value is" + head);
                return head;
            }
            internal void AddInReverseOrder(int data)
            {
                Node newNode = new Node(data);
                if (this.head == null)
                {
                    this.head = newNode;
                }
                else
                {
                    Node temp = this.head;
                    head = newNode;
                    head.next = temp;
                }
                Console.WriteLine("Reverse Order");
            }
            internal Node RemoveFirstNode()
            {
                if (this.head == null)
                {
                    return null;
                }
                this.head = this.head.next;
                return this.head;
            }
            internal Node RemoveLastNode()
            {
                if (head == null)
                {
                    return null;
                }
                if (head.next == null)
                {
                    return null;
                }
                Node newNode = head;
                {
                    while (newNode.next.next != null)
                    {
                        newNode = newNode.next;
                    }
                    newNode = newNode.next;
                }
                newNode.next = null;
                return head;

            }
            internal int search(int value)
            {
                Node node = this.head;
                int count = 0;
                while (node != null)
                {
                    if (node.data == value)
                    {
                        return count;
                    }
                    node = node.next;
                    count++;
                }
                return -1;
            }
            internal void DeleteNodeAtparticularPosition(int position)
            {
                if (this.head == null)
                {
                    Console.WriteLine("Linked List Is Empty");
                    return;
                }
                Node temp = this.head;
                if (position == 0)
                {
                    this.head = temp.next;
                    return;

                }
                for (int i = 0; temp != null && i < position - 1; i++)
                {
                    temp = temp.next;
                }
                if (temp == null || temp.next == null)
                {
                    return;
                }
                Node next = temp.next.next;
                temp.next = next;
            }
            internal void size()
            {
                Node temp = this.head;
                int count = 0;
                if (temp == null)
                {
                    Console.WriteLine("Linked List Is empty");
                    return;
                }
                while (temp != null)
                {
                    Console.WriteLine(temp.data + "");
                    temp = temp.next;
                    count++;
                }
                Console.WriteLine("Length List " + " " + count);
            }
     }
    
}
