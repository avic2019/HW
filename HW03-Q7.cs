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
            int a = 0;
            int b = 0;
            int kafol = 0;
            Console.WriteLine("Enter 2 numbers, will print the sum and avg ");

            Console.WriteLine("enter 1st number");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter 2st number");
            b = Convert.ToInt16(Console.ReadLine());


            for (int i = 1; i <= b; i++)
            {
                kafol += a;
            }
            Console.WriteLine($"kafola:{kafol}");
			
        }
	}
}