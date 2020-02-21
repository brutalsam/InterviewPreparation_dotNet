using System;
namespace InterviewPreparation
{
    public class InterviewPreparation
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
    }
}