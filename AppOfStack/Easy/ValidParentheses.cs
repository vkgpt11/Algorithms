using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppOfStack
{
    class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var dictParantheses = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            for (int i = 0; i < s.Length; i++)
            {
                var current = s[i];
                if (dictParantheses.Keys.Contains(current))
                {
                    stack.Push(current);
                }
                else if (dictParantheses.Values.Contains(current))
                {
                    if (stack.Count > 0 && dictParantheses[stack.Peek()] == current)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            return stack.Count > 0 ? false : true;
        }
    }
}
