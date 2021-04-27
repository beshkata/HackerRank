using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    //https://www.hackerrank.com/challenges/migratory-birds/problem
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = MigratoryBirds(arr);

            Console.WriteLine(result);
        }

        static int MigratoryBirds(List<int> arr)
        {
            int result = 0;
            int maxCount = 0;

            for (int i = 1; i <= 5; i++)
            {
                int currentCount = 0;

                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] == i)
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxCount)
                {
                    result = i;
                    maxCount = currentCount;
                }
            }

            return result;
        }
    }
}
