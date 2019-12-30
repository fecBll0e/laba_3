using System;

namespace laba3indiv2
{
    class Program
    {
        static void Main(string[] args)
        {
            int error = 0;
            while (error == 0)
            {
                try
                {
                    error = 1;
                    Console.WriteLine("Введите одномерный массив:");
                    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
                    bool t = true;
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        if (arr[i] > arr[i + 1])
                            t = false; break;
                    }
                    Console.WriteLine(t);
                }

                catch (FormatException)
                {
                    error = 0;
                    Console.WriteLine("Введите корректные данные.\n");
                }
            }
        }
    }
}
