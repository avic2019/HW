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

            Console.WriteLine("Did A / B without carry?");

            Console.WriteLine("enter 1st number");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter 2st number");
            b = Convert.ToInt16(Console.ReadLine());

            if (a%b==0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        
        }
	}
}