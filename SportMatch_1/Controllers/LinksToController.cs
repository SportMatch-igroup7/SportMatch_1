using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class LinksToController : ApiController
    {
        // GET: api/LinksTo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LinksTo/5
        public string Get(int id)
        {
            return "value";
        }


        // POST: api/LinksTo

        public int PostLinksTo([FromBody] LinksTo lt)
        {
            return lt.InsertLinksTo();
        }



        // PUT: api/LinksTo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LinksTo/5
        public void Delete(int id)
        {
        }
    }
}
