using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Payroll_System
{
    internal class FullTimeEmployee : Employee
    {
        public decimal BasicSalary { get; set; }
        public decimal HouseAllowance { get; set; }
        public decimal TextPercentage { get; set; }

        public override string JobType => "full-time";
        public override decimal CalculateSalary()
        {
            decimal grossSalary = BasicSalary + HouseAllowance;
            decimal taxAmount = grossSalary * TextPercentage / 100;
            return grossSalary - taxAmount;
        }
    }
}
