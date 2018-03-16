using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Exercises
{
    class SecondaryTeacher : Teacher
    {
        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }

        public SecondaryTeacher(int pStaffID, string pFName, string pLName, string pGender) : base (pStaffID, pFName, pLName, pGender)
        {
            TeachBehaviour = new TeachHighSchool();
        }
    }
}
