using System;
using System.Collections.Generic;
using System.Linq;
namespace InterviewPreparation
{
    public class LongestSubstringSolution
    {
        // BrutForce Solution
        public static int LengthOfLongestSubstring(string s) 
        {
            if (s.Length == 0)
                return 0;
            var lenChars = new int[s.Length];
            for (var i = 0; i< s.Length; i++)
            {
                var iLen = 0;
                var charSet = new HashSet<char>();
                for(var k = i; k < s.Length; k++)
                {
                    if (charSet.Contains(s[k]))
                    {
                        break;
                    }
                    iLen++;
                    charSet.Add(s[k]);
                }
                lenChars[i] = iLen;
            }

            return lenChars.Max();
        }

        // Sliding window solution from leetcode
        public static int lengthOfLongestSubstring(String s) 
        {
            var uniqueChars = new HashSet<char>();
            var result = 0;
            var i = 0;
            var j = 0;
            while (i < s.Length && j < s.Length) {
                if (!uniqueChars.Contains(s[j])){
                    uniqueChars.Add(s[j++]);
                    result = Math.Max(result, j - i);
                }
                else {
                    uniqueChars.Remove(s[i++]);
                }
            }
            return result;
        }
    }

}