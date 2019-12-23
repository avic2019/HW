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

            Console.WriteLine("Enter 2 numbers:");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());

            if (b==0)
            {
                Console.WriteLine("Error x/0 not allow");
            }
            else
            {
                Console.WriteLine($"div: { a / b}");
            }
        
        }
	}
}