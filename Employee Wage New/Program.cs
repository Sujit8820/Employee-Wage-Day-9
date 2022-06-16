using System;
using System.Collections.Generic;

namespace Employee_Wage_New
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Employee Wage Program");
            Wege_Calculation emp = new Wege_Calculation(2);
            emp.AddCompany("TATA", 20, 8, 4, 100, 20);
            emp.empTotalWage("TATA");
            emp.AddCompany("DMART", 25, 9, 5, 120, 25);
            emp.empTotalWage("DMART");

            emp.View_Wage();
        }
    }
}
