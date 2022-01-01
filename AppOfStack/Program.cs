using System;

namespace AppOfStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackUsingQueue stackUsingQueue = new StackUsingQueue();
            //stackUsingQueue.Push(10);
            //stackUsingQueue.Push(11);
            //stackUsingQueue.Push(12);
            //stackUsingQueue.Push(13);
            //Console.WriteLine("Peak:" + stackUsingQueue.Peak());
            //stackUsingQueue.Pop();
            //stackUsingQueue.Push(14);
            //Console.WriteLine("Peak:" + stackUsingQueue.Peak());

            //stackUsingQueue.PrintStack();

            // LargestAreaUnderHistogram area = new LargestAreaUnderHistogram();
            // area.Calcuate(new System.Collections.Generic.List<int>() { 2, 2, 2, 6, 1, 5, 4, 2, 2, 2, 2 });

            //RemoveOuterParentheses removeOuter = new RemoveOuterParentheses();
            //Console.WriteLine(removeOuter.Remove("()(()())(())"));

            //RemoveDuplicates removeDuplicates = new RemoveDuplicates();
            //Console.WriteLine(removeDuplicates.Remove("abbaca"));

            // BaseballCalculatePoints baseballCalculatePoints = new BaseballCalculatePoints();
            // var x = new string[] { "5", "2", "C", "D", "+" };
            // var x = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
            // Console.WriteLine(baseballCalculatePoints.CalPoints(x));

            //var validPar = new ValidParentheses();
            //Console.WriteLine(validPar.IsValid("{([])}"));

            MinStack minStack = new MinStack();
            minStack.Push(10);
            minStack.Push(-2);
            int param_3 = minStack.Top();
            Console.WriteLine(minStack.GetMin());
            Console.ReadLine();


        }
    }
}
