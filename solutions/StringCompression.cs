using System;
using System.Collections.Generic;
using System.Linq;
namespace InterviewPreparation
{
    // Given an array of characters, compress it in-place.

    // The length after compression must always be smaller than or equal to the original array.

    // Every element of the array should be a character (not int) of length 1.

    // After you are done modifying the input array in-place, return the new length of the array.
    public class StringCompression
    {
        public static int Compress(char[] chars)
        {
            var sb = new System.Text.StringBuilder();
            var i = 0;
            while (i < chars.Length)
            {
                var compressedChar = "";
                var firstChar = chars[i];
                var j = 1;
                while (i+j < chars.Length && chars[i + j] == chars[i])
                {
                    j++;
                }

                if (j == 1)
                {
                    compressedChar = $"{chars[i]}";
                }
                else
                {
                    compressedChar = $"{chars[i]}{j}";
                }
                sb.Append(compressedChar);
                i +=  j;
            }

            var result = sb.ToString().ToCharArray();
            result.CopyTo(chars, 0);
            return result.Length;
        }

        public static void ExecuteSolution()
        {
            var input = "aabbcccd".ToCharArray();
            Compress(input);
        }
    }
}