using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Payroll_System
{
    internal class StudentService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>();

        void IEmployeeService.AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("Employee added successfully.");
        }

        void IEmployeeService.DeleteEmployee(int id)
        {
            Employee employee = employees.Find(e => e.Id == id);

            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        List<Employee> IEmployeeService.GetAllEmployees()
        {
            return employees;
        }

        Employee IEmployeeService.SearchEmployeeById(int id)
        {
            Employee employee = employees.Find(e => e.Id == id);
            return employee;
        }

        List<Employee> IEmployeeService.SearchEmployeesByJobType(string jobType)
        {
            List<Employee> employee = employees.Where(e => e.JobType.Equals(jobType, StringComparison.OrdinalIgnoreCase)).ToList();
            return employee;

        }

        void IEmployeeService.UpdateEmployee(int id)
        {
            Employee employee = employees.Find(e => e.Id == id);
            if (employee != null)
            {
                string type = employee.JobType;
                switch (type)
                {
                    case "full-time":
                        FullTimeEmployee ftEmployee = (FullTimeEmployee)employee;
                        Console.WriteLine("Enter new name:");
                        ftEmployee.Name = Console.ReadLine();
                        Console.WriteLine("Enter new department:");
                        ftEmployee.Department = Console.ReadLine();
                        Console.WriteLine("Enter new annual salary:");
                        ftEmployee.BasicSalary = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new house allowance:");
                        ftEmployee.HouseAllowance = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new tax percentage:");
                        ftEmployee.TextPercentage = decimal.Parse(Console.ReadLine());
                        break;
                    case "part-time":
                        PartTimeEmployee ptEmployee = (PartTimeEmployee)employee;
                        Console.WriteLine("Enter new name:");
                        ptEmployee.Name = Console.ReadLine();
                        Console.WriteLine("Enter new department:");
                        ptEmployee.Department = Console.ReadLine();
                        Console.WriteLine("Enter new hourly rate:");
                        ptEmployee.HourlyRate = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new hours worked:");
                        ptEmployee.WorkingHoure = int.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine("Employee updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
