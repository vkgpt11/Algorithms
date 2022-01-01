using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmClass
{
    class TriplateProblem
    {
        static void Main()
        {
            int[] arrInput = { 2, 2, 3, 3, 4, 6, 4, 6, 4 };
            int temp = arrInput[0];
            for (int i = 1; i < arrInput.Length; i++)
            {
                temp = temp ^ arrInput[i];
            }
            Console.WriteLine(temp);
        }
    }
}
