using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args = null)
        {
            Console.Write("Номер задания: ");
            try
            {
                int n = Int32.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Work1.Begin();
                        break;
                    case 2:
                        Work2.Begin();
                        break;
                    case 3:
                        Work3.Begin();
                        break;
                    case 4:
                        Work4.Begin();
                        break;
                    case 5:
                        Work5.Begin();
                        break;
                    case 6:
                        Work6.Begin();
                        break;
                    case 7:
                        Work7.Begin();
                        break;
                    case 8:
                        Work8.Begin();
                        break;
                    case 9:
                        Work9.Begin();
                        break;
                    case 10:
                        Work10.Begin();
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

            Console.Write("Продолжить работу с программой? [Y/N]");
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            }
            while (key != ConsoleKey.Y && key != ConsoleKey.N);
            if (key == ConsoleKey.Y)
            {
                Console.Clear();
                Main();
            }
        }
    }
}
