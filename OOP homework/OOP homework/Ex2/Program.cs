using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework.Ex2
{
    public class Program
    {
        static List<Employee> employees = new List<Employee>();
        static List<Customer> customers = new List<Customer>();
        /*static void Main(string[] args)
        {
            employees.Add(new Employee("hello", "your house", 123));
            employees.Add(new Employee("hi", "washingtion", 3));
            employees.Add(new Employee("bye", "new yrok", 143));
            employees.Add(new Employee("goodnight", "mcdonald", 93));
            customers.Add(new Customer("soup", "hanoi", 666));
            customers.Add(new Customer("pop", "china", 36));
            customers.Add(new Customer("rup", "hcm city", 13));
            customers.Add(new Customer("bob", "bacon", 35));

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Add Customer");
                Console.WriteLine("3. Display Employee with Highest Salary");
                Console.WriteLine("4. Display Customer with Lowest Balance");
                Console.WriteLine("5. Find Employee by Name");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        AddCustomer();
                        break;
                    case 3:
                        DisplayHighestSalaryEmployee();
                        break;
                    case 4:
                        DisplayLowestBalanceCustomer();
                        break;
                    case 5:
                        FindEmployeeByName();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }*/

        static void AddEmployee()
        {
            try
            {
                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();
                Console.Write("Enter employee address: ");
                string address = Console.ReadLine();
                Console.Write("Enter employee salary: ");
                int salary = int.Parse(Console.ReadLine());

                employees.Add(new Employee(name, address, salary));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for salary.");
            }
        }

        static void AddCustomer()
        {
            try
            {
                Console.Write("Enter customer name: ");
                string name = Console.ReadLine();
                Console.Write("Enter customer address: ");
                string address = Console.ReadLine();
                Console.Write("Enter customer balance: ");
                int salary = int.Parse(Console.ReadLine());

                employees.Add(new Employee(name, address, salary));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for salary.");
            }
        }

        static void DisplayHighestSalaryEmployee()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees available.");
                return;
            }

            Employee highestSalaryEmployee = employees[0];

            foreach (var employee in employees)
            {
                if (employee.salary > highestSalaryEmployee.salary)
                {
                    highestSalaryEmployee = employee;
                }
            }

            Console.WriteLine("Employee with the highest salary:");
            highestSalaryEmployee.display();
        }

        static void DisplayLowestBalanceCustomer()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers available.");
                return;
            }

            Customer lowestBalanceCustomer = customers[0];

            foreach (var customer in customers)
            {
                if (customer.balance < lowestBalanceCustomer.balance)
                {
                    lowestBalanceCustomer = customer;
                }
            }

            Console.WriteLine("Customer with the lowest balance:");
            lowestBalanceCustomer.display();
        }

        static void FindEmployeeByName()
        {
            Console.Write("Enter employee name to search: ");
            string name = Console.ReadLine();

            var foundEmployees = employees.FindAll(e => e.name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (foundEmployees.Count == 0)
            {
                Console.WriteLine("No employees found with that name.");
            }
            else
            {
                Console.WriteLine("Found employees:");
                foreach (var employee in foundEmployees)
                {
                    employee.display();
                }
            }
        }
    }


}
