namespace Diagonal_Difference
{
    using System.Collections.Generic;
    using System.Linq;
    using System;

    //https://www.hackerrank.com/challenges/diagonal-difference/problem
    class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int result = 0;
            int firstSum = 0;
            int secondSum = 0;


            int[,] matrixArr = new int[arr.Count, arr.Count];
            int[] tempArr = new int[arr.Count];

            for (int i = 0; i < arr.Count; i++)
            {
                tempArr = arr[i].ToArray();

                for (int j = 0; j < arr.Count; j++)
                {
                    matrixArr[i, j] = tempArr[j];
                }
            }


            for (int i = 0; i < arr.Count; i++)
            {
                firstSum += matrixArr[i, i];
            }

            for (int i = 0, j = arr.Count - 1; i < arr.Count; i++, j--)
            {
                secondSum += matrixArr[i, j];
            }


            result = Math.Abs(firstSum - secondSum);

            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
