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
    [Parallelizable]
    public class TM_Test : CommonDriver
    {
        HomePage HomePageObj = new HomePage();
        TMPage TMPageObj = new TMPage();
        
        [Test,Order(1)]
        public void CreateTMStep()
        {
            // TM Page Object Initialization and Definition

            HomePageObj.GoToTMPage(driver);
            TMPageObj.CreateTMPage(driver);

        }
        [Test, Order(2)]
        public void EditTMStep()
        {
            //Edit TM Page Object Initialization and Definition
            HomePageObj.GoToTMPage(driver);
            TMPageObj.EditTMPage(driver);

        }
        [Test, Order(3)]
        public void DeleteTMStep()
        {
            //Delete TM Page Object Initialization and Definition
            HomePageObj.GoToTMPage(driver);
            TMPageObj.DeleteTMPage(driver);

        }
        
    }
}
