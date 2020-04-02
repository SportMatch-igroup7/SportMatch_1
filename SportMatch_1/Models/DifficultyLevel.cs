using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class DifficultyLevel
    {
        int levelCode;
        string levelName;

        public int LevelCode { get => levelCode; set => levelCode = value; }
        public string LevelName { get => levelName; set => levelName = value; }

        public DifficultyLevel() { }

        public DifficultyLevel(int code, string name)
        {
            LevelCode = code;
            LevelName = name;
        }

        public List<DifficultyLevel> getDifficultyLevel()
        {
            DBservices dbs = new DBservices();
            List<DifficultyLevel> arrDL = dbs.getDifficultyLevel();
            return arrDL;
        }
    }
}