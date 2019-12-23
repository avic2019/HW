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
            int sum = 0;
            Console.WriteLine("Enter 2 numbers, I will print the sum and avg ");

            Console.WriteLine("enter 1st number");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter 2st number");
            b = Convert.ToInt16(Console.ReadLine());

            sum = a + b;
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"avg: {sum/2f}");
			
        }
	}
}