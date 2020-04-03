using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class Link
    {
        int linkCode;
        string linkName;

        public int LinkCode { get => linkCode; set => linkCode = value; }
        public string LinkName { get => linkName; set => linkName = value; }

        public Link()
        {

        }
        public Link(int linkCode1, string linkName1)
        {
            LinkCode = linkCode1;
            LinkName = linkName1;
        }

        public List<Link> getLinks()
        {
            DBservices dbs = new DBservices();
            List<Link> arrLinks = dbs.getLinks();
            return arrLinks;
        }
    }
}