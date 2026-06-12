class Program
{
    static void Main()
    {
        StudentService service = new StudentService();

        string menu = @"
========= Student Database =========
1- Add Student
2- List Students (Without Average)
3- List Students (With Average)
4- Medium Average Students
5- High Average Students
6- Low Average Students
0- Exit
";

        Console.WriteLine(menu);

        while (true)
        {
            Console.Write("Enter choice: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            switch (choice)
            {
                case 1:
                    service.AddStudent();
                    break;

                case 2:
                    service.ListStudents(false);
                    break;

                case 3:
                    service.ListStudents(true);
                    break;

                case 4:
                    service.FilterByAverage(10, 15, ConsoleColor.DarkGray, "Medium Average Students");
                    break;

                case 5:
                    service.FilterByAverage(15, 20, ConsoleColor.Green, "High Average Students");
                    break;

                case 6:
                    service.FilterByAverage(0, 10, ConsoleColor.Red, "Low Average Students");
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
