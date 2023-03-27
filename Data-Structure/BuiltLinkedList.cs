using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    internal class BuiltLinkedList
    {
        public void DemoLinkedList()
        {
            LinkedList<string> list= new LinkedList<string>();
            list.AddLast("Apple");
            list.AddLast("PineApple");
            list.AddLast("Banana");
            list.AddLast("Orange");
            list.AddFirst("Lemon");
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
             if (list.Remove("Lemon"))
            {
                Console.WriteLine("Removed successfully");
            }
            else
            {
                Console.WriteLine("data not found");
            }
            Console.WriteLine("Apple is removed");
            list.RemoveFirst();
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            LinkedListNode<string>BananaNode  = list.Find("Banana");
            if (BananaNode != null)
            {
                list.Remove(BananaNode);
                Console.Write("Banana is removed ---");
                foreach (var element in list)
                {
                    Console.Write(element + ", ");
                }
                
            }



        }
    }
}
