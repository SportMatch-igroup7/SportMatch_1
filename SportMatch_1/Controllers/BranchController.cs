using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class BranchController : ApiController
    {
        // GET: api/Branch
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Branch/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Branch
        public int Post([FromBody]Branch b)
        {
            return b.insert();
        }

        // PUT: api/Branch/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Branch/5
        public void Delete(int id)
        {
        }
    }
}
