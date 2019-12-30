using System;

namespace laba3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];

            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = rand.Next(-10, 10);
                }
            }

            Console.WriteLine("\nМассив:");
            ShowArray(array, N);

            int det = Determinant(array, N);
            Console.WriteLine("\nОпределитель = {0}", det);
            Console.ReadKey();
        }

        static int Determinant(int[,] array, int N)
        {
            int det = 0;
            int num = N;

            if (N == 2)
            {
                det = (array[0, 0] * array[1, 1]) - (array[1, 0] * array[0, 1]);
                return det;
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (i + j % 2 == 0)
                        {
                            det += array[i, j] * Minor(array, i, j, N, out N);
                        }
                        else
                        {
                            det -= array[i, j] * Minor(array, i, j, N, out N);
                        }
                        N = num;
                    }
                }
            }

            return det;
        }

        static int Minor(int[,] array, int n, int m, int N, out int num)
        {
            num = N - 1;
            int[,] arr_minor = new int[num, num];

            for (int i = 0, q = 0; q < num; i++, q++)
            {
                for (int j = 0, p = 0; p < num; j++, p++)
                {
                    if (i == n) i++;
                    if (j == m) j++;
                    arr_minor[q, p] = array[i, j];
                }
            }
            return Determinant(arr_minor, num);
        }

        static void ShowArray(int[,] array, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
