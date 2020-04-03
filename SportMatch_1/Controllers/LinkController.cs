using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class LinkController : ApiController
    {
        // GET: Link
        public List<Link> Get()
        {
            Link l = new Link();
            return l.getLinks();
        }
    }
}