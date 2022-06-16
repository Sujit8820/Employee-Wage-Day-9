using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_New
{
    class Company
    {
        public float EmpWagePerHr;
        public int FullTime_WorkingHrs;
        public int PartTime_WorkingHrs;
        public int Max_WorkingHrs;
        public int Max_WorkingDays;
        public string companyName;

        public Company(string companyName, float EmpWagePerHr, int FullTime_WorkingHrs, int PartTime_WorkingHrs, int Max_WorkingHrs, int Max_WorkingDays)
        {
            this.companyName = companyName;
            this.EmpWagePerHr = EmpWagePerHr;
            this.FullTime_WorkingHrs = FullTime_WorkingHrs;
            this.PartTime_WorkingHrs = PartTime_WorkingHrs;
            this.Max_WorkingHrs = Max_WorkingHrs;
            this.Max_WorkingDays = Max_WorkingDays;

        }

    }
}
