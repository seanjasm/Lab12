using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff1 = new Staff("Sean Mattis", "", "", 9);
            Staff staff2 = new Staff("Tony Yeho", "", "", 9);
            Staff staff3 = new Staff("Mark Twain", "", "", 9);

            Console.WriteLine($"Is {staff1.Name} equal to {staff2.Name} : {staff1.Equals(staff2)}");
            Console.WriteLine($"Is {staff1.Name} equal to {staff1.Name} : {staff1.Equals(staff1)}");
        }
    }
}
