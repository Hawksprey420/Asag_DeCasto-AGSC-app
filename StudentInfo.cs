using Asag_DeCasto_AGSC_app;
using System;

public class StudentInfo
{
    public void Students(List<Students> students)
    {
        int student_count = 0;

        while (true)
        {
            student_count++;

            Students student = new Students();
            Console.WriteLine($"Please enter your name, student {student_count}");
            student.student_name = Console.ReadLine();

            Console.WriteLine($"Please enter the Quiz 1 grade of {student.student_name}");
            student.Quiz1_Grade  = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter the Quiz 2 grade of {student.student_name}");
            student.Quiz2_Grade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please Please enter the Quiz 3 grade of, {student.student_name}");
            student.Quiz3_Grade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please Please enter the Midterm Exam grade of, {student.student_name}");
            student.MidtermExam_Grade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please Please enter the Final Exam grade of, {student.student_name}");
            student.FinalExam_Grade = float.Parse(Console.ReadLine());

            students.Add(student);

            Console.WriteLine("Student added successfully!");

            if (student_count >= 3)
            {
                Console.WriteLine("Would you like to add more students?");
                Console.WriteLine("Y for Yes, N for No.");
                string add_prompt = Console.ReadLine().ToUpper();

                if (add_prompt == "N")
                {
                    Console.WriteLine();
                    return;
                }
                else if (add_prompt == "Y")
                {
                    Console.WriteLine("Please continue.");
                    continue;
                }
            }
        }
    }
}

