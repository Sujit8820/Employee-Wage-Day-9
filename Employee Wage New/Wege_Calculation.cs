using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_New
{
    class Wege_Calculation
    {
        private const int IS_FULL_Time = 1;
        private const int IS_Part_Time = 2;
        private const int ABSENT = 0;

        public Dictionary<string, Company> companyList = new Dictionary<string, Company>();
        public void AddCompany(string companyName, float EmpWagePerHr, int FullTime_WorkingHrs, int PartTime_WorkingHrs, int Max_WorkingHrs, int Max_WorkingDays)
        {
            Company company = new Company(companyName.ToLower(), EmpWagePerHr, FullTime_WorkingHrs, PartTime_WorkingHrs, Max_WorkingHrs, Max_WorkingDays);
            companyList.Add(companyName.ToLower(), company);
        }

        private int GetWorkingHrs()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            return empCheck;
        }

        public void empTotalWage(string companyName)
        {
            int day = 0;
            int workingHrs = 0;
            int totalWorkingHrs = 0;
            float empTotalWage = 0;

            if (!companyList.ContainsKey(companyName.ToLower()))
                throw new ArgumentNullException("Company dosen't exist");
            companyList.TryGetValue(companyName.ToLower(), out Company company);

            int MAXDAYS = company.Max_WorkingDays;
            int MAXHRS = company.Max_WorkingHrs;




            while (day <= MAXDAYS && workingHrs <= MAXHRS)
            {

                switch (GetWorkingHrs())
                {
                    case ABSENT:
                        workingHrs = 0;
                        break;
                    case IS_Part_Time:
                        workingHrs = company.PartTime_WorkingHrs;
                        break;
                    case IS_FULL_Time:
                        workingHrs = company.FullTime_WorkingHrs;
                        break;



                }

                totalWorkingHrs = totalWorkingHrs + workingHrs;

                float empWage = company.EmpWagePerHr * workingHrs;
                empTotalWage = empTotalWage + empWage;

                //Console.WriteLine($"Employee day {day + 1} wage is {empWage}");
                day++;
            }
            Console.WriteLine("\nDetails of company " + company.companyName);
            Console.WriteLine("Total working hours is " + totalWorkingHrs);
            Console.WriteLine("Total employee wage is " + empTotalWage);
        }


    }




}
