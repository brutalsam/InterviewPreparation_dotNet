using System;
using System.Collections.Generic;
namespace InterviewPreparation
{
    // Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    // An input string is valid if:

    // Open brackets must be closed by the same type of brackets.
    // Open brackets must be closed in the correct order.
    // Note that an empty string is also considered valid.
    public class ValidParentheses {
        public static bool IsValid(string s) {
            var map = new Dictionary<char, char> 
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}'},
            };
            var stack = new Stack<char>();
            foreach(var c in s)
            {
                if (map.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else 
                {
                    if (stack.Count == 0 || map[stack.Peek()] != c )
                    {
                        return false;
                    }
                    else 
                    {
                        stack.Pop();
                    }
                }
            }
        
            return stack.Count == 0;
        }

        public static void TestSolution()
        {
            //IsValid("()");
            //IsValid("()[]{}");
            //IsValid("{[]}");
            IsValid("{");
        }
    }
}