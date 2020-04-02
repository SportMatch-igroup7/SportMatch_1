using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class Language
    {
        int lanCode;
        string lanName;

        public int LanCode { get => lanCode; set => lanCode = value; }
        public string LanName { get => lanName; set => lanName = value; }

        public Language() { }

        public Language(int code, string name)
        {
            LanCode = code;
            LanName = name;
        }

        public List<Language> getLanguage()
        {
            DBservices dbs = new DBservices();
            List<Language> arrLang = dbs.getLanguage();
            return arrLang;
        }
    }
}