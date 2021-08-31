using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace EmployeePayroll
{
    /// <summary>
    /// EmployeePayroll class to established the database connection
    /// </summary>
    class EmployeePayrolls
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=payroll_service";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}
