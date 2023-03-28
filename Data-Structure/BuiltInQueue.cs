using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    internal class BuiltInQueue
    {
        public void ShowQueueDemo()
        {
            //Create Queue & add elements
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            foreach(int element in queue)
            {
                Console.WriteLine(element + "");
            }
            //Remove element
            queue.Dequeue();
            Console.WriteLine("Updating queue");
            foreach (int element in queue)
            {
                Console.WriteLine(element + "");
            }
            //
            bool check = queue.Contains(40);
            if(check)
            {
                Console.WriteLine("40 is present in queue");
            }
            else
            {
                Console.WriteLine("data not found");
            }

        }
    }
}
