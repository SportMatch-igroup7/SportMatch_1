using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportMatch_1.Models;

namespace SportMatch_1.Controllers
{
    public class CompanyController : ApiController
    {
        public List<Company> Get()
        {
            Company c = new Company();
            return c.getCompany();
        }
    }
}

