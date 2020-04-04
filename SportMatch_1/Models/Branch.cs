using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class Branch
    {
        int branchCode;
        string name;
        string address;
        string phoneNo;
        string email; 
        string description;
        int companyNo;
        string password;
        int areaCode;

        public int BranchCode { get => branchCode; set => branchCode = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Email { get => email; set => email = value; }
        public string Description { get => description; set => description = value; }
        public int CompanyNo { get => companyNo; set => companyNo = value; }
        public string Password { get => password; set => password = value; }
        public int AreaCode { get => areaCode; set => areaCode = value; }

        public Branch(string n, string ad, string ph, string em, string des, int com, string pas, int ar) {
            Name = n;
            Address = ad;
            PhoneNo = ph;
            Email = em;
            Description = des;
            CompanyNo = com;
            Password = pas;
            AreaCode = ar;
        }

        public Branch()
        {

        }

        public Branch(int code1)
        {
            branchCode = code1;
        }
        public Branch insert()
        {
            DBservices dbs = new DBservices();
            //int numAffected = dbs.insertBranch(this);
            return dbs.insertBranch(this);
            //return numAffected;
        }

    }
}