using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    internal class CustomStack<T>
    {
        public Node<T> top;
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("{0} is inserted into Stack", top.data);
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("{0} is inserted into Stack", top.data);
            }
        }
        
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("{0} is Removed from the Stack", top.data);
                top = top.next;
            }
        }
        public void isEmpty()
        {
            while (top != null)
            {
                Peek();
                Pop();
            }
        }
        public void Display()
        {
            if (top == null)
                Console.WriteLine("Stack is Empty");
            else
            {
                Console.WriteLine("STACK");
                Node<T> temp = top;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}

