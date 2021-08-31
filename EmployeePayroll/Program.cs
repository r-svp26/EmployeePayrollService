using System;
using System.Data;

namespace EmployeePayroll
{
    /// <summary>
    /// main class
    /// </summary>
    class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service");
            EmployeeOperation employeeOperation = new EmployeeOperation();
            employeeOperation.GetAllEmployeeDetail();
        }
    }
}
