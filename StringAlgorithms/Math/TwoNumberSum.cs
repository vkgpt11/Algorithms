using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Math
{
    class TwoNumberSum
    {
        public static bool Exists(int[] items, int sum)
        {
            bool retValue=false;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = i+1; j < items.Length; j++)
                {
                    if (items[i] + items[j] == sum)
                    {
                        retValue = true;
                        break;
                    }
                }
                if (retValue)
                {
                    break;
                }
            }
            return retValue;
        }

        public static bool ExistsOptimized(int[] items, int sum)
        {
            bool retValue = false;
            HashSet<int> set = new HashSet<int>();

            for (int j = 0; j < items.Length; j++)
            {
                var x = sum - items[j];
                if (set.Contains(x))
                {
                    retValue = true;
                    break;
                }
                set.Add(items[j]);
            }
                
            return retValue;
        }

        public static bool ExistsOptimized2(int[] items, int sum)
        {
            int left = 0;
            int right = items.Length - 1;

            // sort elements 
            Array.Sort(items);

            //Now look for two candidates in sorted array
            while (left < right)
            {
                if(items[left]+items[right]== sum)
                {
                    return true;
                }
                else if (items[left] + items[right] < sum)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return false;
        }
    }
}
