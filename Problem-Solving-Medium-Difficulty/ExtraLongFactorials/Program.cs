using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    //https://www.hackerrank.com/challenges/extra-long-factorials/problem
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.ExtraLongFactorials(n);

        }
    }
    class Result
    {

        /*
         * Complete the 'extraLongFactorials' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void ExtraLongFactorials(int n)
        {
            BigInteger factoriel = 1;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }

            Console.WriteLine(factoriel);
        }

    }

}
