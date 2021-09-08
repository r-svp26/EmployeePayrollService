using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
    /// <summary>
    /// POCO class
    /// </summary>
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public int BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public DateTime StartDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        /// <summary>
        /// default constructor
        /// </summary>
        public Employee() 
        {
        }
        /// <summary>
        /// parametrized constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="City"></param>
        public Employee(int ID, string Name, string Gender, string PhoneNumber, string Address, string Department, int BasicPay,
                        double Deduction, double TaxablePay, double Tax, double NetPay, DateTime StartDate, string City, string Country)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Department = Department;
            this.BasicPay = BasicPay;
            this.Deduction = Deduction;
            this.TaxablePay = TaxablePay;
            this.Tax = Tax;
            this.NetPay = NetPay;
            this.StartDate = StartDate;
            this.City = City;
            this.Country = Country;
        }
    }
}
