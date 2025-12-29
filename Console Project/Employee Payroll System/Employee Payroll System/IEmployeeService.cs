using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Payroll_System
{
    internal interface IEmployeeService
    {
        void AddEmployee(Employee employee);
        List<Employee> GetAllEmployees();
        void UpdateEmployee(int id);
        void DeleteEmployee(int id);
        Employee SearchEmployeeById(int id);
        List<Employee> SearchEmployeesByJobType(string jobType);

    }
}
