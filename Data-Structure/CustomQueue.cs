using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Data_Structure
{
    internal class CustomQueue<T>
    {
        public Node<T> head = null;
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Node<T> temp = this.head;
            this.head = this.head.next;
            Console.WriteLine(" {0} deserted from Queue", temp.data);
        }

    }
}
