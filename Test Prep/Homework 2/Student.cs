using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2
{
    public class Student
    {
        public string FirstName {get;set;}

        public string LastName {get;set;}

        public string Major {get;set;}

        public double GPA {get;set;}

        //Make sure you arent creating a new instance you are just using the other class and conencting them
        public Address Address { get; set; }



        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
            GPA = 0.0;
            Address = new Address();
        }

        public Student(string firstName, string lastName, string major, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            GPA = gpa;
            Address = new Address();

        }

        public string CalculateDistinction()
        {
            string gpaStatus = " ";

            if (GPA >= 3.80)//want to go from greatest to least because that way if it is not greater than 3.8 then it willmove on to the next else if
            {
                gpaStatus = "Cum Laude";

            }
            else if (GPA >= 3.60)
            {
                gpaStatus = "Magna Cum Laude";

            }
            else if (GPA >=3.40)
            {
                gpaStatus = "Summa Cum Laude";

            }
            else
            {
                gpaStatus = " ";
            }

            return gpaStatus;
        }

        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address add = new Address(streetNumber, streetName, state, city, zipcode);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Major}, {CalculateDistinction()}";
        }




    }
}
