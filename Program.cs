using System;
using System.Collections.Generic;

namespace GC_Lab11_ClassUML_notGraded
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> persons = new List<Person>
            {
                new Student("Dave", "555 Main St", "Accounting", 2021, 10000),
                new Student("Hilary", "783 1st Apt A", "Finance", 2022, 15000),
                new Student("Barry", "1115 East Apple", "Computer Science", 2021, 9500),
                new Staff("Hugh", "55 Lots O Money Blvd", "EMU", 150000),
                new Staff("Gary", "79 Tons O Cash Cir", "EMU", 175000)
            };

            while (true)
            {
                Console.WriteLine("What would you like to do?  Print  or Add?");
                string input = Console.ReadLine().ToLower();

                if (input == "print")
                {
                    foreach (var person in persons)
                    {
                        person.ToString();
                    }
                }
                else if (input == "add")
                {
                    persons = AddPerson(persons);
                }
            }
        }

        public static List<Person> AddPerson(List<Person> persons)
        {
            Console.WriteLine("Would you like to add a student or staff?");
            string input = Console.ReadLine();

            if (input == "student")
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
                Console.Write("Enter address: ");
                string address = Console.ReadLine();
                Console.Write("Enter program: ");
                string program = Console.ReadLine();
                Console.Write("Enter year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Enter fee: ");
                double fee = double.Parse(Console.ReadLine());

                persons.Add(new Student(name, address, program, year, fee));
            }
            else
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
                Console.Write("Enter address: ");
                string address = Console.ReadLine();
                Console.Write("Enter school: ");
                string school = Console.ReadLine();
                Console.Write("Enter pay: ");
                double pay = double.Parse(Console.ReadLine());

                persons.Add(new Staff(name, address, school, pay));
            }

            return persons;
        }
    }
}
