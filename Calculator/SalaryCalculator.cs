using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;
        const int HoursInWeek = 40;

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            decimal annualSalary = hourlyWage * HoursInYear;
            return annualSalary;
        }
        
        public decimal GetWeeklySalary(decimal hourlyWage)
        {
            decimal weeklySalary = hourlyWage * HoursInWeek;
            return weeklySalary;
        }

        public decimal GetHourlyWage(decimal annualWage)
        {
            //return 0;
            return annualWage / HoursInYear;
        }
    }
}
