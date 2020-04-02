using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class AreaController : ApiController
    {
        // GET: Area
        public List<Area> Get()
        {
            Area a = new Area();
            return a.getAreas();
        }
    }
}