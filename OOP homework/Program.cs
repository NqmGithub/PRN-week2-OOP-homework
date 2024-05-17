using System.Runtime.CompilerServices;

namespace OOP_homework
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static void Main(String[] args)
        {
            // declare list
            

            // predefined employees
            employees.Add (new FullTimeEmployee("John Cena", 20));
            employees.Add(new FullTimeEmployee("Lebron James", 34));
            employees.Add(new FullTimeEmployee("Wont Smith", 20));
            employees.Add(new FullTimeEmployee("Tailor", 20));
            employees.Add(new PartTimeEmployee(2, "corn", 49));
            employees.Add(new PartTimeEmployee(2, "pea", 55));
            employees.Add(new PartTimeEmployee(13, "bean", 32));
            employees.Add(new PartTimeEmployee(5, "cob", 19));

            //menu
            int option = 0;
            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Add new employee");
                Console.WriteLine("2. Display employees");
                Console.WriteLine("3. Find employee with highest salary of each type");
                Console.WriteLine("4. Find employee by  name");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Your choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add();
                        break;
                    case 3:
                        Console.WriteLine(FulltimeHighestSalary(employees).ToString());
                        Console.WriteLine(ParttimeHighestSalary(employees).ToString());
                        break;
                    case 2:
                        foreach (var item in employees)
                        {
                            Console.WriteLine(item.ToString());    
                        }
                        break;
                    case 4:
                        FindEmployeeByName();
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            } while(option != 0);    
        }

        static void FindEmployeeByName()
        {
            Console.Write("Enter employee name to search: ");
            string name = Console.ReadLine();

            var foundEmployees = employees.FindAll(e => e.getName().Equals(name, StringComparison.OrdinalIgnoreCase));

            if (foundEmployees.Count == 0)
            {
                Console.WriteLine("No employees found with that name.");
            }
            else
            {
                Console.WriteLine("Found employees:");
                foreach (var employee in foundEmployees)
                {
                    Console.WriteLine(employee);
                }
            }
        }
        static void add()
        {
            Console.WriteLine("Fulltime(1) or Parttime(0)");
            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                addfulltime();
            }
            else
            {
                addparttime();
            }
        }

        static void addfulltime()
        {
            try
            {
                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();
                Console.Write("Enter payment per hour: ");
                int paymentPerHour = int.Parse(Console.ReadLine());

                employees.Add(new FullTimeEmployee(name, paymentPerHour));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for payment per hour.");
            }
        }

        static void addparttime()
        {
            try
            {
                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();
                Console.Write("Enter payment per hour: ");
                int paymentPerHour = int.Parse(Console.ReadLine());
                Console.Write("Enter working hours: ");
                int workingHours = int.Parse(Console.ReadLine());

                employees.Add(new PartTimeEmployee(workingHours, name, paymentPerHour));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for payment per hour and working hours.");
            }
        }
        static FullTimeEmployee FulltimeHighestSalary(List<Employee> employees)
        {
            int max = 0;
            return (FullTimeEmployee) employees.Where(e => e is FullTimeEmployee).OrderByDescending(e => e.calculateSalary()).First();
        }

        static PartTimeEmployee ParttimeHighestSalary(List<Employee> employees)
        {
            int max = 0;
            return (PartTimeEmployee)employees.Where(e => e is PartTimeEmployee).OrderByDescending(e => e.calculateSalary()).First();
        }
    }
}