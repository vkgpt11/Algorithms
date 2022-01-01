using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine( PerfectTeam("pcmhhpcmhs"));
        }

        public static int PerfectTeam(string skills)
        {
            Dictionary<char,int> dictonary = new Dictionary<char, int>();
            foreach (var item in skills)
            {
                if (!dictonary.Keys.Contains(item))
                {
                    dictonary.Add(item, 1);
                }
                else
                {
                    dictonary[item]++;
                }
            }
            return dictonary.Count == 5? dictonary.Values.Min():0;
        }
    }
}
