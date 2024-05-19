using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework.Ex2
{
    public class Employee : Person
    {
        public int salary;
        public Employee(string name, string address, int salary) : base(name, address)
        {
            this.salary = salary;
        }

        public override void display()
        {
            Console.WriteLine("The employee " + name + "\n address " + address + "\n salary " + salary);
        }
    }
}
