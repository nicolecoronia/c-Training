using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int candidateFactor = 2;
            while (number != candidateFactor) // convert this to while
            {

                if (number % candidateFactor == 0) // found a factor
                {

                    Console.Write(candidateFactor);
                    break;
                    // divide number by the factor you found and assign this back to number
                    // print a comma if number is still greater than 1
                }
                if (number % candidateFactor == 1)
                {
                    Console.WriteLine("Try Again");
                    Console.Write("Enter a number:");
                     number = int.Parse(Console.ReadLine());

                    //
                    Console.ReadKey(true);


                }

                // don't forget to increment factor!
            }
           
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
