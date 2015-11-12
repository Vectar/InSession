using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSession
{
    public class Student
    {

        public const int iSTUDENT_NUM_OF_FIELDS = 12;
        int iStudentID;
        String sFName { get; set; }
        String sLName { get; set; }
        String sPhone { get; set; }
        String sAddress { get; set; }
        String sCity { get; set; }
        String sState { get; set; }
        String sZip { get; set; }
        String sEContactFName { get; set; }
        String sEContactLName { get; set; }
        String sEContactPhone { get; set; }
        String sEContactRelationship { get; set; }
        String sRank { get; set; }

        public Student()
        { }
        public Student(int iID, String stxtFname, String stxtLname,  String stxtPhone, String stxtAddress, String stxtCity,
            String stxtState, String stxtZip, String stxtEContactFName, String stxtEContactLName,
            String stxtEContactPhone, String stxtEContactRelationship, String stxtRank)
        {
            iStudentID = iID;
            sFName = stxtFname;
            sLName = stxtLname;
            sAddress = stxtAddress;
            sCity = stxtCity;
            sState = stxtState;
            sZip = stxtZip;
            sPhone = stxtPhone;
            sEContactFName = stxtEContactFName;
            sEContactLName = stxtEContactLName;
            sEContactPhone = stxtEContactPhone;
            sEContactRelationship = stxtEContactRelationship;
            sRank = stxtRank;
        }
        public override string ToString()
        {
            String sReturn;
            sReturn = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                iStudentID, sFName, sLName, sPhone, sAddress, sCity, sState, sZip, sEContactFName, sEContactLName,
                sEContactPhone, sEContactRelationship);
            return sReturn;
        }
        public Student(Student student)
        {
            iStudentID = student.iStudentID;
            sFName = student.sFName;
            sLName = student.sLName;
            sAddress = student.sAddress;
            sCity = student.sCity;
            sState = student.sState;
            sZip = student.sZip;
            sPhone = student.sPhone;
            sEContactFName = student.sEContactFName;
            sEContactLName = student.sEContactLName;
            sEContactPhone = student.sEContactPhone;
            sEContactRelationship = student.sEContactRelationship;
            sRank = student.sRank;
        }
        public Student LoadStudentByID(String id, List<Student> lstStudents)
        {
            Student rStudent = new Student();
            try
            {
                rStudent = lstStudents.Find(student => student.iStudentID == Int32.Parse(id));
            }
            catch 
            { 
                rStudent = null; 
            }
            return rStudent;
        }


        internal bool IsValid()
        {
            return (iStudentID > 0);
        }

        internal string GetFirstName()
        {
            return sFName;
        }

        internal string GetLastName()
        {
            return sLName;
        }

        internal string GetPhone()
        {
            return sPhone;
        }

        internal string GetAddress()
        {
            return sAddress;
        }

        internal string GetCity()
        {
            return sCity;
        }

        internal string GetZip()
        {
            return sZip;
        }

        internal string GetEContactFName()
        {
            return sEContactFName;
        }

        internal string GetState()
        {
            return sState;
        }

        internal string GetEContactLName()
        {
            return sEContactLName;
        }

        internal string GetEContactPhone()
        {
            return sEContactPhone;
        }

        internal string GetERelationship()
        {
            return sEContactRelationship;
        }

        internal Int32 GetID()
        {
            return iStudentID;
        }
    }
}
