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
            Console.WriteLine("Enter numbers to sum.\nEnter Negativ number to stop input and print the sum\n");
            int inputNumber = 0;
            int sum = 0;

            while (inputNumber>=0)
            {
                sum += inputNumber;
                Console.WriteLine("Enter number");
                inputNumber = Convert.ToInt16(Console.ReadLine());
                
            }
            Console.WriteLine($"sum is: {sum}");
			
        }
	}
}