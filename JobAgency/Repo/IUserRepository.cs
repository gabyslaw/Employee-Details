using JobAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAgency.Repo
{
    public interface IUserRepository
    {
        IEnumerable<ApplicationUser> GetAllUsers();
    }
}