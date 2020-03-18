using System;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, sum=0, i, j;
            Console.WriteLine("Enter The Dimension : ");
            N = Convert.ToInt32(Console.ReadLine());
            int[,] num = new int[N, N];
            Console.WriteLine("Enter The Values : ");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (i == j || (i + j) == (N - 1))
                        sum += num[i, j];
                }
            }

            Console.WriteLine("Sum = " + sum);


        }
    }
}
