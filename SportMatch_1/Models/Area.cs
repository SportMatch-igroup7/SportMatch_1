using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class Area
    {
        int areaCode;
        string areaName;

        public int AreaCode { get => areaCode; set => areaCode = value; }
        public string AreaName { get => areaName; set => areaName = value; }


        public Area()
        {

        }
        public Area(int areaCode1, string areaName1)
        {
            AreaCode = areaCode1;
            AreaName = areaName1;
        }

        public List<Area> getAreas()
        {
            DBservices dbs = new DBservices();
            List<Area> arrAreas = dbs.getAreas();
            return arrAreas;
        }
    }
}