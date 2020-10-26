using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
    /*
         To get hourly, divide annual salary by 2000
            $100,006.40 / 2000  = $48 hr

         To get annual, multiply hourly by 2000
            $48 * 2000 = $100,006.40
     */

    [TestClass]
    public class UnitTest1
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
    }
}