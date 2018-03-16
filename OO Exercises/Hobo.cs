using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Exercises
{
    class Hobo : Person
    {

        public Hobo(string pFname, string pFLName, string pGender): base (pFname, pFLName, pGender)
        {
        }

        public Hobo(string pGender) : base(pGender)
        {
        }

        public override string Work()
        {
            return "Find A Place To Sleep";
        }
    }
}
