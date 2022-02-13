using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Dtucture In Linked List");
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            list.Display();

            list.InsertAtParticularPosition(2, 70);

            list.AddInReverseOrder(30);

            list.RemoveFirstNode();

            list.RemoveLastNode();

            list.search(2);

            list.DeleteNodeAtparticularPosition(2);

            list.size();
        }
    }
}
