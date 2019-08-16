using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            var people = GenerateListOfPeople();
           
            int maxtry = 0;
            do
            {
                Console.Write("Choose what you want to filter: [a]First Name [b]Last Name [c]Age [d]Occupation: ");
                char choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'a')
                {
                    Console.Write("Enter First name to Filter: ");
                    String fname = Convert.ToString(Console.ReadLine());
                    IEnumerable<Person> fisrtname = people.Where(individual => individual.FirstName == fname);
                    foreach (var Person in fisrtname)
                    {
                        Console.WriteLine(Person.FirstName + ", " + Person.LastName);
                    }
                    maxtry++;


                }
                else if (choice == 'b')
                {
                    Console.Write("Enter Last name to Filter: ");
                    String lname = Convert.ToString(Console.ReadLine());
                    IEnumerable<Person> lastname = people.Where(individual => individual.LastName == lname);
                    foreach (var Person in lastname)
                    {
                        Console.WriteLine(Person.FirstName + ", " + Person.LastName);
                    }

                    maxtry++;
                }
                else if (choice == 'c')
                {
                    Console.WriteLine("Enter Age to Filter: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    IEnumerable<Person> agefiltered = people.Where(individual => individual.Age > age);
                    foreach (var Person in agefiltered)
                    {
                        Console.Write(Person.FirstName+", "+Person.LastName);
                    }
                    maxtry++;
                }
                if (choice == 'd')
                {
                    Console.Write("Enter Occupation to Filter: ");
                    String occ = Convert.ToString(Console.ReadLine());
                    IEnumerable<Person> occupation = people.Where(individual => individual.Occupation == occ);
                    foreach (var Person in occupation)
                    {
                        Console.WriteLine(Person.FirstName + ", " + Person.LastName);
                    }
                    maxtry++;


                }

            } while (maxtry <4);
            // Person firstOrDefault = people.FirstOrDefault();
            //Console.WriteLine(firstOrDefault.FirstName);
        }

        public static List<Person> GenerateListOfPeople()
        {
            var people = new List<Person>();

            people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
            people.Add(new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Luis", LastName = "Reyes", Occupation = "Dev", Age = 22 });
            people.Add(new Person { FirstName = "Alex", LastName = "Smith", Occupation = "Manager", Age = 28 });
            people.Add(new Person { FirstName = "Cathy", LastName = "Lopez", Occupation = "HR", Age = 27 });
            people.Add(new Person { FirstName = "Luis", LastName = "Smith", Occupation = "Dev", Age = 22 });

            return people;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
    }
}
