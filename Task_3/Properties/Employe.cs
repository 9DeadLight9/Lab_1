using System;
using System.Reflection;
using System.Runtime.InteropServices;

public class Employee
{
    private string прізвище1;
    private string імя1;
    private string посада1;
    private int стаж1;
    private double оклад1;

    public Employee(string прізвище, string імя)
    {
        прізвище1 = прізвище;
        імя1 = імя;
    }

    public void ВведітьПосаду(string посада)
    {
        посада1 = посада;
    }

    public void ВведітьСтаж(int стаж)
    {
        стаж1 = стаж;
    }

    public void РозрахуватиОклад()
    {
            
        if (посада1 == "менеджер")
        {
            оклад1 = 30000 + (стаж1 * 1000);
        }
        else if (посада1 == "розробник")
        {
            оклад1 = 40000 + (стаж1 * 1500);
        }
        else
        {
            оклад1 = 25000 + (стаж1 * 800);
        }
    }

    public double РозрахуватиПодатковийЗбір()
    {
            
        double податок = оклад1 * 0.15; // Податок 15% від окладу
        return податок;
    }

    public void ВивестиІнформацію()
    {
        Console.WriteLine("Інформація про співробітника:");
        Console.WriteLine("Прізвище: " + прізвище1);
        Console.WriteLine("Ім'я: " + імя1);
        Console.WriteLine("Посада: " + посада1);
        Console.WriteLine("Оклад: " + оклад1 + " грн");
        Console.WriteLine("Податковий збір: " + РозрахуватиПодатковийЗбір() + " грн");
    }
}