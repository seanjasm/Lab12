using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            set { program = value; }
            get { return program; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Fee
        {
            set { fee = value; }
            get { return fee; }
        }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            return $"Student[Person[name={Name}, address={Address}],program={Program},year={Year},fee={Fee}";
        }
    }
}
