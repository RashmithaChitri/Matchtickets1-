using Matchtickets1.Models;
using System.Collections.Generic;

namespace Matchtickets1.Repositories
{
    public interface IMatchDetailsRepo
    {
        List<MatchDetails> GetAllMatchDetails();
        MatchDetails GetMatchDetails(int id);
        string AddMatchDetails(MatchDetails matchDetails);
        string UpdateMatchDetails(MatchDetails matchDetails);
        string DeleteMatchDetails(int id);
    }
}
