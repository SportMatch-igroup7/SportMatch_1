using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace SportMatch_1.Models
{
    public class Parameter
    {
        int pcode;
        string pname;


        public string Pname { get => pname; set => pname = value; }
        public int Pcode { get => pcode; set => pcode = value; }

        public Parameter()
        {

        }
        public Parameter(string name)
        {
            Pname = name;
        }

        public DataTable GetParameter()
        {
            DBservices dbs = new DBservices();
            DataTable dtcontent = dbs.GetParameter();
            return dtcontent;
        }

        public List<Parameter> GetParameterBranchList()
        {
            DBservices dbs = new DBservices();
            List<Parameter> arrParameters = dbs.GetParameterBranchList();
            return arrParameters;
        }
        public int InsertParameter()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.InsertParameter(this);
            return numAffected;
        }



    }
}