
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;


// Open Web Browser
IWebDriver Driver = new EdgeDriver();
Driver.Manage().Window.Maximize();

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
Thread.Sleep(1000);
//Locate Login Button
IWebElement LoginButton = Driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
Thread.Sleep(1000);
//Click on Login Button
LoginButton.Click();
IWebElement HelloHari = Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
Thread.Sleep(1000);
if (HelloHari.Text == "Hello hari!")
{
    Console.WriteLine("Login Successfully");
}
else
{
    Console.WriteLine("Login Unsucessfull");
}
//Select Administradtion Drop Down
IWebElement AdministrationDropDown = Driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
AdministrationDropDown.Click();
Thread.Sleep(1000);
//Select Time and Materials Option
IWebElement TimeAndMaterialOption = Driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
TimeAndMaterialOption.Click();
Thread.Sleep(1000);
//Click on Create New Button
IWebElement CreateNewButton = Driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
CreateNewButton.Click();
Thread.Sleep(1000);
//Select Type Code Drop Down Arrow
IWebElement TypeCodeDropDownArrow = Driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
TypeCodeDropDownArrow.Click();
Thread.Sleep(1000);
//Select Time Option from Drop Down
IWebElement TimeOption = Driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
TimeOption.Click();
Thread.Sleep(1000);
//Type Code
IWebElement CodeTextBox = Driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
CodeTextBox.SendKeys("123");
Thread.Sleep(1000);
//Type Description
IWebElement DescriptionTextBox = Driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
DescriptionTextBox.SendKeys("Numbers");
Thread.Sleep(2000);
//Type Price Per Unit
IWebElement PricePerUnitTextBox = Driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
PricePerUnitTextBox.SendKeys("2000");
Thread.Sleep(1000);
//Click on Save Button
IWebElement SaveButton = Driver.FindElement(By.Id("SaveButton"));
SaveButton.Click();
Thread.Sleep(3000);
//Check if the record is created successfully
IWebElement GotoLastButton = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
GotoLastButton.Click();
Thread.Sleep(1000);
//Validate Last Record
IWebElement LastRecord = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
Thread.Sleep(1000);
if (LastRecord.Text == "123")
{
    Console.WriteLine("New Record Created Successful");
}
else 
{
    Console.WriteLine("Unable to create a new Record");
}