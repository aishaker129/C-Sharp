using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Payroll_System
{
    internal class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public decimal WorkingHoure { get; set; }

        public override string JobType => "part-time";
        public override decimal CalculateSalary()
        {
            return HourlyRate * WorkingHoure;
        }
    }
}
