using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    internal class BuiltInStack
    {
        public void StackDemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(20);
            stack.Push(40);
            stack.Push(60);
            stack.Push(80);

            //Read elements 
            foreach(int item in stack)
            {
                Console.WriteLine(item + "");
            }
            int top= stack.Peek();
            Console.WriteLine("Top element is : " + top);
            Console.WriteLine("Elements after pop:80 is popped");
            //remove first
            stack.Pop();
            foreach (int item in stack)
            {
                Console.WriteLine(item + "");
            }

        }
    }
}
