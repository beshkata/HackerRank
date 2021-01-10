using System;

namespace Day_1._Data_Types
{
    //https://www.hackerrank.com/challenges/30-data-types/problem
    class Program
    {
        static void Main()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            // Read and save an integer, double, and String to your variables.
            int secontInt = int.Parse(Console.ReadLine());
            double secontDouble = double.Parse(Console.ReadLine());
            string secondString = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i+secontInt);
            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:f1}", d + secontDouble);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s+secondString);
        }
    }
}
