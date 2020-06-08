using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public string getGradeLevel()
        {
            if (this.NumberOfCredits < 30)
            {
                return "Freshman";
            }
            else if (this.NumberOfCredits < 60)
            {
                return "Sophomore";
            }
            else if (this.NumberOfCredits < 90)
            {
                return "Junior ";
            }
            else if (this.NumberOfCredits >= 90)
            {
                return "Senior ";
            }
            else
            {
                return "Invalid credit number";
            }
        }

        public double addGrade(int numCred, double numGrade)
        {
            double totalScore = (NumberOfCredits * Gpa) + (numCred * numGrade);
            this.NumberOfCredits = this.NumberOfCredits + numCred;
            this.Gpa = Math.Round(totalScore / NumberOfCredits, 2);

            return Gpa;
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override Boolean Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.StudentId == StudentId;
        }
    }
}
