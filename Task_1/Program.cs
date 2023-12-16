using System;

namespace Lab_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Adress myAdress = new Adress();
            Console.WriteLine("Enter information about your location");
            Console.WriteLine("Enter your Index");
            myAdress.Index = Console.ReadLine();
            Console.WriteLine("Enter your Country");
            myAdress.Country = Console.ReadLine();
            Console.WriteLine("Enter your City");
            myAdress.City = Console.ReadLine();
            Console.WriteLine("Enter your Street");
            myAdress.Street = Console.ReadLine();
            Console.WriteLine("Enter your House");
            myAdress.House = Console.ReadLine();
            Console.WriteLine("Enter your Apartment");
            myAdress.Apartment = Console.ReadLine();
            Console.WriteLine("Індекс: " + myAdress.Index);
            Console.WriteLine("Країна: " + myAdress.Country);
            Console.WriteLine("Місто: " + myAdress.City);
            Console.WriteLine("Вулиця: " + myAdress.Street);
            Console.WriteLine("Будинок: " + myAdress.House);
            Console.WriteLine("Квартира: " + myAdress.Apartment);
        }




    }
}