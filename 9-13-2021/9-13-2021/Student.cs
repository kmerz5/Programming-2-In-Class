using System;
using System.Collections.Generic;
using System.Text;

namespace _9_13_2021
{
    public class Student
    {
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }

        private double BursarBalance;

        public Student()
        {
            SoonerID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0.0;
            BursarBalance = 0.00;
        }

        public Student(int id, string fName, string lName, double bursarbalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0.0;
            BursarBalance = bursarbalance;

        }

        public void MakePayment(double amount)
        {
            if (amount <0)
            {
                throw new Exception("Your answer cannot be negative");
            }
            BursarBalance -= amount;
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }

        public override string ToString()
            {
                return $"{LastName}, {FirstName}";
            }
        

    }
}
