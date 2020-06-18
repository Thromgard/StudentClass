using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClass
{
    class Student
    {
        public double GPA;
        public int SAT;
        public int TimesTardy;
        public string Name;
        public int Id;

        private double SecretNumberCalculation(double bnumber, int SecretNumber)
        {

            return bnumber / SecretNumber;

        }

        public double BC(int SecretNumber)
        {

            var dblSAT = SAT * 2;
            var b = dblSAT * GPA;
            var bc = SecretNumberCalculation(b, SecretNumber);
            return bc;

        }

        public string GetValues()
        {
            return $"{Id}|{Name}|{SAT}|{GPA}|{TimesTardy}";

        }

        public Student() //default constructor
        {
            this.Id = 0;
            this.GPA = 2.0;
            this.SAT = 1000;


        }

        public Student(string Name, int Id, double GPA, int SAT, int TimesTardy)
        {

            this.Name = Name;
            this.Id = Id;
            this.GPA = GPA;
            this.SAT = SAT;
            this.TimesTardy = TimesTardy;

        }
    }
}
