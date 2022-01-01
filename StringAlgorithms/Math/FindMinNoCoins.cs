using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Math
{
    //https://www.youtube.com/watch?v=NJuKJ8sasGk
    class FindMinNoCoins
    {
        public static void MinCoins(int[] coins, int change)
        {
            var totalCoinsRequired = new int[change + 1];
            var refOfCoins = new int[change + 1];
            totalCoinsRequired[0] = 0;
            refOfCoins[0] = -1;

            for (int i = 1; i <= change; i++)
            {
                totalCoinsRequired[i] = int.MaxValue-1;
                refOfCoins[i] = -1;
            }

            for (int j = 0; j < coins.Length; j++)
            {
                for (int i = coins[j]; i <= change; i++)
                {
                        if(totalCoinsRequired[i-coins[j]]+1 < totalCoinsRequired[i])
                        {
                            totalCoinsRequired[i] = 1 + totalCoinsRequired[i - coins[j]];
                            refOfCoins[i] = j;
                        }
                }
            }
            Console.WriteLine("Total no of coins required" + totalCoinsRequired[change]);

            PrintCoinCombination(refOfCoins, coins);
        }

        private static void PrintCoinCombination(int[] refOfCoins, int[] coins)
        {
            if (refOfCoins[refOfCoins.Length - 1] == -1)
            {
                Console.WriteLine("No solution is possible");
                return;
            }
            int start = refOfCoins.Length - 1;
            Console.WriteLine("Coins used to form total ");
            while (start != 0)
            {
                int j = refOfCoins[start];
                Console.WriteLine(coins[j] + " ");
                start = start - coins[j];
            }


        }
    }
}
