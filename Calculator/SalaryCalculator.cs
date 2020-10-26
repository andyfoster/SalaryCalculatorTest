using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;
        const int HoursInWeek = 40;

        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HoursInYear;     
        
        public decimal GetWeeklySalary(decimal hourlyWage) => hourlyWage * HoursInWeek;

        public decimal GetHourlyWage(decimal annualWage) => annualWage / HoursInYear;
  
    }
}
