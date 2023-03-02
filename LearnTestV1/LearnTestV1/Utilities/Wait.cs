using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTestV1.Utilities
{
    public class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver,string LocatorType,int seconds, string LocatorValue)
        {
            var wait = new WebDriverWait(driver,new TimeSpan(0,0,seconds));
            if(LocatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(LocatorValue)));
            }
            else if(LocatorType =="Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(LocatorValue)));
              
            }
            else if (LocatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(LocatorValue)));

            }

        }
    }
}
