using System;

namespace MiniMaxSum
{
    //https://www.hackerrank.com/challenges/mini-max-sum/problem
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            int maxNumIndex = 0;
            int minNumIndex = 0;

            ulong maxSum = 0;
            ulong minSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxNumIndex])
                {
                    maxNumIndex = i;
                }
                if (arr[i] < arr[minNumIndex])
                {
                    minNumIndex = i;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != maxNumIndex)
                {
                    minSum += (ulong)arr[i];
                }
                if (i != minNumIndex)
                {
                    maxSum += (ulong)arr[i];
                }
            }

            Console.WriteLine("{0} {1}", minSum, maxSum);
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
