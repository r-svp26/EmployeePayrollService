using EmployeePayroll;
using NUnit.Framework;
using System;
using System.Collections.Generic;

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
        /// <summary>
        /// UC1-add-multiple-employee-without-thread
        /// </summary>
        [Test]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(1, "Ritesh", "M", "9907210105", "Danapur", "HR", 2000, 200.0, 120.5, 150.0, 1540.20, DateTime.Today, "Patna", "IN"));
            list.Add(new Employee(2, "Shyam", "M", "9907210100", "Patna", "R&D", 2008, 100.0, 120.5, 150.0, 1540.20, DateTime.Today, "Arrah", "IN"));
            list.Add(new Employee(3, "Sonu", "M", "9907210420", "Khaspur", "IT", 2000, 200.0, 120.5, 150.0, 1650.20, DateTime.Today, "Patna", "IN"));
            DateTime startDateTime = DateTime.Now;
            employeeOperation.AddMultipleEmployee(list);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread" + (startDateTime - stopDateTime));
        }
        /// <summary>
        /// UC2-add-multiple-employee-with-thread
        /// </summary>
        [Test]
        public void GivenEmployee_WhenAddedToListThread_ShouldMatchEmployeeEntries()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(4, "Radha", "F", "9907210105", "Danapur", "HR", 2000, 200.0, 120.5, 150.0, 1540.20, DateTime.Today, "Patna", "IN"));
            list.Add(new Employee(5, "Radhika", "F", "9907210100", "Patna", "QA", 2008, 100.0, 120.5, 150.0, 1540.20, DateTime.Today, "Delhi", "IN"));
            list.Add(new Employee(6, "Sonalika", "F", "9907210420", "Khaspur", "Finace", 2000, 200.0, 120.5, 150.0, 1650.20, DateTime.Today, "Mumbai", "IN"));
            DateTime startDateTimeThread = DateTime.Now;
            employeeOperation.AddMultipleEmployeeThread(list);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread" + (startDateTimeThread - stopDateTimeThread));
        }
    }
}