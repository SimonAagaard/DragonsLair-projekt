using System.Collections.Generic;

namespace DragonsLair_1
{
    public class Round
    {
        private List<Match> matches = new List<Match>();
        
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
            // TODO: Implement this method
            return null;
        }

        public List<Team> GetLosingTeams()
        {
            // TODO: Implement this method
            return null;
        }
    }
}
