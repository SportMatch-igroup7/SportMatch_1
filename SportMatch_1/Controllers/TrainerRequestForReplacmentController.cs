using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class TrainerRequestForReplacmentController : ApiController
    {
        // GET: api/TrainerRequestForReplacment
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TrainerRequestForReplacment/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TrainerRequestForReplacment
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TrainerRequestForReplacment/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TrainerRequestForReplacment/5
        public void Delete(int id)
        {
        }
    }
}


