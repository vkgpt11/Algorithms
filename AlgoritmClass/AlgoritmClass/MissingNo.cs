using System;

namespace AlgoritmClass
{
    interface x
    {
        int MyProperty { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //// To calculate sum
            //int[] array = { 1, 2, 3, 4, 6, 7, 8 };
            //int sumArray = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sumArray += array[i];
            //}

            //// Sum of n natural numbers 
            //var sumNNumb = (array.Length + 1 )* (array.Length + 1 + 1) / 2;

            //// Difference
            //Console.WriteLine(sumNNumb - sumArray);

            Console.WriteLine(rotateWords2("llohe ereth",2));

            Console.ReadLine();

        }


        public static int rotateWords2(string input1, int input2)
        {
            try
            {
                return 0;
            }
            finally
            {
                throw new IndexOutOfRangeException();
            }

        }

        public static int rotateWords(string input1, int input2)
        {
            //if(string.IsNullOrWhiteSpace)
            int noOfCorrect = 0;
            var words = input1.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                for (int j = 0; j < input2; j++)
                {
                    var temp = word.Substring(1, word.Length-1) + word[0];
                    word = temp;
                }
                if (word.Equals(words[i]))
                {
                    noOfCorrect++;
                }
            }
            Console.WriteLine(noOfCorrect);
            return noOfCorrect;
        }
    }
}
