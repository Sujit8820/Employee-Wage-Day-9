using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_New
{
    class Wege_Calculation
    {
       

            public void EmpWage()
            {

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            int workingHrs = 0;


            //Constants
            const int ABSENT = 0;
            const int FULLTIME = 1;
            const int WAGEPERHRS = 20;


            if (empCheck == ABSENT)
            {
                workingHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            else if (empCheck == FULLTIME)
            {
                workingHrs = 8;
                Console.WriteLine("Employee is full time present");
            }
            else
            {
                workingHrs = 4;
                Console.WriteLine("Employee is part time present");
            }
            int empWage = WAGEPERHRS * workingHrs;

            Console.WriteLine("Employee Wage "+ empWage);
            }
        
    }
}
