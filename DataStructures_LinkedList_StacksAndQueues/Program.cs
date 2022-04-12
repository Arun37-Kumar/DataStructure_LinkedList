using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_LinkedList_StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Section !");

            LinkedList list = new LinkedList();

            // UC1
            //list.AddNode(56);
            //list.AddNode(30);
            //list.AddNode(70);

            //UC2
            list.AddNode(56);
            list.AddNode(30);
            list.AddNode(70);
            Console.WriteLine("The elements in linked list are : ");
            list.Display();

            //UC3
            
            Console.WriteLine();
            //list.Insert(2,30);

            list.DeleteFirst();
            list.Display();
            Console.ReadLine();
        }
    }
}
