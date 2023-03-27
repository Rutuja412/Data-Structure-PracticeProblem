using System;

namespace Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Data structure");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.Custom Linked List \n2,Custom Stack \n3 Custom Queue");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CustomLinkedList<int> list = new CustomLinkedList<int>();
                    list.AddLast(56);
                    list.AddLast(30);
                    list.AddLast(70);
                    list.Display();
                    Console.WriteLine("-------------");
                    list.AddFirst(1);
                    list.AddFirst(2);
                    list.AddFirst(3);
                    list.RemoveFirst();
                    list.RemoveLast();

                    list.Search(30);
                    list.InsertAfterParticularNode(40, 30);
                    list.DeleteInBetweenelement(40);
                    list.GetSize();
                    list.Display();
                    break;
                    case 2:
                    CustomStack<int> stack = new CustomStack<int>();
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    stack.Pop();
                    stack.Display();
                    stack.Peek();
                    stack.Display();
                    stack.isEmpty();
                    stack.Display();
                    break;
                case 3:
                    CustomQueue<int> queue = new CustomQueue<int>();
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    Console.WriteLine("\n");
                    Console.WriteLine("Sequence of queue are: ");
                    Console.WriteLine("----------------------------");
                    queue.Display();
                    Console.WriteLine("\n");
                    queue.Dequeue();
                    queue.Dequeue();
                    Console.WriteLine("----------------------------");
                    queue.Display();
                    Console.WriteLine("\n");
                    break;
            }
        }
    }
}
