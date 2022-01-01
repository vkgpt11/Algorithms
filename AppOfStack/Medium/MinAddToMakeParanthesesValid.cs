using System;
using System.Collections.Generic;
using System.Text;

namespace AppOfStack.Medium
{
    class MinAddToMakeParanthesesValid
    {
        public int MinAddToMakeValid(string S)
        {
            Stack<char> stackS = new Stack<char>();

            foreach (var item in S.ToCharArray())
            {
                if (stackS.Count > 0 && stackS.Peek() == '(' && item == ')')
                {
                    stackS.Pop();
                }
                else
                {
                    stackS.Push(item);
                }
            }
            return stackS.Count;
        }
    }
}
