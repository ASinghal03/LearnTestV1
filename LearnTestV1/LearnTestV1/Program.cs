using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.Database;
using OpenQA.Selenium.DevTools.V108.DOM;
using OpenQA.Selenium.Support.UI;

// Open Web Browser
IWebDriver Driver = new ChromeDriver();
Driver.Manage().Window.FullScreen();

//Launch Turnup Portal
Driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
//Identify Username Text Box
IWebElement UserNameTextBox = Driver.FindElement(By.Id("UserName"));
//Enter Username
UserNameTextBox.SendKeys("hari");
//Identify Password Text Box
IWebElement PasswordTextBox = Driver.FindElement(By.Id("Password"));
//Enter Password
PasswordTextBox.SendKeys("123123");
//Identify Remember Me Radio Button
IWebElement RememberMeRadioButton = Driver.FindElement(By.Id("RememberMe"));
//Remember Me Must be Ticked
RememberMeRadioButton.Click();
//Locate Login Button
IWebElement LoginButton = Driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
//Click on Login Button
LoginButton.Click();
