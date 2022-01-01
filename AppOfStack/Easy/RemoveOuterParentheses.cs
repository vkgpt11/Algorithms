using System;
using System.Collections.Generic;
using System.Text;

namespace AppOfStack
{
    class RemoveOuterParentheses
    {
        public string Remove(string s)
        {
            Stack<char> stack = new Stack<char>();
            List<int> listIndexes = new List<int>();
            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (stack.Count == 0)
                {
                    listIndexes.Add(i);
                    stack.Push(chars[i]);
                    continue;
                }
                if (stack.Peek() == '(' && chars[i] == ')')
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        listIndexes.Add(i);
                    }
                }
                else if (stack.Peek() == ')' && chars[i] == '(')
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        listIndexes.Add(i);
                    }
                }
                else
                {
                    stack.Push(chars[i]);
                }
            }

            // Build string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listIndexes.Count; i=i+2)
            {
                int startingIndex = listIndexes[i] + 1;
                int endIndex = listIndexes[i + 1];
                int length = endIndex - startingIndex;
                sb.Append(s.Substring(listIndexes[i] + 1,  length ));
            }
            return sb.ToString();
        }
    }
}
