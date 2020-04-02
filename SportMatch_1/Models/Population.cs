using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class Population
    {
        int code;
        string pName;

        public int Code { get => code; set => code = value; }
        public string PName { get => pName; set => pName = value; }

        public Population() { }

        public Population (int code1, string name)
        {
            Code = code1;
            PName = name;
        }

        public List<Population> getPopulation()
        {
            DBservices dbs = new DBservices();
            List<Population> arrpop = dbs.getPopulation();
            return arrpop;
        }
    }
}