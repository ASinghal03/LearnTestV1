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
            Thread.Sleep(1000);

            //Select Time and Materials Option
            IWebElement TimeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeAndMaterialOption.Click();
        }
    }
}
