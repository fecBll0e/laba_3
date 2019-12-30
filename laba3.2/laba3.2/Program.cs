using System;

namespace laba3._2
{
    class Program
    {
        



            //int[,] mas = new int[7, 7];
            //Random rand = new Random();

            //for (int i = 0; i < mas.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas.GetLength(1); j++)
            //    {

            //        mas[i, j] = rand.Next(10);
            //        Console.Write("{0} ", mas[i, j]);

            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("\n*************\n");

            //for (int j = 0; j < mas.GetLength(1); j++)
            //{
            //    for (int i = mas.GetLength(0) - 1; i >= 0; i--)
            //    {
            //        /*Console.Write("{0} ", mas[i, j])*//*;*/
            //        mas[i, j] = mas[mas.Length - j, i];
            //    }
            //    Console.WriteLine();


            //}
            //for (int i = 0; i < mas.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas.GetLength(1); j++)
            //    {

            //        Console.Write("{0} ", mas[i, j]);

            //    }
            //    Console.WriteLine();
            //}
            //    Console.ReadKey();





            
            static void rotateMatrix(int N, int[,] mat)

        {
                
                for (int x = 0; x < N / 2; x++)
                {
                    
                    for (int y = x; y < N - x - 1; y++)
                    {
                        
                        int temp = mat[x, y];

                       
                        mat[x, y] = mat[y, N - 1 - x];

                        
                        mat[y, N - 1 - x] = mat[N - 1 - x, N - 1 - y];

                        
                        mat[N - 1 - x, N - 1 - y] = mat[N - 1 - y, x];

                        mat[N - 1 - y, x] = temp;
                    }
                }
            }

            static void displayMatrix(int N, int[,] mat)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                        Console.Write(" " + mat[i, j]);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            static public void Main()
            {
                int N = 7;

                int[,] mat =
                {
            {1, 2, 3, 4, 4, 4, 9},
            {5, 6, 7, 8, 2, 3, 4},
            {9, 10, 11, 12, 14, 15, 16},
            {13, 14, 15, 16, 7, 8, 2,},
            {13, 14, 15, 16, 7, 8, 2,},
            {13, 14, 15, 16, 7, 8, 2,},
            {13, 14, 15, 16, 7, 8, 2,}
        };

                rotateMatrix(N, mat);

                displayMatrix(N, mat);

            }
    }
}
