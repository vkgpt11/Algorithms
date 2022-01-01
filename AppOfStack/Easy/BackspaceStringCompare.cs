using System;
using System.Collections.Generic;
using System.Text;

namespace AppOfStack.Easy
{
    class BackspaceStringCompare
    {
        public bool BackspaceCompare(string S, String T)
        {
            var stackS = ParseString(S);
            var stackT = ParseString(T);
            while (stackS.Count > 0 && stackT.Count > 0)
            {
                if (stackS.Pop() != stackT.Pop())
                {
                    return false;
                }
            }
            if (stackS.Count != 0 || stackT.Count != 0)
            {
                return false;
            }


            return true;
        }

        private Stack<char> ParseString(string S)
        {
            Stack<char> stackS = new Stack<char>();

            foreach (var item in S.ToCharArray())
            {
                if (item != '#')
                {
                    stackS.p.Push(item);
                }
                else if (stackS.Count > 0)
                {
                    stackS.Pop();
                }
            }
            return stackS;
        }
    }
}
