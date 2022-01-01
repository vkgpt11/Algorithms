using System;
using System.Collections.Generic;
using System.Text;

namespace AppOfStack
{
    class BaseballCalculatePoints
    {
        public int CalPoints(string[] ops)
        {
            var stack = new Stack<int>();
            var sum = 0;

            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i] == "D")
                {
                    stack.Push(stack.Peek() * 2);
                }
                else if (ops[i] == "C")
                {
                    stack.Pop();
                }
                else if (ops[i] == "+")
                {
                    var x = stack.Pop();
                    var y = stack.Peek();
                    stack.Push(x);
                    stack.Push(x + y);
                }
                else
                {
                    stack.Push(Convert.ToInt32(ops[i]));
                }
            }

            while (stack.Count > 0)
            {
                sum = sum + stack.Pop();
            }
            return sum;
        }
    }
}
