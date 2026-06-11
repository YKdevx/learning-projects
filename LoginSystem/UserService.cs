using System.Collections.Generic;
using System.Linq;

class UserService
{
    private List<User> users = new List<User>();

    public void Register(string username, string password)
    {
        users.Add(new User(username, password));
        Console.WriteLine("User registered successfully!");
    }

    public bool Login(string username, string password)
    {
        return users.Any(u => u.Username == username && u.Password == password);
    }

    public void ShowUsers()
    {
        Console.WriteLine("Registered Users:");
        foreach (var user in users)
        {
            Console.WriteLine(user.Username);
        }
    }
}
