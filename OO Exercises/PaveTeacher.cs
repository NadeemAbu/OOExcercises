using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Exercises
{
    class PaveTeacher:Teacher
    {
        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }

        public PaveTeacher(int pStaffID, string pFName, string pLName, string pGender): base(pStaffID, pFName, pLName, pGender)
        {
           TeachBehaviour = new TeachPAVE();
        }
    }
}
