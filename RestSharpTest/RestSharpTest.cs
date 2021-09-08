using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Net;

namespace RestSharpTest
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
    }
    public class RestSharpTest
    {
        RestClient client;
        [SetUp]
        public void Setup()
        {
            client = new RestClient("http://localhost:5000");
        }
        public IRestResponse GetEmployeeList()
        {
            //Arrange
            RestRequest request = new RestRequest("/employee", Method.GET);
            //Act
            IRestResponse response = client.Execute(request);
            return response;
        }
        // UC1-count-list-of-employee
        [Test]
        public void OnCallingGETApi_ReturnEmployeeList()
        {
            IRestResponse response = GetEmployeeList();
            //Assert
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
            List<Employee> dataResponse = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
            Assert.AreEqual(5, dataResponse.Count);

            foreach (Employee emp in dataResponse)
            {
                System.Console.WriteLine("ID: " + emp.ID + "\t Name: " + emp.Name + "\t Salary: " + emp.Salary);
            }
        }
        [Test]
        public void GivenEmployee_OnPOSTApi_ShouldReturnAddedEmployee()
        {
            RestRequest request = new RestRequest("/employee", Method.POST);
            JObject jObject = new JObject();
            jObject.Add("Name", "Radhika");
            jObject.Add("Salary", "1050");

            request.AddParameter("application/json", jObject, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.Created);
            Employee dataResponce = JsonConvert.DeserializeObject<Employee>(response.Content);
            Assert.AreEqual("Radhika", dataResponce.Name);
            Assert.AreEqual("1050", dataResponce.Salary);
            System.Console.WriteLine(response.Content);
        }
    }
}