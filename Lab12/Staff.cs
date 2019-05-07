using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School
        { 
            set { school = value; }
            get { return school; }
        }


        public double Pay
        {
            set { pay = value; }
            get { return pay; }
        }

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return $"Staff[Person[name={Name}, address={Address}],school={School},pay={Pay}";
        }

        public override bool Equals(Object obj)
        {
            Staff newObj = (Staff)obj;

            if(this.Name == newObj.Name)
            {
                return true;
            }
            return false;
        }
    }
}
