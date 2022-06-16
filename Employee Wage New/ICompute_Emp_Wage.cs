using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_New
{
    public interface ICompute_Emp_Wage
    {
        public void AddCompany(string companyName, float EmpWagePerHr, int FullTime_WorkingHrs, int PartTime_WorkingHrs, int Max_WorkingHrs, int Max_WorkingDays);
        
        
        public void empTotalWage(string companyName);
        
        
    }
}
