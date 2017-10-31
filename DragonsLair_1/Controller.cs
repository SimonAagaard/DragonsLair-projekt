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
                        teams = ShuffleList(teams);
                        Round newRound = new Round();
                        if (teams.Count % 2 == 1)
                        {
                            Team oldFreeRider = lastRound.GetFreeRider();
                            Team newFreeRider = teams[0];

                            while(newFreeRider == oldFreeRider)
                            {
                                newFreeRider = teams[1];
                            }
                            teams.Remove(newFreeRider);
                            newRound.Add(newFreeRider);
                        }
                        while(teams.Count > 0)
                        {
                            //Ny match laves med de resterende teams i listen
                            Match match = new Match();
                            //Der tilføjes en firstopponent og samtidig fjernes dette hold fra listen med hold
                            match.FirstOpponent = teams[0];
                            //RemoveAt = metode man kan bruge på en liste
                            teams.RemoveAt(0);

                            //Samme process for secondopponent
                            match.SecondOpponent = teams[0];
                            teams.RemoveAt(0);

                           
                            newRound.AddMatch(match);
                        }
                        tournament.Add(newRound);
     
                    }
                    else
                    {
                        tournament.SetStatus("Finished.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Round is not finished yet.");
                }
            }
        }

        // Metoden her under skal laves - randomize teams fra team listen og lav matchups derfra.
        private List<Team> ShuffleList(List<Team> teams)
        {
            //Vi laver en ny liste for de blandede hold
            List<Team> scrambledTeams = new List<Team>();
            //Random klassen instancieres så vi kan bruge den
            Random random = new Random();

            //Så længe der er flere end 0 teams i listen med de blandede hold gøres følgende:
            while (teams.Count > 0)
            {
                //Metoden for at tage teams i tilfældig rækkefølge. Tallet index defineres = random.next, som tager et hold baseret ud fra et tilfældigt tal (index)
                int index = random.Next(teams.Count - 1);
                scrambledTeams.Add(teams[index]);
                teams.RemoveAt(index);
            }
            return scrambledTeams;
        }

        public void SaveMatch(string tournamentName, int roundNumber, string team1, string team2, string winningTeam)
        {
            // Do not implement this method
        }
    }
}
