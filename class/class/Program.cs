using System;

namespace classes
{
    class Program
{
    static void Main(string[] args)
    {
            String choice = "";
            do
            {
                Console.Write("Do you want to add person? (yes/no):");
                 choice = Convert.ToString(Console.ReadLine());
                switch (choice)
                {
                    case "yes":
                        name n = new name();
                        company c = new company();
                        Address a = new Address();

                        Console.Write("Name: ");
                        n.Name = Convert.ToString(Console.ReadLine());
                        Console.Write("Company: ");
                        c.Company = Convert.ToString(Console.ReadLine());
                        Console.Write("Address: ");
                        a.address = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("------Information------");
                        Console.Write("Name: " + n.Name + "\n");
                        Console.Write("Company: " + c.Company + "\n");
                        Console.Write("Address: " + a.address + "\n");
                        break;
                    case "no":
                        Environment.GetCommandLineArgs();
                        break;
                    default: break;
                }
            } while (choice == "yes");

            Console.ReadKey(true);
    }


        }
         
        class name
        {
            private String person_name;
            public String Name
            {
                get { return person_name; }
                set { person_name = value; }
            }
        }
        class company
        {
            private String person_company;
            public String Company
            {
                get { return person_company; }
                set { person_company = value; }
            }
        }
        class Address
        {
            private String person_address;
            public String address
                
            {
                get { return person_address; }
                set { person_address = value; }
            }
        }

    }


