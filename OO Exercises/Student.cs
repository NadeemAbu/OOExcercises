using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Exercises
{
    class Student : Person
    {
        private int studentID;

        public Student(int pStudentId, string pFName, string pLName, string pGender): base (pFName, pLName, pGender)
        {
            studentID = pStudentId;
        }

        public override string Work()
        {
            return "Study, Drink Coffee, Party, Sleep, Repeat";
        }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

    }
}
