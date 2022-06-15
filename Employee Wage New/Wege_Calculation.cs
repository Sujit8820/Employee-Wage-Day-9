using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_New
{
    class Wege_Calculation
    {


        public static int calHrs()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            int workingHrs = 0;


            //Constants
            const int ABSENT = 0;
            const int FULLTIME = 1;
            const int WAGEPERHRS = 20;


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

            int empWage = WAGEPERHRS * workingHrs;
            return empWage;

        }

        public void EmpWage()
        {
            Console.WriteLine("Wellcome to Employee Wage Program\n");

            int day = 0;
            int empTotalWage = 0;
            int MAXDAYS = 20;

            while (day < MAXDAYS)
            {
                int empWage = Wege_Calculation.calHrs();
                empTotalWage = empTotalWage + empWage;
                Console.WriteLine($"Employee day {day + 1} wage is {empWage}");
                day++;
            }
            Console.WriteLine("\nEmployee total wage is " + empTotalWage);

        }
    }
}
