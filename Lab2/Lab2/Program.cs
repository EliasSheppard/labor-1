using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задание ");
            try
            {
                int n = Int32.Parse(Console.ReadLine());
                switch (n)
                {
                    case 2:
                        Work2();
                        break;
                    case 4:
                        Work4();
                        break;
                    case 5:
                        Work5();
                        break;
                    default:
                        Console.WriteLine("Неверное задание!");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            Console.Write("Нажите на любую клавишу для закрытия...");
            Console.ReadKey();
        }

        }
        static void Work2()
        {
            int i = 9;
            double x, y;
            Console.Write("Введите x: ");
            x = Double.Parse(Console.ReadLine());
            if (Math.Abs(x) < 10)
            {
                double a, b;
                Console.Write("Введите a: ");
                a = Double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                b = Double.Parse(Console.ReadLine());

                y = Math.Tan(x / i + a) - Math.Log(b * i + 7);
            }
            else
            {
                double c, d;
                Console.Write("Введите c: ");
                c = Double.Parse(Console.ReadLine());
                Console.Write("Введите d: ");
        
        
        static void Work4()
        {
            int i = 9;
            double a = 0.0, b = 1.0, z;

            for (int x = i; x <= i + 8; x++)
            {
                a += Math.Cos(Math.Pow(x, 2) + 1) - Math.Abs(Math.Sin(2 * x) - 5.76);
            }

            for (int x = i; x <= i + 5; x++)

            z = Math.Pow(Math.Abs(a * b), (double)(1m / 4m));
            Console.WriteLine("z = " + z.ToString());
        }
        static void Work5()
        {
            Console.WriteLine("1) Приведение в степень");
            Console.WriteLine("2) Квадратный корень");
            Console.WriteLine("3) Расчитать проценты");

            Console.Write("Введите a: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("Введите номер действия: ");
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Write("Введите b: ");
                        int b = Int32.Parse(Console.ReadLine());
                        int result = (int)Math.Pow(a, b);
                        Console.WriteLine("a в степени b: " + result.ToString());
                        break;
                    }
                case 2:
                    {
                        double result = Math.Sqrt(a);
                        Console.WriteLine("Корень a: " + result.ToString());
                    }
                    break;
                case 3:
                    {
                        Console.Write("Введите b: ");
                        int b = Int32.Parse(Console.ReadLine());
                        double result = Math.Round((double)(a * b / 100m));
                        Console.WriteLine("a % b: " + result.ToString());
                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер действия!");
                    break;
            }
        }
    }
}
