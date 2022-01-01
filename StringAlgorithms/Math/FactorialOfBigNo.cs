using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace StringAlgorithms.Math
{
    class FactorialOfBigNo
    {
        public static BigInteger Fact(int number)
        {
            BigInteger x = 1;
            for (int i = 1; i <= number; i++)
            {
                x = x * i;
            }
            return x;
        }
    }
}
