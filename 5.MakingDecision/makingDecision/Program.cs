using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Guess the number (1-3): ");
            num = int.Parse(Console.ReadLine());
            int correctNumber = new Random().Next(3) + 1;

            if (num >= 4)
            {
                Console.WriteLine("Your guessed number is out of range");
            }
            else if (correctNumber > num)
            {
                Console.WriteLine("Your guessed nunmber is lower than the correct number.");
            }
            else if (correctNumber < num)
            {
                Console.WriteLine("Your guessed number is higher than the correct number");

            }
            else if (correctNumber == num)
            {
                Console.WriteLine("Your guessed number is the correct number");

            }
            
            else
            {

            }
            Console.WriteLine("THe correct number is: "+correctNumber);
            Console.ReadKey(true);
           /* switch (num)
            {
                case 1:
                    Console.WriteLine("Your guessed number is low");
                    break;
                case 2:
                    Console.WriteLine("Your guessed number is low");
                    break;
                case 3:
                    Console.WriteLine("Your guessed number is Correct");
                    break;
                default:
                    Console.WriteLine("The number you guessed is out of range");
                    break;
            }
            
    */


        }
    }
}
