using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_InSeat_Employee
{
   public  class CommissionEmployee: Employee
    {
        private decimal grossSales;
        private decimal commissionRate;

        public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate): base(first, last, ssn)
        {
            grossSales = sales;
            commissionRate = rate;
        }

        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value >= 0)
                    grossSales = value;
                else
                    throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales must >=0");
            }
        }

        public decimal CommssionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value > 0 && value < 1)
                    commissionRate = value;
                else
                    throw new ArgumentOutOfRangeException("CommissionRate", value, "ComissionRate must be> 0 and <1");
            }
        }

        public override decimal Earnings()
        {
            return commissionRate * GrossSales;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}", "commission employee", base.ToString(), "gross sales", GrossSales, "comission rate", commissionRate); 
        }
        
    }
}
