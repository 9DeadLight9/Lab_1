using System;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter course of currency (USD,EUR,PLN)");
            double usd = double.Parse(Console.ReadLine());
            double eur = double.Parse(Console.ReadLine());
            double pln = double.Parse(Console.ReadLine());
            Converter converter = new Converter(usd, eur, pln);
            Console.WriteLine("Enter which operation you need 1 - is from grn to other currency or 2 - other currency to grn");
            int operation = int.Parse(Console.ReadLine());

            if (operation == 1)
            {
                Console.WriteLine("Enter your sum in grn");
                double sumaingrn = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter code of currency you need(USD EUR PLN)");
                string currency = Console.ReadLine();
                double result = converter.ConvertertoGRN(sumaingrn, currency);
                Console.Write($"Here your operation {result} {currency} ");
            }
            else if (operation == 2)
            {
                Console.WriteLine("Enter your sum in other currency");
                double sumainothercurrency = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter code of currency  you need(USD EUR PLN)");
                string currency = Console.ReadLine();
                double result = converter.ConverterfromGRN(sumainothercurrency, currency);
                Console.Write($"Your course {result} UAH");
            }
            else
            {
                Console.WriteLine("Wrong operation");
            }
        }
    }
}