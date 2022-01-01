using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmClass
{
    public class TwoSumProblem
    {
        static void Main()
        {
            int[] array = { 1, 6, 8, 2, 3 };
            int target = 13;
            bool isPresent = true;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent)
                {
                    break;
                }
            }
            if (isPresent)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
