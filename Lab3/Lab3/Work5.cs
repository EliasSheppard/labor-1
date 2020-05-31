using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Work5
    {
        public static void Begin()
        {
            try
            {
                int[,] MyArray;
                InputArray(out MyArray);
                PrintArray("Входящий массив:", MyArray);
                int sum = Change(MyArray);
                PrintArray("Итоговый масив", MyArray);
                Console.WriteLine("Сумма парных элементов: " + sum);
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception: Неверный формат");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Exception: Переполнение массива");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Exception: Недостаточно памяти для создания объекта");
            }
        }

        private static void InputArray(out int[,] mas)
        {
            Console.Write("Первая размерность: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Вторая размерность: ");
            int m = Int32.Parse(Console.ReadLine());
            mas = new int[n, m];

            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("Array[{0}, {1}]: ", i, j);
                    mas[i, j] = Int32.Parse(Console.ReadLine());
                }

        }

        private static void PrintArray(string a, int[,] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write("{0} ", mas[i, j]);
                Console.WriteLine();
            }
        }
        private static int Change(int[,] mas)
        {
            int result = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    if (mas[i, j] % 2 == 0)
                    {
                        result += mas[i, j];
                        mas[i, j] = 0;
                    }
            return result;
        }
    }
}
