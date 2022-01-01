using System;
using System.Collections.Generic;
using System.Text;

namespace StringAlgorithms.Math
{
    class DP_FibonacciSeries
    {
        public static int  Fib(int n)
        {
            /* Declare an array to store Fibonacci numbers. */
            int[] x = new int[n + 1];
            int i;

            /* 0th and 1st number of the series are 0 and 1*/
            x[0] = 0;
            x[1] = 1;

            for (i = 2; i <= n; i++)
            {
                /* Add the previous 2 numbers in the series 
                 and store it */
                x[i] = x[i - 1] + x[i - 2];
            }

            return x[n];
        }
    }
}
