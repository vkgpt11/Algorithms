using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Bitwise
{
    class FindWithoutPairNumber
    {
        public static int Find(int[] numbers)
        {
            int retnumbers = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                retnumbers = retnumbers^ numbers[i];
            }
            return retnumbers;
        }
    }
}
