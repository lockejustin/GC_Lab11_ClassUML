using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab11_ClassUML_notGraded
{
    class Staff : Person
    {
        //fields/properties
        private string School { get; set; }
        private double Pay { get; set; }

        //constructors
        public Staff() { }

        public Staff(string Name, string Address, string School, double Pay):base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        //methods
        public override void ToString()
        {
            Console.WriteLine($"Name: {name}\nAddress: {address}\nSchool: {School}\nPay: {Pay}");
        }
    }
}
