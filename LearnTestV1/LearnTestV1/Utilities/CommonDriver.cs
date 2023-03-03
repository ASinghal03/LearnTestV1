using LearnTestV1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTestV1.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        [SetUp]
        public void LoginSteps()
        {
            // Open Web Browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login Page Object Initialization and Definition
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
