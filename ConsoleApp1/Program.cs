using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string doubleNumber = "894376.243643";
            int number = (int)double.Parse(doubleNumber, CultureInfo.InvariantCulture); // Вася уверен, что ошибка где-то тут
            Console.WriteLine(number + 1);

            //var a = 2;
            //var b = a++ + ++a;

            var a = 5.0; // ← исправьте эту строку
            a += 0.5;
            Console.WriteLine(a);

        }
    }
}
