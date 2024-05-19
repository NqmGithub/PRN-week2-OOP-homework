using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework2
{
    public class Customer : Person
    {
        public int balance;
        public Customer(string name, string address, int balance) : base(name, address)
        {
            this.balance = balance;
        }

        public override void display()
        {
            Console.WriteLine("The customer " + name + "\n address " + address + "\n balance " + balance);
        }
    }
}
