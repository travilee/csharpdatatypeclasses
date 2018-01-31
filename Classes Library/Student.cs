using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Library
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public float GPA { get; set; }

        public Student() {}

        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            GPA = gpa;
        }

        public override string ToString()
        {
            return string.Format($"Student Name: {FirstName} {LastName}\nID: {ID}\nGPA: {GPA}"); 
        }
    }
}
