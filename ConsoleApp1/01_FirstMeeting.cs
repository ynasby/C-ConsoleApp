using System;
using System.Globalization;

// решение задачек из FirstMeeting  и прочая временная фигня
namespace ConsoleApp1
{
    class Program
    {
        static string who = "class";

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

            //Console.WriteLine(GetGreetingMessage("Student", 10.01));
            //Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            //Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));

            //Print(GetSquare(42));

            //Console.WriteLine(GetLastHalf("I love CSharp!"));
            //Console.WriteLine(GetLastHalf("1234567890"));
            //Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));

            //Console.Write(who + " ");
            //string who = "Mixed";
            //Console.Write(who);
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
        void M1()
        {
            int i = 0;
            {
                int i = 1;
            }
        }
        void M2(int i)
        {
            int i = 0;
        }
        void M3()
        {
            // Фигурными скобками можно группировать операторы (правда почти никогда этого делать не стоит)
            // и каждая пара фигурных скобок создает свою область видимости.
            {
                int i = 0;
            }
            {
                int i = 1;
            }
        }
    }
    class ProgramExpr2
    {
        //Expr2.Задается натуральное трехзначное число(гарантируется, что трехзначное). Развернуть его, т.е.получить трехзначное число, 
        //записанное теми же цифрами в обратном порядке.
            static void Main(string[] args)
        {
            var n = 456;
            Console.WriteLine(n);
            var ost = 0;
            var m1 = Math.DivRem(n, 100, out ost);
            var m2 = Math.DivRem(ost, 10, out ost);
            n = ost * 100 + m2 * 10 + m1;
            Console.WriteLine(n);
        }
    }
    class ProgramExpr3
    {
        //Expr3. Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. 
        //Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.
        static void Main(string[] args)
        {
            int angle = 0;
            int ost = 0;
            for (int h = 0; h < 24; h++)
            {
                if ((Math.DivRem(h, 6, out ost) == 0) || (Math.DivRem(h, 6, out ost) == 2))
                {
                    angle = ost * 30;
                }
                else
                {
                    angle = 180 - ost * 30;
                }
                Console.WriteLine(h + " часов");
                Console.WriteLine("угол " + angle);
            }
        }
    }
}
