using System;

namespace laba3._4_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_1 = 3;
            Console.WriteLine("Матрица №1:");
            int[,] array_1 = new int[n_1, n_1];
            Random random_1 = new Random();
            for (int i = 0; i < array_1.GetLength(0); i++)
            {
                for (int j = 0; j < array_1.GetLength(1); j++)
                {
                    array_1[i, j] = random_1.Next(10);
                    Console.Write("{0} ",array_1[i, j]);
                }
                Console.WriteLine();
            }
            int n_2 = 3;
            Console.WriteLine("\nМатрица №2:");
            int[,] array_2 = new int[n_2, n_2];
            Random random_2 = new Random();
            for (int i = 0; i < array_2.GetLength(0); i++)
            {
                for (int j = 0; j < array_2.GetLength(1); j++)
                {
                    array_2[i, j] = random_2.Next(10);
                    Console.Write("{0} ",array_2[i, j]);
                }
                Console.WriteLine();
            }
            Addition(array_1, array_2, 0);
            Subtraction(array_1, array_2, 0);
        }
        public static void Addition(int[,] array_1, int[,] array_2, int n)
        {
            Console.WriteLine("\n\nМатрица A + B:");
            int[,] plus = new int[3, 3];
            int x = 0;
            for (int i = 0; i < array_1.GetLength(0); i++)
            {
                for (int j = 0; j < array_1.GetLength(1); j++)
                {
                    plus[i, j] = array_1[i, j] + array_2[i, j];
                    x += plus[i, j];
                    Console.Write("{0} ",plus[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Среднее значение: " + x / 9);
        }
        public static void Subtraction(int[,] array_1, int[,] array_2, int n)
        {
            Console.WriteLine("\n\nМатрица A - B:");
            int[,] minus = new int[3, 3];
            int y = 0;
            for (int i = 0; i < minus.GetLength(0); i++)
            {
                for (int j = 0; j < minus.GetLength(1); j++)
                {
                    minus[i, j] = array_1[i, j] - array_2[i, j];
                    y += minus[i, j];
                    Console.Write("{0,-2} ",minus[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Среднее значение: " + y / 9);
        }
    }
}
