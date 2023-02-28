using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTestV1.Pages
{
    public class LoginPage
    {
            public void LoginActions(IWebDriver driver)
            {
                
                //Launch Turnup Portal
                driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
                
                //Identify Username Text Box
                IWebElement UserNameTextBox = driver.FindElement(By.Id("UserName"));
                
                //Enter Username
                UserNameTextBox.SendKeys("hari");
                
                //Identify Password Text Box
                IWebElement PasswordTextBox = driver.FindElement(By.Id("Password"));
                
                //Enter Password
                PasswordTextBox.SendKeys("123123");
                
                //Identify Remember Me Radio Button
                IWebElement RememberMeRadioButton = driver.FindElement(By.Id("RememberMe"));
                
                //Remember Me Must be Ticked
                RememberMeRadioButton.Click();
                Thread.Sleep(1000);
                
                //Locate Login Button
                IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
                Thread.Sleep(1000);
                
                //Click on Login Button
                LoginButton.Click();
                IWebElement HelloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
                
                //Validate if Login is Successfull or Not
                Thread.Sleep(1000);
                if (HelloHari.Text == "Hello hari!")
                {
                    Console.WriteLine("Login Successfully");
                }
                else
                {
                    Console.WriteLine("Login Unsucessfull");
                }
            }
    }
}
