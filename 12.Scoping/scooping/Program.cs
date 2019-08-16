using System;

namespace scoping
{
    class Program
    {
        static void Main(string[] args)
        {
            var jimmy = new Student("Jimmy", "Jones", new DateTime(1990, 3, 15), "Advance Programming");
           // Console.WriteLine(jimmy.RosterName);
            var rianne = new course("Rianne", "Smith", new DateTime(1999, 1, 12), "SQL");
           // Console.WriteLine(rianne.newStud);
            Console.WriteLine("List of courses: [1]Advance Programming [2]SQL [3]Web Programming");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine(jimmy.RosterName);
            }
            else if (choice == 2)
            {
                Console.WriteLine(rianne.newStud);
            }
            else
            {
                Console.WriteLine("no one enrolled");
            }
        }
    }

    public class Person
    {
        public Person(string firstName, string lastName, DateTime dateOfBirth, string course)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.course = course;
        }

        protected string FirstName { get; private set; }
        protected string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
       protected string course { get; private set; }

        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

        public bool IsAnAdult()
        {
            var eighteenYearsAgo = DateTime.Today.AddYears(-18);
            return this.DateOfBirth < eighteenYearsAgo;
        }
    }

    public class Student : Person
    {
        public Student(string firstName, string lastName, DateTime dateOfBirth, string course)
            : base(firstName, lastName, dateOfBirth, course)
        { }
        public string SchoolName { get; set; }
        //public string course { get; set; }

        public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }
    };

    public class course : Student
    {
        public course(string firstName, string lastName, DateTime dateOfBirth, string course) 
            : base(firstName, lastName, dateOfBirth, course) { }//, course) { }
        public string courses { get; set; }

        public string newStud { get { return $"{this.LastName},{this.FirstName},{this.course}"; } } }

   
}
    



    

