using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Exercises
{
    class Teacher:Person
    {
        private int staffID;
        protected ITeach TeachBehaviour;


        public override string GetOccupation()
        {
            return "Teacher";
        }

        public Teacher(int pStaffID, string pFname, string pLName, string pGender): base (pFname, pLName, pGender)
        {
            StaffID = pStaffID;
        }

        public override string Work()
        {
            return TeachBehaviour.Teach();
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
    }
}
