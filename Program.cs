using System;

namespace InterviewPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InterviewPreparation.printSecondMinimum(new int[] { 10, 3, 2, 1, 1, 2, 3 });
            InterviewPreparation.printSecondMinimum(new int[] { 1, 1, 1, 1, 1, 1, 1 });
            Console.WriteLine(String.Join(", ", TwoSumSolution.TwoSum(new int[] {2,7,11,15}, 9)));
            Console.WriteLine(String.Join(", ", TwoSumSolution.TwoSum(new int[] {2,6,11,15}, 13)));
        }
    }
}
