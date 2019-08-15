using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDiffrence
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime times = DateTime.Now;
            /// String time = times.ToString("H:mm:ss");

            // Console.ReadKey(true);
            TimeSpan now = DateTime.Now.TimeOfDay;
            TimeSpan morning = new TimeSpan(1, 0, 0);
            TimeSpan afternoon = new TimeSpan(12, 0, 0);
            TimeSpan evening = new TimeSpan(18, 0, 0);
            TimeSpan night = new TimeSpan(20, 0, 0);

            Console.WriteLine(now);

            if ((now >= morning) && (now < afternoon))
            {
                Console.WriteLine("GoodMorning");
            }

            else if ((now >= afternoon) && (now < evening))
            {
                Console.WriteLine("Good Afternoon");
            }

            else if ((now >= evening) && (now < night))
            {
                Console.WriteLine("Good Evening");
            }

            else if ((now >= night) && (now < morning))
            {
                Console.WriteLine("Good Night");
            }
            else { }
            Console.ReadKey(true);

        }
    }
    }

