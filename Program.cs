
namespace Asag_DeCasto_ASGC_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            Print_Report report = new Print_Report();
            List<Students> students = new List<Students>();
            StudentInfo student_Info = new StudentInfo();


            while (true) 
            {
                Console.WriteLine("Hello there!");
                Console.WriteLine("This is the AGSC app!");

                line.LineGeneration();

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("a. Add/view students");
                Console.WriteLine("b. Print grades");
                Console.WriteLine("c. View the authors");
                Console.WriteLine("d. Quit the application");

                line.LineGeneration();

                string user_input = Console.ReadLine();

                switch (user_input)
                {
                    case "a":
                        student_Info.Students(students);
                        line.LineGeneration();
                        break;

                    case "b":
                        report.Report(students);
                        break;

                    case "c":
                        Console.WriteLine("Nestor Jann C. Asag - GitHub Repo owner, maintainer");
                        Console.WriteLine("Carl De Castro - GitHub collaborator");
                        break;

                    case "d":
                        Console.WriteLine("Are you sure you want to quit? Y for Yes, N for No");

                        string user_choice = Console.ReadLine();

                        if (user_choice == "Y")
                        {
                            Console.WriteLine("Thanks for using AGSC!");
                        }
                        else if (user_choice == "N")
                        {
                            continue;   
                        }
                        Console.ReadKey();
                        return;

                    default:
                        Console.WriteLine("Invalid input.");
                        continue;
                }
            }
        }

    }
}
