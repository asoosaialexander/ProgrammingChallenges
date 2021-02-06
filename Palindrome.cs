using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingChallenges
{
    public static class Palindrome
    {
        /// <summary>
        /// Given a number, returns the next smallest number which is a palindrome.
        /// </summary>
        /// <param name="input">Palindrome Number</param>
        /// <returns>Next smallest Palindrome</returns>
        public static long GetNextPalindrome(long num)
        {
            if (num < 10)
            {
                return num + 1;
            }
            while (true)
            {
                ++num;                
                if (Reverse(num) == num)
                {
                    return num;
                }
            }
        }

        private static long Reverse(long n)
        {
            long rev_num = 0, digit;
            while (n > 0)
            {
                digit = n % 10;
                rev_num = rev_num * 10 + digit;
                n /= 10;
            }

            return rev_num;
        }

        private static bool IsPalindrome(long num)
        {

        }
    }
}
