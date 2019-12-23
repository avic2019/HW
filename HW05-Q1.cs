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

            while (isPrim == 0)
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
                    isPrim = 1;
                    Console.WriteLine("!! Wow Prime Number !!");
                }
            }
			
        }
	}
}