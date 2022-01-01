using System;
using System.Collections.Generic;
using System.Text;

namespace Employ
{
    public class EmployeeWage
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empWagePerHour = 20;
        public const int maxWorkingDaysInMonth = 20;
        public const int maxHoursInMonth = 100;
        public const int empRatePerDay = 20;

        public void AddSwitch()
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 2);

            //UC4
            switch (empCheck)
            {
                case isPartTime:
                    empHrs = 8;
                break;

                case isFullTime:
                    empHrs = 4;
                break;

                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * empWagePerHour;
            Console.WriteLine("Daily EmpWage:" + empWage);

            //UC5
            int totalWorkingHrs = 0;
            int workingHrs = 0;
            int empWagePerMonth = 0;
            switch (empCheck)
            {
                case isPartTime:
                    workingHrs = 8;
                    break;

                case isFullTime:
                    workingHrs = 4;
                    break;

                default:
                    workingHrs = 0;
                    break;
            }
            totalWorkingHrs = workingHrs * maxHoursInMonth;
            empWagePerMonth = totalWorkingHrs * empRatePerDay;
            Console.WriteLine("wages Per Month:" + empWagePerMonth);

            //UC6
            int totalWorkingDaysPerMonth = 0;
            switch (empCheck)
            {
                case isPartTime:
                    workingHrs = 8;
                    break;

                case isFullTime:
                    workingHrs = 4;
                    break;

                default:
                    workingHrs = 0;
                    break;
            }
            totalWorkingHrs = workingHrs + maxHoursInMonth;
            totalWorkingDaysPerMonth = totalWorkingHrs * maxWorkingDaysInMonth;
            Console.WriteLine("wages Per Month:" + totalWorkingDaysPerMonth);
        }
    }
}
