using System;
using System.Collections.Generic;
namespace InterviewPreparation
{
    public class TwoSumSolution {
    public static int[] TwoSum(int[] nums, int target) {
        var difDict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            var dif = target - nums[i];
            if (difDict.ContainsKey(dif))
                return new int[] {difDict[dif], i};
            if (!difDict.ContainsKey(nums[i]))
                difDict.Add(nums[i], i);
        }
        return new int[] {0,0};
    }
}
}