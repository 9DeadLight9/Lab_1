using System;

namespace Task_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello write information about you to sign in your account");
            Console.WriteLine("Enter your login");
            string login = Console.ReadLine();
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter when you login to site");
            string data = Console.ReadLine();
            User user = new User(login, firstname, lastname, age, data);
            user.information();
            Console.ReadLine();
        }

    }
}
