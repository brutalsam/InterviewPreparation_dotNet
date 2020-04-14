using System;
namespace InterviewPreparation
{
    // Find second minimum element in array
    public class SecondMinimum
    {
        public static void printSecondMinimum(int[] input)
        {
            if (input.Length < 2) 
            {
                Console.WriteLine("input array has less then 2 elements");
            }
            var firstMin = int.MaxValue; 
            var secondMin = int.MaxValue;
            foreach(var element in input)
            {
                if (element < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = element;                
                }  
                else if (element != firstMin && element < secondMin)
                {
                    secondMin = element;
                }     
            }
            if (secondMin == int.MaxValue)
                Console.WriteLine($"first minimum {firstMin}, No Second Element");
            else
                Console.WriteLine($"first minimum {firstMin}, second minimum {secondMin}");
        }

        public static void ExecuteSolution()
        {
            // InterviewPreparation.printSecondMinimum(new int[] { 10, 3, 2, 1, 1, 2, 3 });
            // InterviewPreparation.printSecondMinimum(new int[] { 1, 1, 1, 1, 1, 1, 1 });
        }
    }
}