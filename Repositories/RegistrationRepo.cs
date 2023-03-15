using Matchtickets1.Controllers;
using Matchtickets1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matchtickets1.Repositories
{
    public class RegistrationRepo : IRegistrationRepo
    {
        private readonly TicketBookingContext _context;
        private readonly ILogger<Registration> _logger;
        

        public RegistrationRepo(TicketBookingContext context,ILogger<Registration> logger )
        {
            _context = context;
            _logger = logger;
            
        }


        public Registration Login(string email, string password)
        {

            var registration = _context.Registrations.Where(x => x.Email.ToLower() == email.ToLower() && x.Password == password).FirstOrDefault();
            if (registration == null)
                return null;
            else
                return registration;
        }
        public List<Registration> GetAllRegistrations()
        {

            return _context.Registrations.ToList();
        }
        public Registration GetRegistrationById(int id)
        {
            return _context.Registrations.SingleOrDefault(r => r.Id == id);
        }
        public string AddnewRegistration(Registration registration)
        {
            _context.Registrations.Add(registration);
            _context.SaveChanges();
            if (registration.Id > 0)
            {
                return "Registration Successfull";
            }
            else
            {
                return "oops something went wrong while registering";
            }
        }
        public string UpdateRegistration(Registration registration)
        {

            _context.Entry(registration).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistrationExists(registration.Id))
                {
                    _logger.LogError("user not exist");
                    return "User not exist";

                }
                else
                {
                    _logger.LogError("oops something went wrong");

                    return "oops something went wrong while registering";
                }
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            
            return " updatedsuccessfully ";
        }

        private bool RegistrationExists(int id)
        {
            return _context.Registrations.Any(e => e.Id == id);
        }

        public string DeleteRegistration(int id)
        {
            var x = _context.Registrations.SingleOrDefault(r => r.Id == id);
            if (x != null && x.Id > 0)
            {
                _context.Registrations.Remove(x);
                _context.SaveChanges();
                return "deletedsuccessfully";

            }
            return " usernot exist";

        }




    }
}
