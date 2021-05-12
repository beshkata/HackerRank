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

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
            
        }

        private static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> rankingLeaderboard = new List<int>(ranked.Count);
            int currentRank = 1;

            for (int i = 0; i < ranked.Count; i++)
            {
                if (i == 0)
                {
                    rankingLeaderboard.Add(currentRank);
                }
                else
                {
                    if (ranked[i] < ranked[i-1])
                    {
                        currentRank++;
                    }
                    rankingLeaderboard.Add(currentRank);
                }
            }

            List<int> playerRank = new List<int>();
            int currentPosition = ranked.Count - 1;
            for (int i = 0; i < player.Count; i++)
            {
                int playerPoints = player[i];
                for (int j = currentPosition; j >= 0; j--)
                {
                    if (j > ranked.Count - 1)
                    {
                        j = ranked.Count - 1;
                    }
                    if (playerPoints > ranked[0])
                    {
                        playerRank.Add(rankingLeaderboard[0]);
                        break;
                    }
                    if (playerPoints < ranked[j])
                    {
                        playerRank.Add(rankingLeaderboard[j] + 1);
                        currentPosition = j;
                        break;
                    }
                    else if (playerPoints == ranked[j])
                    {
                        playerRank.Add(rankingLeaderboard[j]);
                        currentPosition = j;
                        break;
                    }
                    else if (true)
                    {

                    }
                }

            }
            return playerRank;
        }
    }
}
