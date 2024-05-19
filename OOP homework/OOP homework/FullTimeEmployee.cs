using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()
        {
            return 8 * getPaymentPerHour();
        }

        public override string ToString()
        {
            return "Full time Employee " + getName() + " has payment working hour of " + getPaymentPerHour();
        }
    }
}
