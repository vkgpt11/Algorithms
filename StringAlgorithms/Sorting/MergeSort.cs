using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StringAlgorithms.Sorting
{
    class MergeSort
    {
        List<int> listUnsorted = new List<int>();

        public MergeSort(List<int> _listUnsotred)
        {
            listUnsorted = _listUnsotred;
        }

        public List<int> Sort()
        {
            return DivideMerge(listUnsorted);
        }

        private List<int> DivideMerge(List<int> listToDivide)
        {
            if (listToDivide.Count <= 1)
            {
                return listToDivide;
            }
            var left = new List<int>();
            var right = new List<int>();
            var mid = listToDivide.Count / 2;
            for (int i = 0; i < mid; i++)
            {
                left.Add(listToDivide[i]);
            }
            for (int i = mid; i < listToDivide.Count; i++)
            {
                right.Add(listToDivide[i]);
            }

            left = DivideMerge(left);
            right = DivideMerge(right);
            return Merge(left, right);
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> listSorted = new List<int>();

            while(left.Count>0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() > right.First())
                    {
                        listSorted.Add(right.First());
                        right.Remove(right.First());
                    }
                    else
                    {
                        listSorted.Add(left.First());
                        left.Remove(left.First());
                    }
                }
                else if (left.Count > 0)
                {
                    listSorted.Add(left.First());
                    left.Remove(left.First());
                }
                else
                {
                    listSorted.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return listSorted;
        }
    }
}
