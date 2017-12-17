using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomeWork
{
    public class Student : IStudent
    {
        private string name;
        private string fullName;
        int i = 10;
        //int[] grades = new int[5];

        public Student(string name_, string fullName_, int[] grades) 
        {
            Name = name_;
            FullName = fullName_;
            Grades = grades;
        }

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        public int[] Grades
        {
            get
            {
                return Grades;
            }

            set
            {

                Grades = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double GetAvgGrade()
        {
            int sum = 0;
            for(int i=0; i<Grades.Length; i++)
            {
                sum += Grades[i];
            }
            return sum;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
