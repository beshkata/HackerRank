using System;

namespace DayOfTheProgrammer
{
    //https://www.hackerrank.com/challenges/day-of-the-programmer/problem

    class Program
    {

        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = DayOfProgrammer(year);
            Console.WriteLine(result);
        }

        private static string DayOfProgrammer(int year)
        {
            const int programersDay = 256;

            int[] monthsDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int month = 0;
            int day = 0;
            int daysCounter = 0;
            

            if (year < 1918)
            {
                if (year % 4 == 0)
                {
                    monthsDays[1] = 29;
                }
            }
            else if (year == 1918)
            {
                monthsDays[1] = 15;
            }
            else if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                monthsDays[1] = 29;
            }

            for (int i = 0; i < monthsDays.Length; i++)
            {
                if (daysCounter + monthsDays[i] <= programersDay)
                {
                    daysCounter += monthsDays[i];

                    if (daysCounter == programersDay)
                    {
                        day = monthsDays[i];
                        month = i + 1;
                        break;
                    }
                }
                else
                {
                    day = programersDay - daysCounter;
                    month = i + 1;
                    break;
                }
            }

            return $"{day:D2}.{month:D2}.{year}";
        }
    }
}
