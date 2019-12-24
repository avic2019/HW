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
            Console.WriteLine("Enter Godel Mesholash");
            num = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
               // Console.Write(i);
                for (int j = 1; j<=num ; j++)
                {
                    if (j<=i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
	}
}