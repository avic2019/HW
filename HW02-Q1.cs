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

            Console.WriteLine("Enter 2 number: (a/b)");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());


            if (a%b==0)
            {
                Console.WriteLine("without carry");
            }
            else
            {
                Console.WriteLine("with carry");
            }
        
        }
	}
}