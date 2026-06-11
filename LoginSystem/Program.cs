class Program
{
    static void Main()
    {
        UserService service = new UserService();

        while (true)
        {
            Console.WriteLine("\n1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Show Users");
            Console.WriteLine("4. Exit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                service.Register(username, password);
            }
            else if (choice == "2")
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                bool result = service.Login(username, password);

                Console.WriteLine(result ? "Login successful!" : "Login failed!");
            }
            else if (choice == "3")
            {
                service.ShowUsers();
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}
