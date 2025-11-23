using System;

namespace LoginSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // A simple "library" of usernames and passwords (like key-value pairs)
            Dictionary<string, string> users = new Dictionary<string, string>()
            {
                {"alice", "pass123"},
                {"bob", "qwerty"},
                {"charlie", "hello123"},
                {"david", "abc123"},
                {"eva", "mypassword"}
            };
            // added the "ToLower()" method to make the username case-insensitive
            Console.Write("Enter username: ");
            string username = Console.ReadLine().ToLower();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // First IF checks if the username exists
            if (users.ContainsKey(username))
            {
                // Nested IF checks if the password matches
                if (users[username] == password)
                {
                    Console.WriteLine("Correct username and password!");
                }
                else
                {
                    Console.WriteLine("Correct username but wrong password!");
                }
            }
            else
            {
                Console.WriteLine("Wrong username!");
            }

            // In my opinion, the error messages for the two usuccesful login attempts.
            // The messages should be the same in both cases. 
           
        }
    }
}

