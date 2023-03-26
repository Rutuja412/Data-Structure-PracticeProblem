using System;

namespace Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Data structure");
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.Display();
            Console.WriteLine("-------------");
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.RemoveFirst();
            list.RemoveLast();

            list.Search(2);
            list.InsertAfterParticularNode(40, 10);
            list.DeleteInBetweenelement(40);
            list.GetSize();
            list.Display();
        }
    }
}
