using System;

namespace NESTED_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter email ID...");
            string email = Console.ReadLine();
            if (email == "parmeshwarbadad5@gmail.com")
            {
               Console.WriteLine("Enter password...");
               string password = Console.ReadLine();
                  if (password == "Ittefaq1")
                  {
                     Console.WriteLine("Login sucessfulle...");
                  }
                  else
                  {
                     Console.WriteLine("Incorrect password...");
                  }

            }
            else
            {
                Console.WriteLine("Invalid email ID...");

            }
        }
    }
}
