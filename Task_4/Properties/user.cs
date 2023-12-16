using System;
using System.Reflection;
using System.Runtime.InteropServices;

class User
{
    private string login;
    private string name;
    private string surname;
    private int age;
    private string data;

    public User(string login, string name, string surname, int age, string data)
    {
        this.login = login;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.data = data;

    }

    public void information()
    {
        Console.WriteLine("Your information");
        Console.WriteLine("Your login is " + login);
        Console.WriteLine($"Your fullname  is  {name} {surname}");
        Console.WriteLine($"Your age is {age}");
        Console.WriteLine("Data of enter to site " + data);

    }
}