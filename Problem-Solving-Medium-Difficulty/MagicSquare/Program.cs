using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicSquare
{
    //https://www.hackerrank.com/challenges/magic-square-forming/problem

    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> s = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
            }

            int result = FormingMagicSquare(s);
            Console.WriteLine(result);
        }

        private static int FormingMagicSquare(List<List<int>> s)
        {
            int[,] one = {
                {8, 1, 6},
                {3, 5, 7},
                {4, 9, 2}
            };
            int[,] two = {
                {4, 3, 8},
                {9, 5, 1},
                {2, 7, 6}
            };

            int[,] three = {
                {2, 9, 4},
                {7, 5, 3},
                {6, 1, 8}
            };
            int[,] four = {
                {6, 7, 2},
                {1, 5, 9},
                {8, 3, 4}
            };
            int[,] five = {
                {6, 1, 8},
                {7, 5, 3},
                {2, 9, 4}
            }; 
            int[,] six = {
                {8, 3, 4},
                {1, 5, 9},
                {6, 7, 2}
            };
            int[,] seven = {
                {4, 9, 2},
                {3, 5, 7},
                {8, 1, 6}
            };
            int[,] eight = {
                {2, 7, 6},
                {9, 5, 1},
                {4, 3, 8}
            };

            List<int[,]> matrixes = new List<int[,]>();
            matrixes.Add(one);
            matrixes.Add(two);
            matrixes.Add(three);
            matrixes.Add(four);
            matrixes.Add(five);
            matrixes.Add(six);
            matrixes.Add(seven);
            matrixes.Add(eight);

            int cost = int.MaxValue;

            for (int i = 0; i < matrixes.Count; i++)
            {
                int currentCost = FindCost(matrixes[i], s);

                if (currentCost < cost)
                {
                    cost = currentCost;
                }
            }
            

            return cost;
        }

        private static int FindCost(int[,] matrix, List<List<int>> s)
        {
            int cost = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (matrix[row,col] != s[row][col])
                    {
                        cost += Math.Abs(matrix[row, col] - s[row][col]);
                    }
                }
            }
            return cost;
        }
    }
}
