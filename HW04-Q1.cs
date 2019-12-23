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
            Console.WriteLine("print numbers between 1 to 2000");
            for (int i = 1; i <= 2000; i++)
            {
                Console.Write($"{i} ");
            }
           
            Console.WriteLine("print Even numbers between 1 to 100");
            for (int i = 2; i <= 100; i+=2)
            {
                Console.Write($"{i} ");
            }
           
            Console.WriteLine("print numbers %10==0 (without use %) between 1 to 100");
            for (int i = 10; i <= 100; i += 10)
            {
                Console.Write($"{i} ");
            }
            
			
        }
	}
}