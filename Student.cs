using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab11_ClassUML_notGraded
{
    class Student : Person
    {
        //properties/fields
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        //constructors
        public Student() { }

        public Student(string Name, string Address, string Program, int Year, double Fee) : base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        //methods
        public override void ToString()
        {
            Console.WriteLine($"Name: {name}\nAddress: {address}\nProgram: {Program}\nYear: {Year}\nFee: {Fee}");
        }
    }
}
