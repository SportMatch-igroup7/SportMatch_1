using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class BranchParameter
    {
        int branchCode;
        int parameterCode;
        float parameterWeight;

        public int BranchCode { get => branchCode; set => branchCode = value; }
        public int ParameterCode { get => parameterCode; set => parameterCode = value; }
        public float ParameterWeight { get => parameterWeight; set => parameterWeight = value; }

        public BranchParameter()
        { }

        public BranchParameter(int bCode, int pCode, float pWeight)
        {
            this.BranchCode = bCode;
            this.ParameterCode = pCode;
            this.parameterWeight = pWeight;
        }
        public int InsertBranchParameter()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.InsertBranchParameter(this);
            return numAffected;
        }
    }
}