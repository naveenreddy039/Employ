using System;

namespace Employ
{
    public class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 1;
        public const int empWagePerHour = 20;
        static void Main(string[] args)
        {
            EmployeeWage emp = new EmployeeWage();
            emp.AddSwitch();

            //UC1
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck== isFullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            //UC2
            int empHrs = 0;
            int empWage = 0;
            if(empCheck== isFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empWagePerHour;
            Console.WriteLine("Daily EmpWage:" + empWage);

            //UC3
            int partTimeHrs = 0;
            int partTimeEmpWage = 0;
            if (empCheck == isPartTime)
            {
                partTimeHrs = 8;
            }
            else
            {
                partTimeHrs = 0;
            }
            partTimeEmpWage = partTimeHrs * empWagePerHour;
            Console.WriteLine("PartTime EmpWage:" + partTimeEmpWage);
        }
    }
}
