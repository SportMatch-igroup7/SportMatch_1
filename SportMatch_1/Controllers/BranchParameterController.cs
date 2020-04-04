using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class BranchParameterController : ApiController
    {
        // GET: api/BranchParameter
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BranchParameter/5
        public string Get(int id)
        {
            return "value";
        }


        // POST: api/BranchParameter

        public int PostBranchParameter([FromBody] BranchParameter p)
        {
            return p.InsertBranchParameter();
        }



        // PUT: api/BranchParameter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BranchParameter/5
        public void Delete(int id)
        {
        }
    }
}
