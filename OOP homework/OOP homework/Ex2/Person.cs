using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework.Ex2
{
    public abstract class Person
    {
        public string name;
        public string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public void setName(string name) { this.name = name;}
        public void setAddress(string address) {  this.address = address;}
        public string getName() { return this.name;}
        public string getAddress() { return this.address;}

        public abstract void display();
    }
}
