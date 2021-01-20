using System;
using System.Collections.Generic;

namespace GradingStudents
{
    //https://www.hackerrank.com/challenges/grading/problem
    class Program
    {
        public static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.GradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));

        }
    }
    class Result
    { 
        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] > 37)
                {
                    if (grades[i] % 10 == 3 || grades[i] % 10 == 8)
                    {
                        result.Add(grades[i] + 2);
                    }
                    else if (grades[i] % 10 == 4 || grades[i] % 10 == 9)
                    {
                        result.Add(grades[i] + 1);
                    }
                    else
                    {
                        result.Add(grades[i]);
                    }

                }
                else
                {
                    result.Add(grades[i]);
                }
            }

            return result;
        }
    }
}
