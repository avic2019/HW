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
            int matbea_200 = 0;
            int matbea_100 = 0;
            int matbea_50 = 0;
            int matbea_20 = 0;
            int matbea_10 = 0;
            int matbea_5 = 0;

            Console.WriteLine("Enter number between to take home (number div 5)") ;
            num = Convert.ToInt16(Console.ReadLine());

            matbea_200 = num / 200;
            num = num % 200;

            matbea_100 = num / 100;
            num = num % 100;

            matbea_50 = num / 50;
            num = num % 50;

            matbea_20 = num / 20;
            num = num % 20;

            matbea_10 = num / 10;
            num = num % 10;

            matbea_5 = num / 5;
            num = num % 5;

            if (matbea_200!=0)
            {
                Console.WriteLine($"200: {matbea_200}");
            }
            if (matbea_100 != 0)
            {
                Console.WriteLine($"100: {matbea_100}");
            }
            if (matbea_50 != 0)
            {
                Console.WriteLine($" 50: {matbea_50}");
            }
            if (matbea_20 != 0)
            {
                Console.WriteLine($" 20: {matbea_20}");
            }
            if (matbea_10 != 0)
            {
                Console.WriteLine($" 10: {matbea_10}");
            }
            if (matbea_5 != 0)
            {
                Console.WriteLine($"  5: {matbea_5}");
            }	
        }
	}
}