using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            double oneFifthStuds = Students.Count / 5;
            double checkStudents = 0;

            foreach (var student in Students)
            {
                if (averageGrade < student.AverageGrade)
                {
                    checkStudents += 1;
                }
            }

            int dropGrade = 0;
            while (checkStudents >= oneFifthStuds)
            {
                checkStudents -= oneFifthStuds;
                dropGrade += 1;
            }

            if (dropGrade == 0)
                return 'A';
            else if (dropGrade == 1)
                return 'B';
            else if (dropGrade == 2)
                return 'C';
            else if (dropGrade == 3)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
