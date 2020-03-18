using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp, num = 0;
            Console.WriteLine("Please give a number: ");
            temp = Convert.ToInt32(Console.ReadLine());

            while (temp != 0)
            {
                num = num * 10;
                num = num + (temp % 10);
                temp = temp / 10;
            }

      

            int flag = 0;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 1 || num == 1)
            {
                Console.WriteLine("Result is: " + num + " (Not Prime)");
            }
            else if (flag == 0)
            {
                Console.WriteLine("Result is: " + num + " (Prime)");
            }



        }
    }
}
