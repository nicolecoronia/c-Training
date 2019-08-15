using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {

           String name = "Monica";
            String greeting = "Good Day";

            String greet1 = $"Hello {name}, {greeting}";
            String greet2 = "Hello " + name + ", " + greeting;
            String greet3 = String.Format("Hello {0}, {1}",name, greeting);
            String temp = "Hello **NAME**, **GREET**";
            String greet4 = temp.Replace("**NAME**" ,name).Replace("**GREET**" ,greeting ) ;
            

            Console.WriteLine(greet1);
            Console.WriteLine(greet2);
            Console.WriteLine(greet3);
            Console.WriteLine(greet4);
            Console.ReadKey(true);

        }
    }
}
