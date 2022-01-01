using System;
using System.Collections.Generic;
using System.Text;

namespace StringAlgorithms.PatternMatching
{
    class NaivePatternSearching
    {
        public static void Search(string text, string pattern)
        {
            // loop to slide pattern one by one
            for (int i = 0; i < text.Length- pattern.Length; i++)
            {
                int j;
                // For current index i, check for pattern match
                for (j = 0; j < pattern.Length; j++)
                {
                    if (text[i+j] != pattern[j])
                        break;
                }
                if (j == pattern.Length)
                    Console.WriteLine("Pattern found at index " + i);
            }
        }
    }
}
