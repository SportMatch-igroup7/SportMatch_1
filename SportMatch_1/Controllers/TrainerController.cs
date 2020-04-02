using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class TrainerController : ApiController
    {
        // GET: api/Trainer
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Trainer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Trainer
        public int Post([FromBody]Trainer t)
        {
            return t.insert();
        }

        // PUT: api/Trainer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Trainer/5
        public void Delete(int id)
        {
        }
    }
}

