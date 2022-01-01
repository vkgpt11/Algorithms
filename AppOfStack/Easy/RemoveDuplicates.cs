using System;
using System.Collections.Generic;
using System.Text;

namespace AppOfStack
{
    class RemoveDuplicates
    {
        public string Remove(String s)
        {
            Stack<char> stack = new Stack<char>();
            var chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(chars[i]);
                    continue;
                }
                if (stack.Peek() == chars[i])
                {
                    stack.Pop();
                }
                else
                {

                    stack.Push(chars[i]);

                }
            }
            var builder = new StringBuilder();
            Stack<char> stack2 = new Stack<char>();

            while (stack.Count > 0)
            {
                stack2.Push(stack.Pop());

            }
            while (stack2.Count > 0)
            {
                builder.Append(stack2.Pop());
            }
            return builder.ToString();
        }
    }
}
