using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Exercises
{
    class SpecialNeedsTeacher:Teacher
    {
        public SpecialNeedsTeacher(int pStaffID, string pFName, string pLName, string pGender): base(pStaffID, pFName, pLName, pGender)
        {
            TeachBehaviour = new TeachSpecialNeeds();
        }
    }
}
