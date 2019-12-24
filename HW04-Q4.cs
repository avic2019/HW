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
            int i = 2;
            for (int j = 2; j < 100; j++)
            {
                i = 2;
                while ((j % i != 0) && i < j)
                {
                    i++;
                }
                if (i == j)
                {
                    Console.Write($" {j}");
                }

            }
        }
	}
}