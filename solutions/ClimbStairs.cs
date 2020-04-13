using System;
using System.Collections.Generic;
namespace InterviewPreparation
{
    public class ClimbStairs{
        public static int getPossiblePaths(int stairs)
        {
            var memoDir = new Dictionary<int, int>(){
                {0, 0},
                {1, 1},
                {2, 2}
            };
            return getPathsForRemainingStairs(stairs, memoDir);
        }

        private static int getPathsForRemainingStairs(int stairs, Dictionary<int, int> memo)
        {
            if (!memo.ContainsKey(stairs))
            {
                var curr = getPathsForRemainingStairs(stairs - 1, memo) + getPathsForRemainingStairs(stairs - 2, memo);
                memo.Add(stairs, curr);           
            }
               
            return memo[stairs];
        }

        public static int effectivePaths(int n)
        {
            if (n == 1)
                return 1;
            var one = 1;
            var two = 2;
            for (var i = 3; i <= n ; i ++)
            {
                var three = one + two;
                one = two;
                two = three;
            }
            return two;
        }
        public static void TestSolution()
        {
            var res1 = getPossiblePaths(40);
            var res2 = effectivePaths(40);
        }
    }
}