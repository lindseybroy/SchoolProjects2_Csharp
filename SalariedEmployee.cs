﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_InSeat_Employee
{
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        public SalariedEmployee(string first, string last, string ssn, decimal salary) : base(first, last, ssn)
        {
            weeklySalary = salary;
        }
        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if (value >= 0)
                    weeklySalary = value;
                else
                    throw new ArgumentOutOfRangeException("WeeklySalary", value, "WeeklySalary must be >=0");
            }
        }
        public override decimal Earnings()
        {
            return WeeklySalary;
        }

        public override string ToString()
        {
            return string.Format("salaried employee: {0}\n{1}: {2:C}", base.ToString(), "weekly salary", "WeeklySalary"); 
        }
    }
}
    

