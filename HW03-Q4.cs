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
            int inputNumber = 0;
            int i = 2;

            Console.WriteLine("Enter a number to check if is a Prime Number");

            inputNumber = Convert.ToInt16(Console.ReadLine());

            while ((inputNumber % i !=0) && i<=inputNumber )
            {
                i++;
            }
            if (i==inputNumber)
            {
                Console.WriteLine("\nWoW Prime number!");
            }
            else
            {
                Console.WriteLine("Not Prime number!");
            }
			
        }
	}
}