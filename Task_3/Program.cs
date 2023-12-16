using System;

namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть прізвище співробітника:");
            string прізвище = Console.ReadLine();
        
            Console.WriteLine("Введіть ім'я співробітника:");
            string ім_я = Console.ReadLine();

            Employee співробітник = new Employee(прізвище, ім_я);

            Console.WriteLine("Введіть посаду співробітника:");
            string посада = Console.ReadLine();
            співробітник.ВведітьПосаду(посада);

            Console.WriteLine("Введіть стаж співробітника (в роках):");
            int стаж = int.Parse(Console.ReadLine());
            співробітник.ВведітьСтаж(стаж);

            співробітник.РозрахуватиОклад();
            співробітник.ВивестиІнформацію();
        }
    }
}