using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_InSeat_Employee
{
   public class BasePlusCommissionEmployee: CommissionEmployee
    {
        private decimal baseSalary;

        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary): base(first, last, ssn, sales,rate)
        {
            BaseSalary = salary;
        }

        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }

            set
            {
                if (value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >=0"); 
            }
        }
    }
}
