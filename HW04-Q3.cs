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
            int ahadot = 0;
            int asarot = 0;

            Console.WriteLine("Enter number between 10-99");
            num = Convert.ToInt16(Console.ReadLine());

            if (num>9 && num<100)
            {
                ahadot = num % 10;        
                Console.WriteLine($"ahadot:{ahadot}");
                asarot = num / 10;
                Console.WriteLine($"asarot:{asarot}");

                if (ahadot> asarot)
                {
                    Console.WriteLine("AHADOT");
                }
                else
                {
                    Console.WriteLine("ASAROT");
                }
            }		
        }
	}
}