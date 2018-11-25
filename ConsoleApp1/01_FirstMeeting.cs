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
    class ProgramExpr1
    {
        //Expr1. Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
        static void Main(string[] args)
        {
            var x = 564.3;
            var y = -343.6;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            Console.WriteLine(" ");
            x = (x - y) / 2;
            y += 2 * x;
            x = y - 2 * x;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
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
    class ProgramExpr4
    {
        //Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N:");
            var s = Console.ReadLine();
            var n = int.Parse(s);
            Console.WriteLine("Введите первый простой делитель Х:");
            s = Console.ReadLine();
            var x = int.Parse(s);
            Console.WriteLine("Введите второй простой делитель Y:");
            s = Console.ReadLine();
            var y = int.Parse(s);
            var ost = 0;
            Console.WriteLine("Количество чисел меньше " + n + ", которые имеют простой делитель " + x + ": " + Math.DivRem(n, x, out ost));
            Console.WriteLine("Количество чисел меньше " + n + ", которые имеют простой делитель " + y + ": " + Math.DivRem(n, y, out ost));
            Console.WriteLine("Всего: " + (Math.DivRem(n, x, out ost) + Math.DivRem(n, y, out ost)).ToString());

        }
    }
    class ProgramExpr5
    {
        //Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый год:");
            var s = Console.ReadLine();
            var a = int.Parse(s);
            Console.WriteLine("Введите последний год:");
            s = Console.ReadLine();
            var b = int.Parse(s);
            var ost = 0;
            var vis = Math.DivRem(b - a, 4, out ost);
            //учитываем что каждые 100 лет год не високосный (нулевой - 1700-й, 1800-й и т.д.)
            vis -= Math.DivRem(b - a, 100, out ost);
            //учитываем что из невисокосных нулевых лет, каждый четвертый високосный (1600-й, 2000-й, 2400-й и т.д.)
            vis += Math.DivRem(b - a, 400, out ost);
            Console.WriteLine("Високосных между ними: " + vis.ToString());

        }
    }

}
