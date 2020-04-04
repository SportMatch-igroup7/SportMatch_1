using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class LinksTo
    {
        int branchCode;
        string linkName;
        int linkCode;

        public int BranchCode { get => branchCode; set => branchCode = value; }
        public string LinkName { get => linkName; set => linkName = value; }
        public int LinkCode { get => linkCode; set => linkCode = value; }

        public LinksTo()
        {

        }
        public LinksTo(int bcode, string linkName1, int linkCode1)
        {
            BranchCode = bcode;
            LinkName = linkName1;
            LinkCode = linkCode1;
            
        }

        public int InsertLinksTo()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.InsertLinksTo(this);
            return numAffected;
        }

    }
}