using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingLeaderboard
{
    //https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem

    class Program
    {
        static void Main(string[] args)
        {
            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = ClimbingLeaderboard(ranked, player);

            
        }

        private static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
        {
            int[] leaderBoard = new int[ranked.Count];
            int rank = 1;
            List<int> playerRanking = new List<int>();

            for (int i = 0; i < leaderBoard.Length; i++)
            {
                if (i == 0)
                {
                    leaderBoard[i] = rank;
                }
                else if (ranked[i] == ranked [i-1])
                {
                    leaderBoard[i] = leaderBoard[i - 1];
                }
                else if (ranked[i] < ranked[i - 1])
                {
                    rank++;
                    leaderBoard[i] = rank;
                }
            }

            for (int i = 0; i < player.Count; i++)
            {
                int currentPlayerScore = player[i];
                int playerRank = 0;

                if (currentPlayerScore >= ranked[0])
                {
                    playerRank = leaderBoard[0];
                    playerRanking.Add(playerRank);
                    continue;
                }
                if (currentPlayerScore < ranked[ranked.Count - 1])
                {
                    playerRank = leaderBoard[ranked.Count - 1]++;
                    playerRanking.Add(playerRank);
                    continue;
                }

                while (true)
                {
                    if (currentPlayerScore <= ranked[ranked.Count/2])
                    {

                    }
                }
            }

            Console.WriteLine(string.Join(", ", leaderBoard));
            return playerRanking;
        }

    }
}
