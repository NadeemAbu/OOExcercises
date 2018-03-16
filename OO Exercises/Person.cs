using System;

namespace OO_Exercises
{
    public abstract class Person
    {
        private string fName;
        private string Gender;
        private string lName;

        public string GetGender()
        {
            return Gender;
        }

        public virtual string GetOccupation()
        {
            return "Unemployed";
        }

        public Person(string pFName, string pGender, string pLName)
        {
            fName = pFName;
            Gender = pGender;
            lName = pLName;

            
        }

        public Person(string pGender)
        {
            Gender = pGender;

            switch (Gender)
            {
                case "M":
                    fName = "John";
                    lName = "Doe";
                    break;

                case "F":
                    fName = "Jane";
                    lName = "Doe";
                    break;

                    default:
                    throw new InvalidOperationException("Invalid Gender Passed to Person Constructor");

            }
        }

        public abstract string Work();


        public string Fname
        {
            get { return fName; }
            set { fName = value; }
        }


        public string Lname
        {
            get { return lName; }
            set { lName = value; }
        }
    }
}
