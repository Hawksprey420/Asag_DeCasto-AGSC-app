using Asag_DeCastro_ASGC_app;
using System;
using System.Collections.Generic;

public class StudentInfo
{
    public void Students(List<Students> students)
    {
        while (true)
        {
            Students student = new Students();
            Console.WriteLine($"Please enter your name, student {students.Count + 1}");
            student.student_name = Console.ReadLine();

            Console.WriteLine($"Please enter the Quiz 1 grade of {student.student_name}");
            student.Quiz1_Grade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter the Quiz 2 grade of {student.student_name}");
            student.Quiz2_Grade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter the Quiz 3 grade of {student.student_name}");
            student.Quiz3_Grade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter the Assignment 1 grade of {student.student_name}");
            student.Assignment1_Grade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter the Assignment 2 grade of {student.student_name}");
            student.Assignment2_Grade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter the Assignment 3 grade of {student.student_name}");
            student.Assignment3_Grade = float.Parse(Console.ReadLine()) ;

            Console.WriteLine($"Please enter the Midterm Exam grade of {student.student_name}");
            student.MidtermExam_Grade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter the Final Exam grade of {student.student_name}");
            student.FinalExam_Grade = float.Parse(Console.ReadLine());

            students.Add(student);
            Console.WriteLine("Student added successfully!");

            Console.WriteLine("Would you like to add more students? Y for Yes, N for No.");
            string add_prompt = Console.ReadLine().ToUpper();

            if (add_prompt == "N")
            {
                Console.WriteLine("Exiting student addition.");
                return;
            }
            else if (add_prompt == "Y")
            {
                Console.WriteLine("Please continue.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
            }
        }
    }
}
