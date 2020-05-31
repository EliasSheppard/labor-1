using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Work10
    {
        public static void Begin()
        {
            int n;
            int[,] myArray = Generate(out n);
            Console.WriteLine("Входящий массив:");
            Print(myArray);
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое непарных над главной диагональю: " + CalculateOverMainDiagonal(myArray).ToString());
            Console.WriteLine("Среднее арифметическое под побочной диагональю: " + CalculateUnderSideDiagonal(myArray).ToString());
        }

        private static int[,] Generate(out int n)
        {
            Console.Write("Введите размер массива: ");
            n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = -500 + rand.Next(1000);
            return a;
        }

        private static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0,5} ", arr[i, j]);
        }

        private static double CalculateOverMainDiagonal(int[,] arr)
        {
            double result = 0, count = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
                for(int j = i; j < arr.GetLength(1); j++)
                    if(arr[i, j] % 2 == 1)
                    {
                        result += arr[i, j];
                        count++;
                    }
            if (count == 0) return 0;
            else result /= count;
            return result;
        }

        private static double CalculateUnderSideDiagonal(int[,] arr)
        {
            double result = 0, count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = arr.GetLength(0) - i - 1; j < arr.GetLength(1); j++)
                {
                    result += arr[i, j];
                    count++;
                }
            if (count == 0) return 0;
            else result /= count;
            return result;
        }
    }
}
