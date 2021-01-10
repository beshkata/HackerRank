using System;

namespace Day_2._Operators
{
    //https://www.hackerrank.com/challenges/30-operators/problem
    class Program
    {
        // Complete the solve function below.
        static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = (meal_cost * tip_percent) / 100;
            double tax = meal_cost * tax_percent / 100;
            
            Console.WriteLine(Math.Round(meal_cost + tip + tax));
        }

        static void Main()
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            Solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
