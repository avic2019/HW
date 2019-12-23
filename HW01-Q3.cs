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

            Console.WriteLine("Enter Lucky number:");
            a = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter number:");
                b = Convert.ToInt16(Console.ReadLine());

                if (a==b)
                {
                    Console.WriteLine("bingo");
                    break;
                }
               else if (a > b)
                {
                    Console.WriteLine("Smaller");
                }
                else if (a < b)
                {
                    Console.WriteLine("Bigger");
                }
                if (i==2)
                {
                    Console.WriteLine("Thanks for your time");
                }
            }
        
        }
	}
}