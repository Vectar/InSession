using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSession
{
    class ClassSessions
    {

        public const int iCLASS_NUM_OF_FIELDS = 5;
        private int iClassID;
        private string sClassName;
        private DateTime dtStartTime;
        //0 = Once
        //1 = Daily
        //2 = Weekly
        //3 = Bi=Weekly
        //4 = Monthly
        private int Reoccurrence;

        private bool isKids;
        
        public bool GetIsKids()
        {
            return isKids;
        }

        public int GetReoccurrence()
        {
            return Reoccurrence;
        }

        public string GetClassName()
        {
            return sClassName;
        }

        public string getDateTime()
        {
            return dtStartTime.ToString("yyyyMMdd HH:mm");
        }
        
        public int GetID()
        {
            return iClassID;
        }

        public ClassSessions()
        { 
            
        }

        public ClassSessions(int iID,string Name, DateTime dtDate, int iFreq, bool bKids)
        {
            iClassID = iID;
            sClassName = Name;
            dtStartTime = dtDate;
            Reoccurrence = iFreq;
            isKids = bKids;
        }
        public override string ToString()
        {
            String sReturn;
            sReturn = String.Format("{0},{1}", sClassName, dtStartTime.ToString())  ;
            return sReturn;
        }

    }
}
