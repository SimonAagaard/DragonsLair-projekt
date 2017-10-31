using System;
using System.Collections.Generic;

namespace DragonsLair_1
{
    public class Round
    {
        private List<Match> matches = new List<Match>();
        private Team FreeRider;
        public void AddMatch(Match m)
        {
            matches.Add(m);
        }

        public Match GetMatch(string teamName1, string teamName2)
        {
            //for (int i = 0; i < matches.Count;i++)
            //{
            //    if(matches[i].FirstOpponent.Name && matches[i].SecondOpponent.Name)
            //}

            return null;
        }

        public bool IsMatchesFinished()
        {
            bool Matchfinished = false;
            foreach (Match match in matches)
            {
                Matchfinished = true;
            }
            return Matchfinished;
        }

        public List<Team> GetWinningTeams()
        {
            //Der laves en ny liste over de eksisterende teams som indeholder de vindende hold
            List<Team> winningTeams = new List<Team>();
            //Hver kamp gennemgås i et loop hvorefter vinderen (x) tilføjes til winningTeams listen. Vi kender vinder fra Tournament classen.
            foreach (Match x in matches)
            {
                //Her tilføjes det vindende hold til listen
                winningTeams.Add(x.Winner);
            }
            return winningTeams;
        }

        public List<Team> GetLosingTeams()
        {
            //Der laves en liste over de tabende hold
            List<Team> losingTeams = new List<Team>();
            //Hver kamp gennemgås
            foreach (Match y in matches)
            {
                //Navnene sammenlignes mellem firstopponent og vinderen.
                if (y.FirstOpponent.Name == y.Winner.Name)
                {
                    //Er navnet på vinderen matchet af navnet på first opponent, vinder firstoppnent
                    losingTeams.Add(y.SecondOpponent);
                }
                else
                {
                    //Ellers vinder secondopponent
                    losingTeams.Add(y.FirstOpponent);
                }
            }
            return losingTeams;
        }
        //Metode for FreeRider
        internal Team GetFreeRider()
        {
            return FreeRider;
        }
        //Metode for en ny FreeRider
        internal void Add(Team newFreeRider)
        {
            FreeRider = newFreeRider;
        }
    }
}
