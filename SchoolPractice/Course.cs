using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public string CourseName { get; set; }
        public int CourseCredit { get; set; }

        private List<string> roster = new List<string>();

        public Course(string courseName, int courseCredit)
        {
            CourseName = courseName;
            CourseCredit = courseCredit;
        }

        public void addStudent(Student student)
        {
            roster.Add(student.Name);
            //Console.WriteLine(student.Name);
        }

        public void printRoster()
        {
            foreach(string item in roster)
            {
                Console.WriteLine(item);
            }
        }


    }
}
