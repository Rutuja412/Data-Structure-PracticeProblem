using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Data_Structure
{
    internal class CustomLinkedList<T>
    {

        //For storing the address of first element
        internal Node<T> head;
        //For adding node at the last position
        internal void AddLast(T data)
        {
            Node<T> node = new Node<T>(data);

            //Checking if head is pointing to null value or not
            if (this.head == null)
            {
                //If head is pointing to null then add the entered element as first element
                this.head = node;
            }
            else
            {
                //Declared temporary node temp pointing head
                Node<T> temp = head;

                //while we dont't get next value of node as null
                while (temp.next != null)
                {
                    //temp is moving to next node
                    temp = temp.next;
                }
                //assigning next of last element (here temp) to newly added "node"
                temp.next = node;
            }
            Console.WriteLine(node.data + " appended to the Linked List");
        }
        //For displaying all elements in Linked List
        internal void Display()
        {
            //Temporary node currNode is declared and it is pointing to head
            Node<T> currentNode = head;

            //Linked List empty condition
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            else
            {
                Console.Write("Linked List is : head");

                //while currentNode's value does not become null
                while (currentNode != null)
                {
                    //Printing the data to which currentNode is pointing
                    Console.Write(" -> " + currentNode.data);

                    //we are moving current node to next position/address
                    currentNode = currentNode.next;
                }
                Console.WriteLine();
            }
        }
        internal void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);

            //Checking if head is pointing to null value or not
            if (this.head == null)
            {
                //If head is pointing to null then add the entered element as first element
                this.head = newNode;
            }
            else
            {
                //Assigning newNode's next to the head (i.e. at first position)
                newNode.next = this.head;

                //Now head is pointing to newNode
                head = newNode;
            }
            Console.WriteLine(newNode.data + " added to the Linked List");
        }
        public void RemoveFirst()
        {
           if (head==null)
            {
                Console.WriteLine("linked list is empty");
            }
           else
            {
                Console.WriteLine("first node " + head.data+ "removed from list");
                head = head.next;
            }
        }
        public void RemoveLast()
        {
            Node<T> newNode = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            if (head.next == null)
            {
                this.head = null;
            }
            while (newNode.next.next != null)
            {
                //Move newNode to the next node
                newNode = newNode.next;
            }
            //Remove the reference of the last but one node's next to make it the new last node
            newNode.next = null;
        }
        internal void Search(int data)
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    Console.WriteLine("Given value: " + data + " is present in Linked list");
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
                Console.WriteLine("Given value: " + data + " is not present in Linked list");
        }
       
        public void InsertAfterParticularNode(T addNode, T givenNode)
        {
            Node <T>temp = head;
            while (temp != null)
            {
                if (temp.data.Equals (givenNode))
                {
                    break;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine(givenNode + " not present in linked list");
            }
            else
            {
                Node<T> newNode = new Node<T>(addNode);
                newNode.next = temp.next;
                temp.next = newNode;
            }
           

        }
        public void DeleteInBetweenelement(T node)
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
                return;
            }
            if (head.data.Equals(node))
            {
                head = head.next;
                return;
            }
            Node<T> temp = head;
            while (temp.next != null)
            {
                if (temp.next.data.Equals(node))
                {
                    break;
                }
                temp = temp.next;
            }
            if (temp.next == null)
            {
                Console.WriteLine("Element" + node + "not present in linked list");
            }
            else
            {
                temp.next = temp.next.next;
            }
        }

        public void GetSize()
        {
            int count = 0;
            Node<T> temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("\n\nNumber of node in linkedlist: {0}", count);
        }
        
       
    }

 }



