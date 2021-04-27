using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingLeaderboard
{
    //https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem

    class Player
    {
        public Player(int score)
        {
            Score = score;
        }
        public int Score { get; set; }

        public int Rank { get; set; }

    }

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
            List<Player> players = new List<Player>(ranked.Count + 1);

            for (int i = 0; i < ranked.Count; i++)
            {
                Player player1 = new Player(ranked[i]);
                players.Add(player1);
            }

            players = players.OrderByDescending(x => x.Score).ToList();
            DenseRanking(players, 0);

            Player newPlayer = new Player(0);
            players.Add(newPlayer);

            List<int> rankingResult = new List<int>(player.Count);

            for (int i = 0; i < player.Count; i++)
            {
                int newPlayerIndex = players.IndexOf(newPlayer);

                players[newPlayerIndex].Score = player[i];
                players = players.OrderByDescending(x => x.Score).ToList();
                newPlayerIndex = players.IndexOf(newPlayer);

                DenseRanking(players, newPlayerIndex);

                rankingResult.Add(players[newPlayerIndex].Rank);
            }

            return rankingResult;
        }

        private static void DenseRanking(List<Player> players, int index)
        {
            int currentRank = 1;
            if (index > 0)
            {
                currentRank = players[index - 1].Rank;
            }


            for (int i = index; i < players.Count; i++)
            {
                if (i == 0)
                {
                    players[i].Rank = currentRank;
                }
                else
                {
                    if (players[i].Score == players[i - 1].Score)
                    {
                        players[i].Rank = players[i - 1].Rank;
                    }
                    else
                    {
                        currentRank++;
                        players[i].Rank = currentRank;
                    }

                }
            }
        }
    }
}
