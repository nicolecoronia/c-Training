

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
           //* DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
           // TimeSpan duration = nextYear - DateTime.Today;
            //Console.WriteLine($"There are {duration.TotalDays} days left in the year");
            //Console.ReadKey(true);


            DateTime birthdate= new DateTime(1999, 1, 12);
            DateTime today = new DateTime(DateTime.Today.Year);
            TimeSpan durationn =  DateTime.Today - birthdate;
            Console.WriteLine(birthdate);
            Console.WriteLine(today);
            Console.WriteLine(durationn.TotalDays+"days "); //total of days from birthdate 
            

            DateTime next27 = new DateTime(DateTime.Today.Year + 27,1,1);
            Console.WriteLine(next27);//next 27 days in today's year
            TimeSpan anniv = next27 - birthdate;
            Console.WriteLine(anniv.TotalDays+"total number of days after 27 years"); //total number of days after 27 years


            int days = Convert.ToInt32(durationn.TotalDays);
            int daysToNextAnniversary = 10000 - (days % 10000);
            Console.WriteLine(daysToNextAnniversary);
            Console.ReadKey(true);


        }
    }
}
