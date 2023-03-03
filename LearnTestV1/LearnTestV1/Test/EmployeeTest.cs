using LearnTestV1.Pages;
using LearnTestV1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTestV1.Test
{
    [TestFixture]
    [Parallelizable]
    public class EmployeeTest : CommonDriver
    {
      

        //Page Object Initialization and Definition
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();
        
        
        [Test , Order(1)]
        public void CreateEmployeeTest()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.CreateEmployee(driver);
            

        }
        [Test, Order(2)]
        public void EditEmployeeTest()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.EditEmployee(driver);
        }
        [Test, Order(3)]
        public void DeleteEmployeeTest()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
        }
        
    }
}
