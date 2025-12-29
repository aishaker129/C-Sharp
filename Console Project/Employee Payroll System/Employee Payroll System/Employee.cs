using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Payroll_System
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public abstract string JobType { get; }

        public abstract decimal CalculateSalary();
    }
}
