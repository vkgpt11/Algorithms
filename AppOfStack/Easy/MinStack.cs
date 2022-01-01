using System;
using System.Collections.Generic;
using System.Text;

namespace AppOfStack
{
    class MinStack
    {
        Stack<int> stack = new Stack<int>();
        Stack<int> minStack = new Stack<int>();

        public MinStack()
        {

        }

        public void Push(int x)
        {
            stack.Push(x);
            if (minStack.Count==0 || minStack.Peek() >= x)
            {
                minStack.Push(x);
            }
        }

        public void Pop()
        {
            if (minStack.Peek()==stack.Peek())
            {
                minStack.Pop();
            }
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
    }
}
