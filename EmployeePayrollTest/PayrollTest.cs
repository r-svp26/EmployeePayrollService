using EmployeePayroll;
using NUnit.Framework;

namespace EmployeePayrollTest
{
    public class Tests
    {
        EmployeeOperation employeeOperation = new EmployeeOperation();
        [Test]
        public void GivenEmployeeDetail_ShouldMatchWithUpdatedDetails()
        {
            int expected = 1;
            int actual = employeeOperation.UpdateEmployeeSalary();
            Assert.AreEqual(expected, actual);
        }
    }
}