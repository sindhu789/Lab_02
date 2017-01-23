using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_SoftwareArch_Console
{
    class Program
    {

        // echos the user's name and prints a randomly chosen int:
        static void Main(string[] args)
        {

            Console.Write("Guess an int, M, in range 0..10:  M = ");
            string m = Console.ReadLine();
            int M = Int32.Parse(m);

            //verify M is in range
            if (M > 0 && M < 10)
            {
                // how to generate random numbers:
                Random r = new Random();
                int min = 0;
                int max = 10 - M;
                int N = r.Next(min, max + 1);
                Console.WriteLine("I guess int, N, in range 0..10-M: N = {0}", N);

                Console.WriteLine("now you type an int, P, such that M + N + P = 10:  P =");
                string p = Console.ReadLine();
                int P = Int32.Parse(p);

                //check whether m+n+p =10 or not
                if (M + N + P == 10)
                    Console.WriteLine("You win!");
                else
                    Console.WriteLine("You Lose!");
            }
            else
                Console.WriteLine("Number M entered is not in range");

            // retain command window till user presses Enter
            Console.ReadLine();
        }
    }
}
