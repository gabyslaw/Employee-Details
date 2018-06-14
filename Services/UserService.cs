using Domain.Interfaces;
using JobAgency.Models;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }
    }
}
