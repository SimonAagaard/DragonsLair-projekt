using System;
using System.Collections.Generic;

namespace DragonsLair_1
{
    public class Controller
    {
        static Random rnd = new Random();
        private TournamentRepo tournamentRepository = new TournamentRepo();

        public void ShowScore(string tournamentName)
        {
            /*
             * TODO: Calculate for each team how many times they have won
             * Sort based on number of matches won (descending)
             */
            Console.WriteLine("Implement this method!");
        }

        public void ScheduleNewRound(string tournamentName, bool printNewMatches = true)
        {
              Tournament tournament = tournamentRepository.GetTournament(tournamentName);
           int numberOfRounds = tournament.GetNumberOfRounds();
            if (numberOfRounds == 0)
            {
              List<Team> teams = tournament.GetTeams();
            }
            else
            {
                Round lastRound = tournament.GetRound(numberOfRounds -1);
                Boolean IsRoundFinished = lastRound.IsMatchesFinished();
                if (IsRoundFinished)
                {
                    List<Team> teams = lastRound.GetWinningTeams();
                    if (teams.Count >= 2)
                    {
                        //implementer den her metode
                        //teams = ShuffleList(teams);
                        Round round = new Round();
                        if (teams.Count % 2 == 1)
                        {
                         
                        }
                    }
                }
            }
         
        }

        // Metoden her under skal laves - randomize teams fra team listen og lav matchups derfra.
        //private List<Team> ShuffleList(List<Team> teams)
        //{
        //    return teams = rnd.Next(teams.Count);
        //}

        public void SaveMatch(string tournamentName, int roundNumber, string team1, string team2, string winningTeam)
        {
            // Do not implement this method
        }
    }
}
