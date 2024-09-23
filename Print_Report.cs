using System;
using System.Collections.Generic;

namespace Asag_DeCasto_ASGC_app
{
    public class Print_Report
    {
        public float CalculateAverage(Students students)
        {
            return (students.Quiz1_Grade + students.Quiz2_Grade + students.Quiz3_Grade + students.MidtermExam_Grade + students.FinalExam_Grade) / 5;
        }

        public string ConvertToLetterGrade(float grade)
        {
            if (grade >= 90) return "A";
            else if (grade >= 80) return "B";
            else if (grade >= 70) return "C";
            else if (grade >= 60) return "D";
            else return "F";
        }

        public void Report(List<Students> students)
        {
            Line line = new Line();
            foreach (Students student in students)
            {
                Console.WriteLine($"Hello {student.student_name}!");
                Console.WriteLine($"Quiz 1 - {student.Quiz1_Grade} ({ConvertToLetterGrade(student.Quiz1_Grade)})");
                Console.WriteLine($"Quiz 2 - {student.Quiz2_Grade} ({ConvertToLetterGrade(student.Quiz2_Grade)})");
                Console.WriteLine($"Quiz 3 - {student.Quiz3_Grade} ({ConvertToLetterGrade(student.Quiz3_Grade)})");
                Console.WriteLine($"Mid Term Exam - {student.MidtermExam_Grade} ({ConvertToLetterGrade(student.MidtermExam_Grade)})");
                Console.WriteLine($"Final Exam - {student.FinalExam_Grade} ({ConvertToLetterGrade(student.FinalExam_Grade)})");
                line.LineGeneration();
                Console.WriteLine($"Your average in all subject quizzes and exams {student.student_name} is {CalculateAverage(student)} ({ConvertToLetterGrade(CalculateAverage(student))})");
                Console.WriteLine(); // For better UI, add a line break
            }
        }
    }
}
