using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class ParameterController : ApiController
    {
        // GET: api/Parameter
        public List<Parameter> Get()
        {
            Parameter gp = new Parameter();
            return gp.GetParameterBranchList();
        }
        [HttpGet]
        [Route("api/Parameter/GetParameter/")]
        public DataTable GetParameter()
        {
            Parameter p = new Parameter();
            return p.GetParameter();
        }

        // GET: api/Parameter/5
        public string Get(int id)
        {
            return "value";
        }



        // POST: api/Parameter
        public int Post([FromBody]Parameter p)
        {
            return p.InsertParameter();
        }

        // PUT: api/Parameter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Parameter/5
        public void Delete(int id)
        {
        }
    }
}
