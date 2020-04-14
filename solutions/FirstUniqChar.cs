using System;
using System.Collections.Generic;
using System.Linq;
namespace InterviewPreparation
{
    //Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.
    public class FirstUniqCharSolution 
    {
        public static int FirstUniqChar(string s) 
        {
            var charDict = s.ToCharArray().GroupBy(x=>x).ToDictionary(x => x.Key);
            for (int i = 0; i < s.Length; i++)
            {
                if (charDict[s[i]].Count() == 1)
                    return i;
            }
            return -1;
        }

        public static void ExecuteSolution()
        {
            var res1 = FirstUniqChar("leetcode");
            var res2 = FirstUniqChar("loveleetcode");
        }
    }
}