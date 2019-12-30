using System;

namespace laba3._7
{
    class Program
    {
        private static int[] memF = new int[100];
        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fib(N));
        }

        private static int Fib(int n)
        {
            if (n <= 1) return n;

            if (memF[n] != 0) return memF[n];

            memF[n] = Fib(n - 2) + Fib(n - 1);
            return memF[n];
        }
    }
}
