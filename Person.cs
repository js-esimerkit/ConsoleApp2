using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        private string fname;
        public void setFname(string value)
        {
            fname = value;
        }
        public string getFname()
        {
            return fname;
        }
        public void showPerson()
        {
            Console.WriteLine("Hei olen " + fname);
        }
    }
}
