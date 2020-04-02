using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class QualificationController : ApiController
    {
        // GET: Qualification
        public List<Qualification> Get()
        {
            Qualification q = new Qualification();
            return q.getQualifications();
        }
    }
}