using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class Qualification
    {
        int typeCode;
        string typeName;
        string description;

        public int TypeCode { get => typeCode; set => typeCode = value; }
        public string TypeName { get => typeName; set => typeName = value; }
        public string Description { get => description; set => description = value; }

        public Qualification() { }

        public Qualification(int typecode1, string typename1, string desc)
        {
            TypeCode = typecode1;
            typeName = typename1;
            Description = desc;
        }

        public List<Qualification> getQualifications()
        {
            DBservices dbs = new DBservices();
            List<Qualification> arrQual = dbs.getQualification();
            return arrQual;
        }
    }
}