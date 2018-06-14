using JobAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<ApplicationUser> GetAllUsers();
    }
}