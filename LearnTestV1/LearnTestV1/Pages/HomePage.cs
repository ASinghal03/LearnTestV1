using LearnTestV1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTestV1.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            //Identify Administration Drop Down List
            IWebElement AdministrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdministrationDropDown.Click();
            

            //Select Time and Materials Option
            Wait.WaitToBeClickable(driver,"XPath", 5, "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");
            IWebElement TimeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeAndMaterialOption.Click();
        }
        public void GoToEmployeePage(IWebDriver driver)
        {
            //Identify Administration Drop Down List
            IWebElement AdministrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdministrationDropDown.Click();


            //Select Time and Materials Option
            Wait.WaitToBeClickable(driver, "XPath", 5, "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a");
            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click();
        }
    }
}
