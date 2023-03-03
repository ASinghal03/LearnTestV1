using LearnTestV1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.DevTools.V109.CSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace LearnTestV1.Pages
{
    public class EmployeePage : CommonDriver
    {
       
        public void CreateEmployee(IWebDriver driver)
        {
            //Identify and Click on New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
                    
            //Type Name
            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("AnkitS");
            
            //Type UserName
            IWebElement userNameTextBox = driver.FindElement(By.Id("Username"));
            userNameTextBox.SendKeys("Singhal123");

            //Type Price Per Unit
            IWebElement contactTextBox = driver.FindElement(By.XPath("//*[@id=\"ContactDisplay\"]"));
            contactTextBox.SendKeys("20000000");

            //Type Password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("Welcome@1006");

            //Type Price Per Unit
            IWebElement reTypePasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            reTypePasswordTextBox.SendKeys("Welcome@1006");
            
            //Click Radio Box if Admin
            IWebElement adminRadioBox = driver.FindElement(By.Id("IsAdmin"));
            adminRadioBox.Click();

            //Type Password
            IWebElement vehicleTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleTextBox.SendKeys("Honda");

            //Click on Save Button
            Thread.Sleep(1000);
            IWebElement groupsDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div"));
            groupsDropDown.Click();
            Thread.Sleep(1000);
            Console.WriteLine("executed");
            
            IWebElement groupsDropListClick = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]"));
            groupsDropListClick.Click();
            Thread.Sleep(1000);
            Console.WriteLine("executed");

            //Validate Last Record
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();
            //saveButton.Click();
            
            //Identify Administration Drop Down List
            IWebElement AdministrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdministrationDropDown.Click();


            //Select Time and Materials Option
            //Wait.WaitToBeClickable(driver, "XPath", 5, "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a");
            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click();
           
            //Thread.Sleep(5000);

            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                                                                    
            if (lastRecord.Text == "AnkitS")
            {
                Console.WriteLine("Record Created");
            }
            else
            {
                Console.WriteLine("Record Not Created");
            }
        }
        public void EditEmployee(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();

            Thread.Sleep(1000);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editButton.Click();

            IWebElement editName = driver.FindElement(By.Id("Name"));
            editName.Clear();
            editName.SendKeys("AnkitSingh");
            //Validate Last Record
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();
            //saveButton.Click();

            Thread.Sleep(2000);
            //Identify Administration Drop Down List
            IWebElement AdministrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdministrationDropDown.Click();


            //Select Time and Materials Option
            //Wait.WaitToBeClickable(driver, "XPath", 5, "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a");
            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click();

            //Thread.Sleep(5000);

            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();

            IWebElement lasteditRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lasteditRecord.Text == "AnkitSingh")
            {
                Console.WriteLine("Record Edited");
            }
            else
            {
                Console.WriteLine("Record Not Edited");
            }
        }
        public void DeleteEmployee(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();

            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[2]/td[1]"));

            Thread.Sleep(1000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteButton.Click();
            driver.SwitchTo().Alert().Accept();

            IWebElement lastRecordAfterDelete = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecord.Text != lastRecordAfterDelete.Text)
            {
                Console.WriteLine("Record Deleted");
            }
            else
            {
                Console.WriteLine("Record Not Deleted");
            }
        }
    }
}
