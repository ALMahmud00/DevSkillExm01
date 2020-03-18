using System;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            Console.WriteLine("Please enter year: ");
            while (true)
            {
                year = Convert.ToInt32(Console.ReadLine());
                if (year >= 1971 && year <= 2019)
                {
                    break;
                }
                else {Console.WriteLine("Sorry, you provide an invalid year. Try again!"); }
            }

            Console.WriteLine("Please enter month: ");
            while (true)
            {
                month = Convert.ToInt32(Console.ReadLine());
                if (month >= 1  && month <= 12)
                {
                    break;
                }
                else { Console.WriteLine("Sorry, you provide an invalid month. Try again!"); }
            }

            Console.WriteLine("Please enter day: ");
            while (true)
            {
                day = Convert.ToInt32(Console.ReadLine());
                if (month == 2)
                {
                    if (day >= 1 && day <= 28)
                    {
                        break;
                    }
                    else { Console.WriteLine("Sorry, you provide an invalid day. Try again!"); }
                }
                else if (month==4 || month==6 || month==9 || month==11) 
                {
                    if (day>=1 && day <=30)
                    {
                        break;
                    }
                    else { Console.WriteLine("Sorry, you provide an invalid day. Try again!"); }
                }
                else
                {
                    if (day >= 1 && day <= 31)
                    {
                        break;
                    }
                    else { Console.WriteLine("Sorry, you provide an invalid day. Try again!"); }
                }

            }

            switch (month)
            {
                case 1:
                    Console.WriteLine("Your Date is: " + day + "-Jan-" + year);
                    break;
                case 2:
                    Console.WriteLine("Your Date is: " + day + "-Feb-" + year);
                    break;
                case 3:
                    Console.WriteLine("Your Date is: " + day + "-Mar-" + year);
                    break;
                case 4:
                    Console.WriteLine("Your Date is: " + day + "-Apr-" + year);
                    break;
                case 5:
                    Console.WriteLine("Your Date is: " + day + "-May-" + year);
                    break;
                case 6:
                    Console.WriteLine("Your Date is: " + day + "-Jun-" + year);
                    break;
                case 7:
                    Console.WriteLine("Your Date is: " + day + "-Jul-" + year);
                    break;
                case 8:
                    Console.WriteLine("Your Date is: " + day + "-Aug-" + year);
                    break;
                case 9:
                    Console.WriteLine("Your Date is: " + day + "-Sep-" + year);
                    break;
                case 10:
                    Console.WriteLine("Your Date is: " + day + "-Oct-" + year);
                    break;
                case 11:
                    Console.WriteLine("Your Date is: " + day + "-Nov-" + year);
                    break;
                case 12:
                    Console.WriteLine("Your Date is: " + day + "-Dec-" + year);
                    break;
            }





        }
    }
}
