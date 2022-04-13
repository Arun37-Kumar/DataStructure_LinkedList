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
        public int count = 0;

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
                count++;
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

        //Delete the element
        public void DeleteFirst()
        {
            if( count > 0)
            {
                head = head.next;
                count--;
            }
            else
            {
                Console.WriteLine("No element exist in the linked list");
            }
        }

        static Node removeLastNode(Node head)
        {
            if (head == null)
                return null;

            if (head.next == null)
            {
                return null;
            }

            // Find the second last node
            Node second_last = head;
            while (second_last.next.next != null)
                second_last = second_last.next;

            // Change next of second last
            second_last.next = null;

            return head;
        }

        //Delete last node of the list
        public void deleteLastNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty Linked List");
                return;
            }
            else
            {
                var temp = this.head;
                Node find = null;
                // Find second last node
                while (temp.next != null)
                {
                    find = temp;
                    temp = temp.next;
                }
                if (find == null)
                {
                    // Delete head node of linked list
                    this.head = null;
                    
                }
                else
                {
                    // Set new last node
                    
                    find.next = null;
                }
            }
        }

        //Search an Element
        public bool Search(int data)
        {
            int index = 0;
            Node temp = head;
            while (temp != null)
            {
                index++;
                if (temp.data.Equals(data))
                {
                    Console.WriteLine(data + " is Found At Index = " + index);
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        //Inserting data into a particular position
        public void Insert(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }

        //Deleting data
        public void Delete(int data)
        {
            Node temp = head;
            Node previous = null;
            if (temp != null && temp.data == data)
            {
                head = temp.next;
            }
            while (temp != null && temp.data != data)
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp == null)
            previous.next = temp.next;
        }


    }
}
