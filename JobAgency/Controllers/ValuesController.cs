﻿//using Domain.Interfaces;
//using System.Collections.Generic;
//using System.Web.Http;

//namespace JobAgency.Controllers
//{
//    [Authorize(Roles = "ADMIN")]
//    public class ValuesController : ApiController
//    {
//        public IUserRepository Repo { get; }
//        public ValuesController()
//        {
//            Repo = new UserRepository();
//        }
//        [Route("api/values")]
//        // GET api/values
//        public IEnumerable<ApplicationUser> Get()
//        {
//            return Repo.GetAllUsers();
//        }

//        // GET api/values/5
//        //public string Get(int id)
//        //{
//        //    return "value";
//        //}

//        // POST api/values
//        public void Post([FromBody]string value)
//        {
//        }

//        // PUT api/values/5
//        public void Put(int id, [FromBody]string value)
//        {
//        }

//        // DELETE api/values/5
//        public void Delete(int id)
//        {
//        }
//    }
//}
