using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Cake_Candles
{
    //https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    class Result
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int result = 0;
            int maxNum = 0;

            candles.Sort();
            candles.Reverse();

            maxNum = candles[0];

            foreach (var candle in candles)
            {
                if (candle >= maxNum)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }

            return result;

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result.birthdayCakeCandles(candles);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
