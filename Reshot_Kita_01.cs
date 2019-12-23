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
            int i = 0;
            int num = 0;
            int maxNum = 0;
            Console.WriteLine("Enter number between 1-1000 , after 3 inputs - will print the max number");
            while (i<3)
            {
                num = Convert.ToInt16(Console.ReadLine());
                if (num>=1 && num <=1000)
                {
                    i++;
                    if (num>maxNum)
                    {
                        maxNum = num;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(maxNum);
			
        }
	}
}