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
        string city;
        string phoneNo;
        string email; 
        string website;
        string description;
        int companyNo;
        string password;
        int areaCode;

        public int BranchCode { get => branchCode; set => branchCode = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Email { get => email; set => email = value; }
        public string Website { get => website; set => website = value; }
        public string Description { get => description; set => description = value; }
        public int CompanyNo { get => companyNo; set => companyNo = value; }
        public string Password { get => password; set => password = value; }
        public int AreaCode { get => areaCode; set => areaCode = value; }

        public Branch(string n, string ad, string ci, string ph, string em, string web, string des, int com, string pas, int ar) {
            Name = n;
            Address = ad;
            City = ci;
            PhoneNo = ph;
            Email = em;
            Website = web;
            Description = des;
            CompanyNo = com;
            Password = pas;
            AreaCode = ar;
        }

        public Branch()
        {

        }
        public int insert()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.insertBranch(this);
            return numAffected;
        }
    }
}