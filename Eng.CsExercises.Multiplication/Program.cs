
using System;

namespace Eng.CsExcercise.Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, multiplier;
            Console.WriteLine("Display the Multiplication Table");
            Console.Write("Input the number (Table to be calculated): ");
            number= Convert.ToInt32(Console.ReadLine());

            for ( multiplier = 1; multiplier <= 10; multiplier++ )
            {       
                Console.Write("{0} X {1} = {2}\n",number,multiplier,(number * multiplier));
                              
           
            }
        }
    }
}

