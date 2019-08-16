using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopingtech
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfList=5;
            List<int> number_integer = new List<int>();
            Console.Write("Enter numbers: ");
            for (int start=0; start<=numOfList; start++) { //detting 5 numbers to be added in the list
            int list_int = Convert.ToInt32(Console.ReadLine());
            number_integer.Add(list_int);
            }
            Console.Write("Numbers: ");// prints all the numbers
            Console.WriteLine(String.Join(",", number_integer));
            Console.Write("Sum:");//getting the sum of all the numbers
            Console.WriteLine(number_integer.Sum(x => Convert.ToInt32(x)));

            Console.ReadKey(true);



        }
    }
}
