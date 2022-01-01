using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    //https://www.hackerearth.com/practice/algorithms/dynamic-programming/introduction-to-dynamic-programming-1/practice-problems/algorithm/avatar-and-his-quest-d939b13f/
    class ProfitMax_1
    {
        static public void Main()
        {
            int[] p = new int[]{ 1, 2, 3, 4, 9, 8 };

            int out_ = solve(p);
            Console.Out.WriteLine(out_);
        }


        static int solve(int[] p)
        {
            int maxSum = 0;
            for (int i = p.Length - 1; i >= 0; i--)
            {
                int sum = p[i];
                int checkMultipleOf = p[i];
                for (int j = i - 1; j > 0; j--)
                {
                    if (checkMultipleOf > p[j] && checkMultipleOf % p[j] == 0 )
                    {
                        Console.Out.WriteLine(checkMultipleOf);

                        checkMultipleOf = p[j];

                        sum = sum + p[j];
                    }
                }
                Console.Out.WriteLine( "Sum:"+sum);
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            return maxSum;
        }
    }
}
