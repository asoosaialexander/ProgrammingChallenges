using System;

namespace ProgrammingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputList = new long[] { 1239321 };
            
            foreach(long input in inputList)
            {
                var watch = new System.Diagnostics.Stopwatch();

                watch.Start();
                long res = Palindrome.GetNextPalindrome(input);
                watch.Stop();

                Console.WriteLine("Next palindrome of {0} is {1}", input, res);
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
                
            }
        }
    }
}
