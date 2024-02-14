using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Score { get; set; }

        public void Display()
        {
            Console.WriteLine($"Id:{Id} Name:{Name} Age:{Age} Score:{Score}");
        }
    }
}
