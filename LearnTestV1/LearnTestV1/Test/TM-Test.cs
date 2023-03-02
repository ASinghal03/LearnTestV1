using LearnTestV1.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnTestV1.Utilities;

namespace LearnTestV1.Test
{
    [TestFixture]
    public class TM_Test : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            // Open Web Browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login Page Object Initialization and Definition
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);

            //Home Page Object Initialization and Definition

            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToTMPage(driver);

        }
        [Test]
        public void CreateTMStep()
        {
            // TM Page Object Initialization and Definition

            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTMPage(driver);

        }
        [Test]
        public void EditTMStep()
        {
            //Edit TM Page Object Initialization and Definition
            TMPage TMPageObj = new TMPage();
            TMPageObj.EditTMPage(driver);

        }
        [Test]
        public void DeleteTMStep()
        {
            //Delete TM Page Object Initialization and Definition
            TMPage TMPageObj = new TMPage();
            TMPageObj.DeleteTMPage(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
