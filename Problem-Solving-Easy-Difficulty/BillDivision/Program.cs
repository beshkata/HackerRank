using System;
using System.Collections.Generic;
using System.Linq;

namespace BillDivision
{
    //https://www.hackerrank.com/challenges/bon-appetit/problem

    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            BonAppetit(bill, k, b);
        }

        private static void BonAppetit(List<int> bill, int k, int b)
        {
            int totalAnnaBill = 0;

            for (int i = 0; i < bill.Count; i++)
            {
                if (i == k)
                {
                    continue;
                }
                else
                {
                    totalAnnaBill += bill[i];
                }
            }

            totalAnnaBill /= 2;

            if (totalAnnaBill == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - totalAnnaBill);
            }
        }
    }
}
