using System;
using System.Collections.Generic;
using System.Text;

namespace AppOfStack
{
    class StackUsingQueue
    {
        private readonly Queue<int> items = new Queue<int>();

        public int Pop()
        {
            if (items.Count == 0)
            {
                Console.Write("Stack is empty");
            }
            return items.Dequeue();
        }

        public void Push(int newItem)
        {
            items.Enqueue(newItem);
            for (int i = 1; i < items.Count; i++)
            {
                items.Enqueue(items.Dequeue());
            }
        }

        public void PrintStack()
        {
            while (items.Count!=0)
            {
                Console.Write(items.Dequeue() + " ");
            }
        }

        public int Peak()
        {
            return items.Peek();
        }
    }
}
