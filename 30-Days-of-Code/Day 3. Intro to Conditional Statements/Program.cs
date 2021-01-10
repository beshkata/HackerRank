using System;

namespace Day_3._Intro_to_Conditional_Statements
{
    //https://www.hackerrank.com/challenges/30-conditional-statements/problem
    class Program
    {
        static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if ((N >= 2 && N <= 5) || N > 20)
            {
                Console.WriteLine("Not Weird");
            }
            else
            {
                Console.WriteLine("Weird");
            }
        }
    }
}
