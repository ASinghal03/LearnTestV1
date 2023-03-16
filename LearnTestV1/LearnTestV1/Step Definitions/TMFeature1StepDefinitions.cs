using LearnTestV1.Pages;
using LearnTestV1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace LearnTestV1
{
    [Binding]
    public class TMFeature1StepDefinitions: CommonDriver
    {
        HomePage HomePageObj = new HomePage();
        TMPage TMPageObj = new TMPage();

        [Given(@"I logged into portal successfully")]
        public void GivenILoggedIntoPortalSuccessfully()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login Page Object Initialization and Definition
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to TM page")]
        public void WhenINavigateToTMPage()
        {
            HomePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new record")]
        public void WhenICreateANewRecord()
        {
            TMPageObj.CreateTMPage(driver);
        }

        [Then(@"The record is created successfully")]
        public void ThenTheRecordIsCreatedSuccessfully()
        {
            string newCode = TMPageObj.GetCode(driver);
            string newDescription = TMPageObj.GetDescription(driver);
            string newPrice = TMPageObj.GetPrice(driver);

            Assert.That(newCode == "February2023", "Actual code and expected code do not match.");
            Assert.That(newDescription == "Feb23", " Actual description and expected description do not match.");
            Assert.That(newPrice == "12", " Actual price and expected price do not match.");
        }
        
        [When(@"IUpdate '([^']*)','([^']*)','([^']*)' to an existing record")]
        public void WhenIUpdateToAnExistingRecord(string time, string price, string desc)
        {
            throw new PendingStepException();
        }
        [Then(@"'([^']*)','([^']*)','([^']*)' is modified successfully")]
        public void ThenIsModifiedSuccessfully(string time, string price, string desc)
        {
            throw new PendingStepException();
        }

    }
}
