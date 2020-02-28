using System;
using System.Collections.Generic;
namespace InterviewPreparation
{
    //Say you have an array for which the ith element is the price of a given stock on day i.
    // If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
    // Note that you cannot sell a stock before you buy one.
    public class BestProfit
        {
        public static int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            var minimum = int.MaxValue;
            foreach (var price in prices)
            {
                if (price < minimum)
                    minimum = price;
                if ((price - minimum) > maxProfit)
                    maxProfit = price - minimum;
            }

            return maxProfit;
        }

        public static void TestSolution()
        {
            // MaxProfit(new int[] {7, 1, 5, 3, 6, 4});
            MaxProfit(new int[] { 7, 6, 4, 3, 1 });
        }
    }
}