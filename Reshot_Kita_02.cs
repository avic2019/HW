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
            int ok = 0;

            do
            {
                Console.WriteLine("Enter Temperature ");
                num = Convert.ToInt16(Console.ReadLine());
                switch (num)
                {
                    case -5:
                        Console.WriteLine("freezing");
                        ok = 1;
                        break;
                    case 0:
                        Console.WriteLine("cold");
                        ok = 1;
                        break;
                    case 15:
                        Console.WriteLine("nice");
                        ok = 1;
                        break;
                    case 40:
                        Console.WriteLine("very hot");
                        ok = 1;
                        break;

                    default:
                        ok = 0;
                        break;
                }

            } while (ok==0);
			
        }
	}
}