using Algorithms.Bitwise;
using Algorithms.Math;
using StringAlgorithms.Bitwise;
using StringAlgorithms.Math;
using StringAlgorithms.PatternMatching;
using StringAlgorithms.Sorting;
using System;
using System.Collections.Generic;

namespace StringAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // NaivePatternSearching.Search("AABAACAADAABAAABAA", "AABA");

            // List<int> list = new List<int> { 79, 69, 9, 95, 65, 49, 65, 40, 27, 95 };
            //MergeSort mergeSort = new MergeSort(list);
            //mergeSort.Sort().ForEach(x =>
            //{
            //    Console.Write(" " + x);
            //});

            // Console.WriteLine(CountOnes.CountSetBits(4));

            // Console.WriteLine(Math.FactorialOfBigNo.Fact(100000));

            //SwappingNumbers swappingNumbers = new SwappingNumbers(4, 3);
            //swappingNumbers.Swapping3();
            //Console.WriteLine(swappingNumbers.Number1 + " " + swappingNumbers.Number2);
            // int[] A = new int[] { 1, 4, 45, 6, 10, 8 };
            // Console.WriteLine(TwoNumberSum.ExistsOptimized(A,16));
            //int[] A = new int[] { 1, 4, 1, 6, 4,6, 8 };

            //Console.WriteLine(FindWithoutPairNumber.Find(A));
            int[] A=new int[] { 2, 4, 5, 6};
            FindMinNoCoins.MinCoins(A, 3);
        }
    }
}
