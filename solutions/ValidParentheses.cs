using System;
using System.Collections.Generic;
namespace InterviewPreparation
{
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