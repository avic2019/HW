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
            int students = 0;
            int kita_100 = 0;
            int kita_30 = 0;
            int kita_10 = 0;

            Console.WriteLine("Enter number of Students");
            students = Convert.ToInt16(Console.ReadLine());

            kita_100 = students / 100;
            students = students % 100;

            kita_30 = students / 30;
            students = students % 30;

            kita_10 = students / 10;
            students = students % 10;

            if (kita_100 !=0)
            {
                Console.Write($"kita 100: {kita_100} ");
            }
            if (kita_30 != 0)
            {
                Console.Write($"kita 30: {kita_30} ");

            }
            if (kita_10 != 0)
            {
                Console.Write($"kita 10: {kita_10} ");
            }
            if (students !=0 )
            {
                Console.Write($"Students Go Home : {students}");
            }

            Console.Write(".");
            Console.WriteLine();
        }
	}
}