using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Matchtickets1.Models;
using Matchtickets1.DAO;
using Matchtickets1.Repositories;
using log4net.Core;

namespace Matchtickets1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationsController : ControllerBase
    {
        
        private readonly IRegistrationRepo  _registrationRepo;
       
        public RegistrationsController(IRegistrationRepo registrationRepo)
        {
            
            _registrationRepo = registrationRepo;
        }

        // GET: api/Registrations
        [HttpGet]
        public ActionResult<IEnumerable<Registration>> GetRegistrations()
        {
            return _registrationRepo.GetAllRegistrations();
        }

        // GET: api/Registrations/5
        [HttpGet("{id}")]
        public ActionResult<Registration> GetRegistration(int id)
        {
            var registration = _registrationRepo.GetRegistrationById(id);

            if (registration == null)
            {
                return NotFound();
            }

            return registration;
        }
        [HttpGet]
        [Route("Login")]
        
        public ActionResult<Registration> Login(string emailid,string password)
        {
            var registration = _registrationRepo.Login(emailid, password);
            return registration;
        }

        // PUT: api/Registrations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public ActionResult<string> PutRegistration(int id, Registration registration)
        {
            registration.Id = id;
            var result = _registrationRepo.UpdateRegistration(registration);
            return result;
        }

        // POST: api/Registrations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<string> PostRegistration(Registration registration)
        {
           var result =_registrationRepo.AddnewRegistration(registration);
            return result;
        }

        // DELETE: api/Registrations/5
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteRegistration(int id)
        {
            var registration = _registrationRepo.DeleteRegistration(id);
            return registration;
        }
    }
}
