using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Work9
    {
        public static void Begin()
        {
            int n;
            int[] myArray = Generate(out n);
            Console.WriteLine("Входящий массив:");
            Print(myArray);
            int max = GetMaximize(myArray);
            Console.WriteLine();
            Console.WriteLine("Количество максимальных элементов: " + GetAmount(myArray, max));
            Console.WriteLine("Сумма между первым макс. и последним мин. элементами: " + GetSumElementsBetwenFirstMaxAndLastMin(myArray));
            Console.WriteLine("Минимальный элемент больше нуля: " + GetMinPositiveElement(myArray));
        }

        private static int[] Generate(out int n)
        {
            Console.Write("Введите размер массива: ");
            n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = -500 + rand.Next(1000);
            return a;
        }

        private static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0,5} ", arr[i]);
            Console.WriteLine();
        }

        private static int GetMaximize(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }

        private static int GetAmount(int[] arr, int value)
        {
            int totalValue = 0;
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] == value)
                    totalValue++;
            return totalValue;
        }

        private static int GetSumElementsBetwenFirstMaxAndLastMin(int[] myArray)
        {
            int result = 0;

            int max = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
                if (myArray[i] > max)
                    max = myArray[i];

            int min = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
                if (myArray[i] < min)
                    min = myArray[i];

            int maxFirstIdx = 0;
            while (max != myArray[maxFirstIdx])
                maxFirstIdx++;

            int minLastIdx = myArray.Length - 1;
            while (min != myArray[minLastIdx])
                minLastIdx--;

            if (maxFirstIdx == minLastIdx) return 0;

            int minIterator = (maxFirstIdx > minLastIdx) ? minLastIdx : maxFirstIdx;
            int maxIterator = (maxFirstIdx < minLastIdx) ? minLastIdx : maxFirstIdx;
            for(int i = minIterator + 1; i < maxIterator; i++)
                result += myArray[i];

            return result;
        }

        private static int GetMinPositiveElement(int[] myArray)
        {
            int result = 0;
            for(int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > 0 && (myArray[i] < result || result == 0))
                    result = myArray[i];
            }

            return result;
        }
    }
}
