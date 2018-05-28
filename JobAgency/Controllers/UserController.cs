using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JobAgency.Controllers
{
   
    public class UserController : ApiController
    {
        [Route("api/user")]
        public IEnumerable<User> Get()
        {
            using(JobSeekersDBEntities entities = new JobSeekersDBEntities())
            {
                return entities.Users.ToList();
            }
        }
    }
}
