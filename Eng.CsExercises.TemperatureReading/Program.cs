
using System;

namespace Eng.CsExercises.TemperatureReading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to temperature reading...");
            Console.WriteLine("enter a reading.");

            var input = Console.ReadLine();

            if (!int.TryParse(input,out int temp))
            {
                Console.WriteLine("Sorry, only integers are accepted");
                Console.ReadLine();
                return;
            }
         
         
         if (temp < 0)
            {
                Console.WriteLine("Freezing weather");

            } else if (temp>=10 && temp < 20)
            {
                Console.WriteLine("Cold weather");

            } else if (temp>20 && temp < 30)
            {
                Console.WriteLine("Normal in Temp");

            } else if (temp>=30 && temp < 40)
            {
               Console.WriteLine("Its Hot");

            } else if (temp >= 40)
            {
                Console.WriteLine("Its Very Hot");
                
            }
            else if (temp>=0 && temp < 10)
            {
                Console.WriteLine("Very Cold weather");

            }
            else
            {
                Console.WriteLine(".....");
                Console.ReadLine();
            }
        }
    }
}
