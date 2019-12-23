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
            Console.WriteLine("Enter number:");
            a = Convert.ToInt16(Console.ReadLine());

            if (a>=1000)
            {
                Console.WriteLine("Bigger then 3 numbers");
            }
            else if (a>99 && a<1000)
            {
                Console.WriteLine("3");
            }
            else if (a > 9 && a < 100)
            {
                Console.WriteLine("2");
            }
            else if (a >= 0 && a < 99)
            {
                Console.WriteLine("1");
            }
        
        }
	}
}