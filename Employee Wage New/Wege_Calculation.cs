using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_New
{
    class Wege_Calculation
    {


        public static int GetWorkingHrs()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            int workingHrs = 0;


            //Constants
            const int ABSENT = 0;
            const int FULLTIME = 1;


            switch (empCheck)
            {

                case ABSENT:
                    workingHrs = 0;
                    break;

                case FULLTIME:
                    workingHrs = 8;
                    break;

                default:
                    workingHrs = 4;
                    break;
            }

            return workingHrs;

        
    }

        public void empTotalWage()
        {
            Console.WriteLine("Wellcome to Employee Wage Program\n");

        int day = 0;
        int workingHrs = 0;
        int totalWorkingHrs = 0;
        int empTotalWage = 0;
        int MAXDAYS = 20;
        int MAXHRS = 100;
        int WAGEPERHRS = 20;

        while (day < MAXDAYS && workingHrs < MAXHRS)
        {
            workingHrs = Wege_Calculation.GetWorkingHrs();
            totalWorkingHrs = totalWorkingHrs + workingHrs;

            int empWage = WAGEPERHRS * workingHrs;
            empTotalWage = empTotalWage + empWage;

            Console.WriteLine($"Employee day {day + 1} wage is {empWage}");
            day++;
        }
        Console.WriteLine("\nTotal working hours is " + totalWorkingHrs);
        Console.WriteLine("Total employee wage is " + empTotalWage);
    }
    }
}
