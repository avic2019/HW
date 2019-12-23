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
            int secret = 0;
            int guess = 0;
            Console.WriteLine("Bingo Game:\n Enter Secret Number");
            secret = Convert.ToInt16(Console.ReadLine());


            do
            {
                Console.WriteLine("Enter guess Number");
                guess = Convert.ToInt16(Console.ReadLine());

                if (secret>guess)
                {
                    Console.WriteLine("too small");
                }
                else if (secret < guess)
                {
                    Console.WriteLine("too big");
                }
            } while (secret != guess);

            Console.WriteLine("Bingo");
			
        }
	}
}