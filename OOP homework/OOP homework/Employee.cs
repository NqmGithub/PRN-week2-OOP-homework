using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public abstract class Employee:IEmployee
    {
        string name;
        int paymentPerHour;

        public Employee()
        { 
        }
        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public abstract int calculateSalary();

        public string getName()
        {
            return name;
        }

        public int getPaymentPerHour()
        {
            return paymentPerHour;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setPaymentPerHour(int paymentPerHour)
        {
            this.paymentPerHour = paymentPerHour;
        }

        public override string ToString()
        {
            return "Employee " + this.name + "has payment working hour of " + this.paymentPerHour;
        }
    }
}
