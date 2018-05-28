using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobAgency.Models;

namespace JobAgency.Repo
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext context;

        public UserRepository()
        {
            context = new ApplicationDbContext();
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return context.Users.ToList();
        }
    }
}