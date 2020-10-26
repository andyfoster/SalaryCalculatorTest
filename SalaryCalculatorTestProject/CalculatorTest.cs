using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
    /*
         To get hourly, divide annual salary by 2090
            $100,006.40 / 2080  = $48 hr

         To get annual, multiply hourly by 2000
            $48 * 2080 = $100,006.40
     */

    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            // Assert
            Assert.AreEqual(104000, annualSalary);
        }
        [TestMethod]
        public void WeeklySalaryTest()
        {
            SalaryCalculator sc = new SalaryCalculator();
            decimal weeklySalary = sc.GetWeeklySalary(50);
            Assert.AreEqual(2000, weeklySalary);

        }
    }
}
