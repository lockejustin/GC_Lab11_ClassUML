using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab11_ClassUML_notGraded
{
    class Person
    {
        //properties/fields
        //public string Name { get; set; }
        //public string Address { get; set; }

        //fields
        public string name;
        public string address;

        //properties
        private string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string Address
        {
            get { return address; }
            set { address = value; }
        }


        //Constructors
        public Person() { }  //default

        public Person (string Name, string Address)  //overloaded
        {
            this.Name = Name;
            this.Address = Address;
        }

        //Methods
        public virtual void ToString()
        {
            Console.WriteLine($"Name: {Name}\n Address: {Address}");
            
            //return $"Name: {Name}\n Address: {Address}";
        }
    }
}
