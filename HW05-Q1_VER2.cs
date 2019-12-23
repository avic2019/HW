using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int isPrim = 0;
            int i = 2;
            Console.WriteLine("Enter number to check if is a Prime Number");

            do
            {
                Console.WriteLine("Enter Number:");
                num = Convert.ToInt16(Console.ReadLine());

                i = 2;
                while (num % i != 0 && num > i)
                {
                    i++;
                }

                if (i == num)
                {
                    Console.WriteLine("!! Wow Prime Number !!");
                }
				else
				{
					Console.WriteLine("!! Opps is Not Prime Number !!");
				}
            } while (num % i == 0 && num > i);
			
        }
	}
}