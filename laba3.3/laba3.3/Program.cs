using System;

namespace laba3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int error = 0;
            while (error == 0)
            {
                try                                     //Обработчик исключений
                {
                    error = 1;
                    Console.WriteLine("Введите кол-во элементов массива");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите k:");
                    int k = Convert.ToInt32(Console.ReadLine());
                    int[] mas = new int[n];
                    


                    Random rand = new Random();

                    Console.WriteLine("\nНачальный массив\n");

                    for (int i = 0; i < n; i++)
                    {
                        mas[i] = rand.Next(10);
                        Console.Write("{0} ", mas[i]);
                    }

                    Console.WriteLine("\nСдвиг массива\n");

                    for (int i = k; i < n; i++)
                        Console.Write("{0} ", mas[i]);

                    for (int i = 0; i < k; i++)
                        Console.Write("{0} ", mas[i]);

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

