using System;
using System.Collections.Generic;
using System.Text;

namespace AppOfStack
{
    /// <summary>
    /// 1. if stack is empty or current value is equal to bigger than the top of stack
    ///     - Add to stack
    /// 2. Otherwise keep removing from stack till a number which is smaller or equal than current is found
    /// 3. Calculate the area everytime you remove from stack
    ///     if stack is empty
    ///         area = input[top]*i
    ///     else 
    ///         area = input[top]*(i-stack.top-1)
    /// </summary>
    class LargestAreaUnderHistogram
    {
        public int Calcuate(List<int> list)
        {
            int maxArea = 0;

            Stack<int> positionStack = new Stack<int>();
            for (int i = 0; i < list.Count;)
            {
                int area;
                if (positionStack.Count == 0 || list[i] >= positionStack.Peek())
                {
                    positionStack.Push(i++);
                    area = list[positionStack.Peek()] * i;
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
                else
                {
                    while (positionStack.Count == 0 && list[i] <= list[positionStack.Peek()])
                    {
                        area = list[positionStack.Peek()] * (i - positionStack.Peek() - 1);
                        if (area > maxArea)
                        {
                            maxArea = area;
                        }
                        positionStack.Pop();

                    }

                }
            }
            return maxArea;
        }
    }
}
