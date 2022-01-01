using System;
using System.Collections.Generic;
using System.Text;

namespace StringAlgorithms.Bitwise
{
    class CountOnes
    {
        public static int CountSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }

      
    }
}
