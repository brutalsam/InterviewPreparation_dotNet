using System;
using System.Collections.Generic;
namespace InterviewPreparation
{
    // 209. Minimum Size Subarray Sum
    // Given an array of n positive integers and a positive integer s, find the minimal length of a contiguous 
    // subarray of which the sum ≥ s. If there isn't one, return 0 instead.
    public class MinimumSizeSubarraySum
    {
        public static int MinSubArrayLenBrut(int s, int[] nums)
        {
            var result = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum >= s)
                    {
                        var iterationResult = j - i + 1;
                        if (iterationResult<result)
                            result = iterationResult;
                        break;
                    }
                }
            }
            return result == int.MaxValue ? 0 : result;
        }

        public static int MinSubArrayLenQuick(int s, int[] nums)
        {
            var result = int.MaxValue;
            var start = 0;
            var sum = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                sum += nums[i];
                while(sum >= s)
                {
                    result = Math.Min(result, i - start + 1);
                    sum -= nums[start++];
                }
            }
            return result == int.MaxValue ? 0 : result;
        }

        public static void ExecuteSolution()
        {
            // var result = MinSubArrayLenBrut(7, new int [] {2,3,1,2,4,3});
            // var result2 = MinSubArrayLenBrut(15, new int [] {5,1,3,5,10,7,4,9,2,8});
            var result = MinSubArrayLenQuick(7, new int [] {2,3,1,2,4,3});
            var result2 = MinSubArrayLenQuick(15, new int [] {5,1,3,5,10,7,4,9,2,8});
        }
    }
}