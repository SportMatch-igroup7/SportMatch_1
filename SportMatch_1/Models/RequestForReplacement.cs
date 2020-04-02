using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class RequestForReplacement
    {
        int replacementCode;
        string publishDateTime;
        string contactName;
        int branchCode;
        int classTypeCode;
        string fromHour;
        string toHour;
        string replacementDate;
        string classDescription;
        string comments;
        int difficultyLevelCode;
        int maxPrice;
        int languageCode;
        int populationCode;

        public int ReplacementCode { get => replacementCode; set => replacementCode = value; }
        public string PublishDateTime { get => publishDateTime; set => publishDateTime = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public int BranchCode { get => branchCode; set => branchCode = value; }
        public int ClassTypeCode { get => classTypeCode; set => classTypeCode = value; }
        public string FromHour { get => fromHour; set => fromHour = value; }
        public string ToHour { get => toHour; set => toHour = value; }
        public string ReplacementDate { get => replacementDate; set => replacementDate = value; }
        public string ClassDescription { get => classDescription; set => classDescription = value; }
        public string Comments { get => comments; set => comments = value; }
        public int DifficultyLevelCode { get => difficultyLevelCode; set => difficultyLevelCode = value; }
        public int MaxPrice { get => maxPrice; set => maxPrice = value; }
        public int LanguageCode { get => languageCode; set => languageCode = value; }
        public int PopulationCode { get => populationCode; set => populationCode = value; }


        public RequestForReplacement() { }

        public int insert()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.insertRequest(this);
            return numAffected;
        }
    }  
}