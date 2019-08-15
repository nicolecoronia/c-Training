using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 29;
            int num2 = 32;
            int num3 = 48;
            int sum = list(num1, num2,num3);
            Console.WriteLine($"The sum of numbers: {sum}");

            Console.ReadKey(true);
             

        }
        public static int list(int num1, int num2, int num3)
        {
            
            return num1+num2+num3;
        }

    }
}
