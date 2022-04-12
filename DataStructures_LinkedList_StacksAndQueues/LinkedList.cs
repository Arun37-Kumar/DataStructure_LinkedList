using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_LinkedList_StacksAndQueues
{
    class LinkedList
    {
        // head position
        internal Node head;

        //Add the node
        internal void AddNode(int data)
        {
            Node node = new Node(data);

            if(head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;   
            }
            Console.WriteLine("{0} inserted into Linked List.", node.data);
        }

        //Display the Elements
        public void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked List is empty.");
                return;
            }
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public Node Insert(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position!");

            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while(position-- != 0)
                {
                    if(position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                    }
                    head = head.next;
                }
                if (position == 1)
                {
                    Console.WriteLine("Position out of range.");
                }
            }
            Console.WriteLine("Inserted value is : " + head);
            return head;
        }
    }
}
