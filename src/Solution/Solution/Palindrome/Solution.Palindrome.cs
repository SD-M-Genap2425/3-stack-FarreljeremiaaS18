using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {

            string normalized = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();


            Stack<char> stack = new Stack<char>();
            foreach (char c in normalized)
            {
                stack.Push(c);
            }


            foreach (char c in normalized)
            {
                if (c != stack.Pop())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
