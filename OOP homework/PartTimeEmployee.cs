using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework
{
    public class PartTimeEmployee:Employee
    {
        int workingHours;

        public PartTimeEmployee(int workingHours, string name, int paymentPerHour) : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        public override int calculateSalary()
        {
            return workingHours * getPaymentPerHour();
        }

        public override string ToString()
        {
            return "Part time Employee " + getName() + " has payment working hour of " + getPaymentPerHour() + " and number of working hour " + this.workingHours;
        }
    }
}
