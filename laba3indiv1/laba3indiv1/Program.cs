using System;

namespace laba3indiv1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int m = 9;
            //int n = 9;

            //int[,] matr = new int[m, n];

            //Random ran = new Random();

            //for (int i = 0; i < m; i++)
            //    for (int j = 0; j < n; j++)
            //        matr[i, j] = ran.Next(9);

            //for (int i = 0; i < m; i++)                         //Выводит элементы справа от главной диагонали
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write(matr[i, j] + " ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //for (int j = 0; j < n; j++)                         //Выводит элементы слева от главной диагонали
            //{
            //    for (int i = m - 1; i >= 0; i--)

            //        Console.Write(matr[i, j] + " ");
            //    Console.WriteLine();
            //}


            //Console.ReadLine();





            //Random rand = new Random();
            //int[,] matrix = new int[9, 9];

            //for (int i = 0; i < 9; i++) // эти циклы для заполнения массива
            //    for (int j = 0; j < 9; j++)
            //        matrix[i, j] = rand.Next(10, 100); //заполняем массив числами от 10 до 99 (100 не включается)


            //for (int i = 0; i < 9; i++) // цикл для вывода матрицы
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        if (i - j <= 0 && j + i < 9 && i < 5) // условие, чтобы откинуть элемент, попадающий в верхний треугольник
            //            Console.Write("   ");
            //        else if (j + i > 7 && j <= i && i >= 5) // условие, чтобы откинуть элемент, попадающий в нижний треугольник
            //            Console.Write("   ");
            //        else
            //            Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();



            int aa1 = 0;
            while (aa1 == 0)
            {
                try
                {
                    aa1 = 1;
                    Console.WriteLine("Введите размерность матрицы");
                    int a = int.Parse(Console.ReadLine());//Размерность матрицы . 
                    int k = 0;//Счётчик,который увеличивается при заполнении массива. 
                    int[,] mas = new int[a, a]; //Двумерный массив. 
                    for (int i = 0; i < a; i++)//Цикл, бегущий по строкам. 
                    {
                        for (int j = 0; j < a; j++)//Цикл, бегущий по столбцам. 
                        {
                            if (i == j || i + j  == 8) mas[i, j] = k;//Заполнятся будут те элементы,номера строк и столбцов которых равны(Диагональ). 
                            Console.Write(mas[i, j] + " ");//Вывод вдоль строки. 
                        }
                        k++;//Увеличение переменной на 1. 
                        Console.WriteLine();//Переход на новую строку после заполнения предыдущей. 
                    }
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат ввода!");
                    aa1 = 0;
                }
            }
        }
    }
}
    