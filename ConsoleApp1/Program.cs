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
           // Console.WriteLine(number + 1);

            //var a = 2;
            //var b = a++ + ++a;

            var a = 5.0; // ← исправьте эту строку
            a += 0.5;
            //Console.WriteLine(a);

            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));

            Print(GetSquare(42));

            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));

        }

        static string GetLastHalf(string text)
        {
            var s = text.Substring(text.Length / 2);
            return s.Replace(" ", ""); 
        }
        private static string GetGreetingMessage(string name, double salary)
        {
            // возвращает "Hello, <name>, your salary is <salary>"
            return "Hello, " + name + ", your salary is " + Math.Ceiling(salary).ToString();
        }

        private static double GetSquare(double num)
        {
            return Math.Pow(num,2);
        }

        private static void Print(double num)
        {
            Console.WriteLine(num.ToString());
        }
    }
}
