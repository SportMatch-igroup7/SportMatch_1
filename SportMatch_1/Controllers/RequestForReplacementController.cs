using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class RequestForReplacementController : ApiController
    {
        // GET: api/RequestForReplacement
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RequestForReplacement/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RequestForReplacement
        public void Post([FromBody]RequestForReplacement r)
        {
            r.insert();
        }

        // PUT: api/RequestForReplacement/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RequestForReplacement/5
        public void Delete(int id)
        {
        }
    }
}

