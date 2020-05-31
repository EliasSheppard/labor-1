using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Work3
    {
        public static void Begin()
        {
            int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i;
            try
            {
                for (i = 0; i <= 10; i++)
                    Console.Write(myArray[i] + " ");
                Console.Write("\n");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("\n");
                Console.WriteLine("Range Exception: " + e.Message);
            }

            try
            {
                int n1 = 10;
                int n2 = 20;
                String result = String.Format("{0 + {1] = {2}", n1, n2, (n1 + n2));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Exception: " + e.Message);
            }

            try
            {
                string[,,,,] arr = new string[303, 100, 34, 305, 3423];
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("Memory Exception: " + e.Message);
            }
        }
    }
}
