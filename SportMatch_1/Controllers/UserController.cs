using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class UserController : ApiController
    {
        // GET: Users
        [HttpGet]
        [Route("api/User/getUser")]
        public List<User> getUser(string email)
        {
            User u = new User();
            return u.getUsers(email);
        }
       
    }
}