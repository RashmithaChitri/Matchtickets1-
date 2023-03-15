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
    public class MatchticketBookingsController : ControllerBase
    {
        private readonly IMatchticketBookingsRepo _matchticketBookingsRepo;

        public MatchticketBookingsController(IMatchticketBookingsRepo matchticketBookingsRepo)
        {
            _matchticketBookingsRepo= matchticketBookingsRepo;
        }

        // GET: api/MatchticketBookings
        [HttpGet]
        public ActionResult<IEnumerable<MatchticketBooking>> GetMatchticketBookings()
        {
            return _matchticketBookingsRepo.GetAllMatchticketBookings();
        }
        // GET: api/MatchticketBookings/5
        [HttpGet("{id}")]
         public ActionResult<MatchticketBooking> GetMatchticketBooking(int id)
        {
            var matchticketBooking = _matchticketBookingsRepo.GetMatchticketBookingsById(id);

            if (matchticketBooking == null)
            {
                return NotFound();
            }

            return matchticketBooking;
        }

        // PUT: api/MatchticketBookings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public ActionResult<string> PutMatchticketBooking(int id, MatchticketBooking matchticketBooking)
        {
            matchticketBooking.Id = id;
            var result = _matchticketBookingsRepo.UpdateMatchticketBooking(matchticketBooking);
            return result;
        }

        // POST: api/MatchticketBookings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<string> PostMatchticketBooking(MatchticketBooking matchticketBooking)
        {
            var result = _matchticketBookingsRepo.AddnewMatchticketBooking(matchticketBooking);
            return result;
        }

        // DELETE: api/MatchticketBookings/5
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteMatchticketBooking(int id)
        {
            var matchticketBooking = _matchticketBookingsRepo.DeleteMatchticketBooking(id);

            return matchticketBooking;
        }

        
    }
}
