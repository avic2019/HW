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
            int azeret = 1;
            Console.WriteLine("Calculate the AZERET of the number you enter");
            num = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                azeret *= i;
            }
            Console.WriteLine($"azeret: {azeret}");
			
        }
	}
}