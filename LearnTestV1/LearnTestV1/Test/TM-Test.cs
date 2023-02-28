
using Aspose.Cells.Charts;
using LearnTestV1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.Network;
using OpenQA.Selenium.Edge;

// Open Web Browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Login Page Object Initialization and Definition
LoginPage LoginPageObj = new LoginPage();
LoginPageObj.LoginActions(driver);

//Home Page Object Initialization and Definition

HomePage HomePageObj = new HomePage();
HomePageObj.GoToTMPage(driver);

//TM Page Object Initialization and Definition

TMPage TMPageObj = new TMPage();
TMPageObj.CreateTMPage(driver);

//Edit TM Page Object Initialization and Definition

TMPageObj.EditTMPage(driver);

//Delete TM Page Object Initialization and Definition

TMPageObj.DeleteTMPage(driver);


        

