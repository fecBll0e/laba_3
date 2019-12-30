using System;

namespace laba3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
            Console.WriteLine("Числа массива: " + string.Join(" ", array));

            Console.WriteLine("sumIterative:");
            int sumIter = sumIterative(array);
            Console.WriteLine(sumIter);

            Console.WriteLine("minIterative:");
            int minIter = minIterative(array);
            Console.WriteLine(minIter);

            Console.WriteLine("sumRecursive:");
            int sumRec = sumRecursive(array, array.Length);
            Console.WriteLine(sumRec);

            Console.WriteLine("minRecursive:");
            int minRec = minRecursive(array, array.Length);
            Console.WriteLine(minRec);
        }
        static int sumIterative(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int sumRecursive(int[] array, int a)
        {
            if (a > 0)
            {
                return array[a - 1] + sumRecursive(array, a - 1);
            }
            else
            {
                return 0;
            }
        }
        static int minIterative(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int minRecursive(int[] array, int b)
        {
            if (b <= 0)
            {
                return Int32.MaxValue;
            }
            return Math.Min(array[b - 1], minRecursive(array, b - 1));
        }
    }
}
