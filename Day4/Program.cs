using System;

namespace Day4
{
    class Program
    {
       public static void Main()
        {
            UC1_EmployeeAttendance.GetAttendance();
            UC2_EmpWage.EmpWage();
            UC3_PartTimeEmpWage.PartTimeEmpWage();
            UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();
            UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
            UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            UC8_ComputeEmpWageForMultipleCompanies.Main8("TCS", 100, 22, 2200);
              Console.ReadKey();
            
        }
    }
}
