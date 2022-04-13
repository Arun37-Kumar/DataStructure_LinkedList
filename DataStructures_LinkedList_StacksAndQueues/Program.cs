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

          
            //list.AddNode(56);
            //list.AddNode(30);
            //list.AddNode(70);

        
            list.AddNode(70);
            list.AddNode(30);
            list.AddNode(56);
            Console.WriteLine("The elements in linked list are : ");
            list.Display();
            Console.ReadLine();
        }
    }
}
