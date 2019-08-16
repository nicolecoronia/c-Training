using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> grocery = new List<string>();

            //int command=10;
            int max = 0;
            int number;
            String item = "";
            while (max < 11)
            {

                Console.WriteLine("Enter Command: (+) to add item (-) to remove item (--) to clear item");
                String command = Convert.ToString(Console.ReadLine());
                if (command == "+")
                {
                    Console.WriteLine("Item to Add: ");
                    item = Convert.ToString(Console.ReadLine());
                    grocery.Add(item);
                    Console.WriteLine(String.Join(",", grocery));
                    number = grocery.Count;
                    Console.WriteLine($"Total Count of item/s: {number}");
                    max++;

                }
                else if (command == "-")
                {
                    Console.WriteLine(String.Join(",", grocery));
                    Console.WriteLine("Item to Remove: ");
                    item = Convert.ToString(Console.ReadLine());
                    grocery.Remove(item);
                    Console.WriteLine(String.Join(",", grocery));
                    number = grocery.Count;
                    Console.WriteLine($"Total Count of item/s: {number}");
                    max++;
                }
                else if (command == "--")
                {
                    Console.WriteLine(String.Join(",", grocery));
                    item = Convert.ToString(Console.ReadLine());
                    grocery.Clear();
                    Console.WriteLine(String.Join(",", grocery));
                    number = grocery.Count;
                    Console.WriteLine($"Total Count of item/s: {number}");
                    max++;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}
