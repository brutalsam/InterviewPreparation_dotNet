using System;
using System.Collections.Generic;
using System.Linq;
namespace InterviewPreparation
{
    //Given a list of scores of different students, return the average score of each student's top five scores in the order of each student's id.
    public class HighFiveSolution 
    {
        public static int[][] HighFive(int[][] items) 
        {
            return items.GroupBy(x => x[0])
                .Select(x => new int []
                { 
                    x.Key, 
                    Convert.ToInt32(Math.Truncate( x.OrderByDescending(y => y[1]).Take(5).Average(z => z[1])))
                }).ToArray();
        }

        public static void TestSolution()
        {
            int[][] inArr = { 
                new int[] {1,91},
                new int[] {1,92},
                new int[] {2,93},
                new int[] {2,97},
                new int[] {1,60},
                new int[] {2,77},
                new int[] {1,65},
                new int[] {1,87},
                new int[] {1,100},
                new int[] {2,100},
                new int[] {2,76}
            };
            var res1 = HighFive(inArr);
        }
    }
}