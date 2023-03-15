using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Matchtickets1.Models;
using Matchtickets1.Repositories;

namespace Matchtickets1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchDetailsController : ControllerBase
    {
        private readonly IMatchDetailsRepo _matchDetailsRepo;

        public MatchDetailsController(IMatchDetailsRepo matchDetailsRepo)
        {
            _matchDetailsRepo = matchDetailsRepo;
        }

        // GET: api/MatchDetails
        [HttpGet]
        public ActionResult<IEnumerable<MatchDetails>> GetMatchDetails()
        {
            return _matchDetailsRepo.GetAllMatchDetails();
        }

        // GET: api/MatchDetails/5
        [HttpGet("{id}")]
        public ActionResult<MatchDetails> GetMatchDetails(int id)
        {
            var matchDetails = _matchDetailsRepo.GetMatchDetails(id);
            if (matchDetails == null)
            {
                return NotFound();
            }

            return matchDetails;
        }

        // PUT: api/MatchDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public ActionResult<string> PutMatchDetails(int id, MatchDetails matchDetails)
        {
            matchDetails.Id = id;
            var result = _matchDetailsRepo.UpdateMatchDetails(matchDetails);
            return result;

        }



        // POST: api/MatchDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<string> PostMatchDetails(MatchDetails matchDetails)
        {
            var result = _matchDetailsRepo.AddMatchDetails(matchDetails);
            return result;
        }

        // DELETE: api/MatchDetails/5
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteMatchDetails(int id)
        {
            var matchDetails = _matchDetailsRepo.DeleteMatchDetails(id);
            return matchDetails;
        }

    }        
    
}
