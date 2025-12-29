namespace Employee_Payroll_System
{
    internal class Program
    {
        static IEmployeeService employeeService = new StudentService();

        static int counter = 1;

        static void Main(string[] args)
        {

            int choice;
            do
            {
                Console.WriteLine("Welcome to Employee Payroll System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. SearchEmployee");
                Console.WriteLine("6. Search Employee By Job Type");
                Console.WriteLine("0. Exite");

                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ViewEmployee();
                        break;
                    case 3:
                        UpdateEmployee();
                        break;
                    case 4:
                        DeleteEmployee();
                        break;
                    case 5:
                        SearchEmployee();
                        break;
                    case 6:
                        SearchEmployeeByJobType();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            while (choice != 0);
        }

        static void AddEmployee()
        {
            Console.WriteLine("1. Part-time Employee");
            Console.WriteLine("2. Full-time Employee");

            Console.Write("Select Employee Type: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Employee employee;
            switch (choice)
            {
                case 1:
                    employee = new PartTimeEmployee();
                    employee.Id = counter++;
                    Console.Write("Enter Name: ");
                    employee.Name = Console.ReadLine();
                    Console.Write("Enter Department: ");
                    employee.Department = Console.ReadLine();
                    Console.Write("Enter Hourly Rate: ");
                    ((PartTimeEmployee)employee).HourlyRate = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter Working Hours: ");
                    ((PartTimeEmployee)employee).WorkingHoure = Convert.ToDecimal(Console.ReadLine());
                    employeeService.AddEmployee(employee);
                    break;
                case 2:
                    employee = new FullTimeEmployee();
                    employee.Id = counter++;
                    Console.Write("Enter Name: ");
                    employee.Name = Console.ReadLine();
                    Console.Write("Enter Department: ");
                    employee.Department = Console.ReadLine();
                    Console.Write("Enter Monthly Salary: ");
                    ((FullTimeEmployee)employee).BasicSalary = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter House Allowance: ");
                    ((FullTimeEmployee)employee).HouseAllowance = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter Tax Percentage: ");
                    ((FullTimeEmployee)employee).TextPercentage = Convert.ToDecimal(Console.ReadLine());
                    employeeService.AddEmployee(employee);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }

        static void ViewEmployee()
        {
            foreach (var emp in employeeService.GetAllEmployees())
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Job Type: {emp.JobType}, Salary: {emp.CalculateSalary()}");
            }
        }

        static void UpdateEmployee()
        {
            // Implementation for updating an employee
            Console.Write("Enter employee Id: ");
            int updateId = Convert.ToInt32(Console.ReadLine());
            employeeService.UpdateEmployee(updateId);

        }

        static void DeleteEmployee()
        {
            // Implementation for deleting an employee
            Console.Write("Enter employee Id: ");
            int deleteId = Convert.ToInt32(Console.ReadLine());
            employeeService.DeleteEmployee(deleteId);
        }

        static void SearchEmployee()
        {
            // Implementation for searching an employee by ID
            Console.Write("Enter employee Id: ");
            int searchId = Convert.ToInt32(Console.ReadLine());
            Employee emp = employeeService.SearchEmployeeById(searchId);
            if (emp != null)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Job Type: {emp.JobType}, Salary: {emp.CalculateSalary()}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        static void SearchEmployeeByJobType()
        {
            // Implementation for searching employees by job type
            Console.Write("Enter Job Type (full-time/part-time): ");
            string jobType = Console.ReadLine();
            var employees = employeeService.SearchEmployeesByJobType(jobType);
            if (employees.Count > 0)
            {
                foreach (var emp in employees)
                {
                    Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Job Type: {emp.JobType}, Salary: {emp.CalculateSalary()}");
                }
            }
            else
            {
                Console.WriteLine("No employees found for the specified job type.");
            }
        }
    }
}
