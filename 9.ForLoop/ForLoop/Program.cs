using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int number=24;
   for(int one=0; one<=number; one++){
       Console.Write(one+",");

   }
   Console.WriteLine();
       for(int two=0; two<=number;two+=2){
           Console.Write( two+",");
       }
           Console.WriteLine();

       for(int three=0; three<=number;three+=3){
           Console.Write(three+",");
       }
           Console.WriteLine();

       for(int four=0; four<=number;four+=4){
           Console.Write( four+",");
       }*/
            
            int row = 5;
            int column = 24;

            for (int starting = 1; starting < row; starting++)
            {

             
                for (int end = 0; end <= column; end+=starting)
                {

                     // string product = (starting * end).ToString();
                    // Console.Write(end.PadLeft(3));
                    //Console.ReadKey(true);
                    Console.Write (end+", ");
                   
                    

                    


                }
                //column -=j;
                Console.WriteLine();
                //Console.ReadKey(true);
            }

            Console.ReadKey(true);
        }
    }
}
