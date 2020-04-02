using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class Company
    {
        int companyNo;
        string name;
        int phoneNo;
        string website;

        public int CompanyNo { get => companyNo; set => companyNo = value; }
        public string Name { get => name; set => name = value; }
        public int PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Website { get => website; set => website = value; }


        public Company() { }

        public Company(string Name1, int phoneNo1, string website1)
        {
            Name = Name1;
            PhoneNo = phoneNo1;
            Website = website1;
        }

        public List<Company> getCompany()
        {
            DBservices dbs = new DBservices();
            List<Company> arrCompany = dbs.getCompany();
            return arrCompany;
        }

    }


}