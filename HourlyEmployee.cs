﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_InSeat_Employee
{
    public class HourlyEmployee: Employee
    {
        private decimal wage;
        private decimal hours;

        public HourlyEmployee(string first, string last, string ssn, decimal hourlyWage, decimal hoursWorked): base(first, last, ssn)
        {
            wage = hourlyWage;
            hours = hoursWorked;
        }
        public decimal Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value >= 0)
                    wage = value;
                else
                    throw new ArgumentOutOfRangeException("Wage", value, "Wage must be>=0");
            }
        }
        public decimal Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value >= 0 && value <= 168)
                    hours = value;
                else
                    throw new ArgumentOutOfRangeException("Hours", value, "Hours must be>=0 and <=168");
            }
        }
        public override decimal Earnings()
        {
            if (Hours <= 40)
                return Wage * Hours;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        }

        public override string ToString()
        {
            return string.Format("hourly employee: {0}\n{1}: {2:C}; {4:F2}", base.ToString(), "hourly wage", Wage, "hours worked", Hours); 
        }
    }
}
