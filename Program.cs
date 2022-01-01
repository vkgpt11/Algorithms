using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();// ababbbaaabbab, abababab
            var pattern = Console.ReadLine();// ab, aba
            PatternMatchingBruteForce.Brute_Force(text, pattern);
            Console.ReadLine();
        }

    }
}
