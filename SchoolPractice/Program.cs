using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            // Building new student without constructor
            //Student andrewM = new Student();
            //andrewM.Name = "Andrew";
            //andrewM.StudentId = 11111;
            //andrewM.NumberOfCredits = 1;
            //andrewM.Gpa = 4.0;

            // Building new objects with constructor
            Student andrewM = new Student("Andrew", 11111, 1, 4.0);
            Course lc101 = new Course("LC 101", 1);

            // demonstrate methods inside Course using Student
            lc101.addStudent(andrewM);

            // demonstrate that both this and prior method function as expected
            lc101.printRoster();

        }
    }
}
