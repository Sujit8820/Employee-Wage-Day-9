using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_New
{
    class Wege_Calculation : ICompute_Emp_Wage
    {
        private const int IS_FULL_Time = 1;
        private const int IS_Part_Time = 2;
        private const int ABSENT = 0;

        private Dictionary<string, Company> companies_Dict;
        //public string[] Company_List;
        public ArrayList Company_List;
        public int Company_Index = 0;

        public Wege_Calculation(int Number)
        {
            companies_Dict = new Dictionary<string, Company>();
            // Company_List = new string[Number * 2];
            Company_List = new ArrayList();
        }
        public void AddCompany(string companyName, float EmpWagePerHr, int FullTime_WorkingHrs, int PartTime_WorkingHrs, int Max_WorkingHrs, int Max_WorkingDays)
        {
            Company company_Obj = new Company(companyName.ToLower(), EmpWagePerHr, FullTime_WorkingHrs, PartTime_WorkingHrs, Max_WorkingHrs, Max_WorkingDays);
            companies_Dict.Add(companyName.ToLower(), company_Obj);
            Company_List.Add(companyName);
            //Company_List[Company_Index] = companyName;
            //Company_Index++;
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

            if (!companies_Dict.ContainsKey(companyName.ToLower()))
                throw new ArgumentNullException("Company dosen't exist");
            companies_Dict.TryGetValue(companyName.ToLower(), out Company company);

            int MAXDAYS = company.Max_WorkingDays;
            int MAXHRS = company.Max_WorkingHrs;

            while (day <= MAXDAYS && workingHrs < MAXHRS)
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
            //Company_List[Company_Index] = Convert.ToString(empTotalWage);
            Company_List.Add(empTotalWage);
           
        }
        public void View_Wage()
        {
            for(int i = 0; i < Company_List.Count;i+=2)
            {
                Console.WriteLine("Monthly wage for "+Company_List[i] +" is "+ Company_List[i+1]);

            }
        }


    }




}
