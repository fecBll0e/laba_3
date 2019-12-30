using System;

namespace laba3._5
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
                    Console.WriteLine("Введите размерность массива NxN :");
                    Console.Write("N: ");
                    int l = Convert.ToInt32(Console.ReadLine());
                    int k = 0;
                    int[,] mas = new int[l, l];
                    int[,] mas2 = new int[l, l];
                    int[,] mas3 = new int[l, l];

                    Random rand = new Random();

                    Console.WriteLine("Первый массив \n");

                    for (int i = 0; i < mas.GetLength(0); i++)
                    {
                        for (int j = 0; j < mas.GetLength(1); j++)
                        {
                            mas[i, j] = rand.Next(10);
                            Console.Write("{0} ", mas[i, j]);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\nВторой массив \n");

                    for (int i = 0; i < mas2.GetLength(0); i++)
                    {
                        for (int j = 0; j < mas2.GetLength(1); j++)
                        {
                            mas2[i, j] = rand.Next(10);
                            Console.Write("{0} ", mas2[i, j]);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\nПроизведение массивов \n");

                    for (int i = 0; i < mas3.GetLength(0); i++)
                    {
                        for (int j = 0; j < mas3.GetLength(1); j++)
                        {
                            for (int n = 0; n < l; n++)
                                mas3[i, j] += mas[i, n] * mas2[n, j];


                            if (k < (l - 1))
                            {
                                k++;
                                if (mas3[i, j] < 10)
                                {
                                    Console.Write("{0}   ", mas3[i, j]);
                                }
                                if (mas3[i, j] > 10 && mas3[i, j] < 100)
                                {
                                    Console.Write("{0}  ", mas3[i, j]);
                                }
                                else
                                {
                                    Console.Write("{0} ", mas3[i, j]);
                                }

                            }


                            else

                            {
                                if (mas3[i, j] < 10)
                                {
                                    Console.WriteLine("{0}   ", mas3[i, j]);
                                }
                                if (mas3[i, j] > 10 && mas3[i, j] < 100)
                                {
                                    Console.WriteLine("{0}  ", mas3[i, j]);
                                }
                                else
                                {
                                    Console.WriteLine("{0} ", mas3[i, j]);
                                }
                                k = 0;
                            }

                        }

                    }

                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    error = 0;
                    Console.WriteLine("Введите корректные данные.\n");
                }
                //    Console.WriteLine("Введите размерность первой матрицы: ");
                //    int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
                //    for (int i = 0; i < A.GetLength(0); i++)
                //    {
                //        for (int j = 0; j < A.GetLength(1); j++)
                //        {
                //            Console.Write("A[{0},{1}] = ", i, j);
                //            A[i, j] = Convert.ToInt32(Console.ReadLine());
                //        }
                //    }
                //    Console.WriteLine("Введите размерность второй матрицы: ");
                //    int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
                //    for (int i = 0; i < B.GetLength(0); i++)
                //    {
                //        for (int j = 0; j < B.GetLength(1); j++)
                //        {
                //            Console.Write("B[{0},{1}] = ", i, j);
                //            B[i, j] = Convert.ToInt32(Console.ReadLine());
                //        }
                //    }

                //    Console.WriteLine("\nМатрица A:");
                //    Print(A);
                //    Console.WriteLine("\nМатрица B:");
                //    Print(B);
                //    Console.WriteLine("\nМатрица C = A * B:");
                //    int[,] C = Multiplication(A, B);
                //    Print(C);

                //}
                //static int[,] Multiplication(int[,] a, int[,] b)
                //{
                //    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
                //    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
                //    for (int i = 0; i < a.GetLength(0); i++)
                //    {
                //        for (int j = 0; j < b.GetLength(1); j++)
                //        {
                //            for (int k = 0; k < b.GetLength(0); k++)
                //            {
                //                r[i, j] += a[i, k] * b[k, j];
                //            }
                //        }
                //    }
                //    return r;
                //}
                //static void Print(int[,] a)
                //{
                //    for (int i = 0; i < a.GetLength(0); i++)
                //    {
                //        for (int j = 0; j < a.GetLength(1); j++)
                //        {
                //            Console.Write("{0} ", a[i, j]);
                //        }
                //        Console.WriteLine();
                //    }
            }
        }
    }
}
