using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSession
{
    class Rank
    {
        public const int iRANK_NUM_OF_FIELDS = 5;
        string sName {get; set;}
        string sDescription { get; set; }
        int iPointsRequirement { get; set; }
        int iTimeRequirementInDays { get; set; }
        string sPathToImageFile { get; set; }
    
        public Rank(string sTitle, string sDesc, int iPoints, int iTime, string sPath)
        {
            sName = sTitle;
            sDescription = sDesc;
            iPointsRequirement = iPoints;
            iTimeRequirementInDays = iTime;
            sPathToImageFile = sPath;
        }
        public override string ToString()
        {
            String sReturn;
            sReturn = String.Format("{0},{1},{2},{3},{4}", sName, sDescription, iPointsRequirement, iTimeRequirementInDays, sPathToImageFile);
            return sReturn;
        }

        internal string GetTitle()
        {
            return sName;
        }

        internal string GetDesc()
        {
            return sDescription;
        }

        internal string GetPoints()
        {
            return String.Format("{0}",iPointsRequirement);
        }

        internal string GetTime()
        {
            return String.Format("{0}", iTimeRequirementInDays);
        }

        internal string GetImagePath()
        {
            return sPathToImageFile;
        }
    }
    
}
