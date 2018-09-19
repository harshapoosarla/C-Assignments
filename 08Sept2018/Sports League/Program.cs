using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLeague
{
 public class Program
    {
       static void Main(string[] args)
        {
            Console.Write("Enter the League Name :");
            League CricketLeague = new League(Console.ReadLine());
            Match Match = new Match();
            Console.WriteLine("Enter the Team details");
            Console.WriteLine("Enter Team A Name :");
            Match.TeamA = new TeamScore();
            Match.TeamA.TeamName = Console.ReadLine();
            for (int PlayerScore = 0; PlayerScore < Match.TeamA.Players.Length; PlayerScore++)
            {
                Match.TeamA.Players[PlayerScore] = new Player();
                Console.Write("Enter the Player " + (PlayerScore + 1) + " Name :");
                Match.TeamA.Players[PlayerScore].PlayerName = Console.ReadLine();
            }
            Console.WriteLine("Enter Team B Name :");
            Match.TeamB = new TeamScore();
            Match.TeamB.TeamName = Console.ReadLine();
            for (int PlayerScore = 0; PlayerScore < Match.TeamB.Players.Length; PlayerScore++)
            {
                Match.TeamB.Players[PlayerScore] = new Player();
                Console.Write("Enter the Player " + (PlayerScore + 1) + " Name :");
                Match.TeamB.Players[PlayerScore].PlayerName = Console.ReadLine();
            }
            Console.WriteLine("Match Begins");
            Console.WriteLine("Enter the Score for team :" + Match.TeamA.TeamName);
            int RemainingBalls = StaticVariables.MaximumBalls;
            Match.TeamA.HighestScorer = new Player();
            Match.TeamA.HighestScorer.PlayersScoreInMatch = new PlayerScore();
            for (int PlayerScore = 0; PlayerScore < Match.TeamA.Players.Length; PlayerScore++)
            {
                Match.TeamA.Players[PlayerScore].PlayersScoreInMatch = new PlayerScore();
                Console.Write("Enter the Runs Scored by\t" + Match.TeamA.Players[PlayerScore].PlayerName);

                Match.TeamA.Players[PlayerScore].PlayersScoreInMatch.Score = Int32.Parse(Console.ReadLine());

                Console.Write("Enter Number of Balls faced by\t" + Match.TeamA.Players[PlayerScore].PlayerName);
                int PlayedBalls = Int32.Parse(Console.ReadLine());
                while (PlayedBalls > RemainingBalls)
                {
                    Console.Write("Remaining Balls in the Match are :" + RemainingBalls);
                    Console.WriteLine("Enter Valid number of balls faced");
                    PlayedBalls = Int32.Parse(Console.ReadLine());
                }

                RemainingBalls = RemainingBalls - PlayedBalls;
                Match.TeamA.Players[PlayerScore].PlayersScoreInMatch.Balls = PlayedBalls;
                Match.TeamA.Score += Match.TeamA.Players[PlayerScore].PlayersScoreInMatch.Score;
                if (PlayerScore == 0)
                {
                    Match.TeamA.HighestScorer = Match.TeamA.Players[PlayerScore];
                    Match.TeamA.HighestScorer.PlayersScoreInMatch.Score = Match.TeamA.Players[PlayerScore].PlayersScoreInMatch.Score;
                }
                else
                {
                    if (Match.TeamA.HighestScorer.PlayersScoreInMatch.Score < Match.TeamA.Players[PlayerScore].PlayersScoreInMatch.Score)
                    {
                        Match.TeamA.HighestScorer = Match.TeamA.Players[PlayerScore];
                        Match.TeamA.HighestScorer.PlayersScoreInMatch.Score = Match.TeamA.Players[PlayerScore].PlayersScoreInMatch.Score;
                    }
                }
            }
            Console.WriteLine("Total Runs Scored by team" + Match.TeamA.TeamName + " :" + Match.TeamA.Score);

            RemainingBalls = StaticVariables.MaximumBalls;
            Match.TeamB.HighestScorer = new Player();
            Match.TeamB.HighestScorer.PlayersScoreInMatch = new PlayerScore();
            for (int PlayerScore = 0; PlayerScore < Match.TeamB.Players.Length; PlayerScore++)
            {
                Match.TeamB.Players[PlayerScore].PlayersScoreInMatch = new PlayerScore();
                Console.Write("Enter " + Match.TeamB.Players[PlayerScore].PlayerName + " Score :");
                Match.TeamB.Players[PlayerScore].PlayersScoreInMatch.Score = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Number of Balls Played by " + Match.TeamB.Players[PlayerScore].PlayerName + " :");
                int PlayedBalls = Int32.Parse(Console.ReadLine());
                while (PlayedBalls > RemainingBalls)
                {
                    Console.Write("Remaining Balls:" + RemainingBalls);
                    Console.WriteLine("Enter Valid number of balls Faced");
                    PlayedBalls = Int32.Parse(Console.ReadLine());
                }
                RemainingBalls = RemainingBalls - PlayedBalls;
                Match.TeamB.Players[PlayerScore].PlayersScoreInMatch.Balls = PlayedBalls;
                Match.TeamB.Score += Match.TeamB.Players[PlayerScore].PlayersScoreInMatch.Score;
                if (PlayerScore == 0)
                {
                    Match.TeamB.HighestScorer = Match.TeamB.Players[PlayerScore];
                    Match.TeamB.HighestScorer.PlayersScoreInMatch.Score = Match.TeamB.Players[PlayerScore].PlayersScoreInMatch.Score;
                }
                else
                {
                    if (Match.TeamB.HighestScorer.PlayersScoreInMatch.Score < Match.TeamB.Players[PlayerScore].PlayersScoreInMatch.Score)
                    {
                        Match.TeamB.HighestScorer = Match.TeamB.Players[PlayerScore];
                        Match.TeamB.HighestScorer.PlayersScoreInMatch.Score = Match.TeamB.Players[PlayerScore].PlayersScoreInMatch.Score;
                    }
                }
            }
            Console.WriteLine("Total runs Scored by team " + Match.TeamB.TeamName + Match.TeamB.Score);
            if (Match.TeamB.Score > Match.TeamA.Score)
            {
                Match.TeamA.IsWinner = false;
                Match.TeamB.IsWinner = true;
                Match.ManOfTheMatch = Match.TeamB.HighestScorer;
                Console.WriteLine("TEAM " + Match.TeamB.TeamName + " WON THE MATCH");
            }
            else
            {
                Match.TeamA.IsWinner = true;
                Match.TeamB.IsWinner = false;
                Match.ManOfTheMatch = Match.TeamB.HighestScorer;
                Console.WriteLine("TEAM " + Match.TeamA.TeamName + " WON THE MATCH");
            }
            Match.HighScore = new Player();
            Match.HighScore.PlayersScoreInMatch = new PlayerScore();
            if (Match.TeamA.HighestScorer.PlayersScoreInMatch.Score > Match.TeamB.HighestScorer.PlayersScoreInMatch.Score)
            {
                Match.HighScore.PlayersScoreInMatch.Score = Match.TeamA.HighestScorer.PlayersScoreInMatch.Score;
                Console.WriteLine("Highest Scorer of the Winning Team is:" + Match.TeamA.HighestScorer.PlayerName);
            }
            else
            {
                Match.HighScore.PlayersScoreInMatch.Score = Match.TeamB.HighestScorer.PlayersScoreInMatch.Score;
                Console.WriteLine("Highest Scorer of the Team:" + Match.TeamB.HighestScorer.PlayerName);
            }
             Console.WriteLine("Man Of The Match :" + Match.ManOfTheMatch.PlayerName + " With score of " + Match.HighScore.PlayersScoreInMatch.Score);
             Console.ReadKey();
        }
    }
}
