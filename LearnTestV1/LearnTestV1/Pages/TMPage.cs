using LearnTestV1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTestV1.Pages
{
    public class TMPage
    {
            public void CreateTMPage(IWebDriver driver)
            {
                //Identify and Click on New Button
                IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                CreateNewButton.Click();
                //Thread.Sleep(1000);

                //Select Type Code Drop Down Arrow
                IWebElement TypeCodeDropDownArrow = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
                TypeCodeDropDownArrow.Click();
                //Thread.Sleep(1000);

                //Select Time Option from Drop Down
                IWebElement TimeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
                TimeOption.Click();
                //Thread.Sleep(1000);

                //Type Code
                IWebElement CodeTextBox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
                CodeTextBox.SendKeys("123");
                //Thread.Sleep(1000);

                //Type Description
                IWebElement DescriptionTextBox = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
                DescriptionTextBox.SendKeys("Numbers");
                //Thread.Sleep(2000);

                //Type Price Per Unit
                IWebElement PricePerUnitTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
                PricePerUnitTextBox.SendKeys("2000");
                Thread.Sleep(1000);

                //Click on Save Button
                IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
                SaveButton.Click();
                Thread.Sleep(3000);

                //Check if the record is created successfully
                IWebElement GotoLastButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
                GotoLastButton.Click();
                Thread.Sleep(1000);

                //Validate Last Record
                IWebElement LastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                //Thread.Sleep(1000);
               

            }
        public string GetCode(IWebDriver driver)
        {
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return actualDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return actualPrice.Text;
        }
            public void EditTMPage(IWebDriver driver, string code, string price, string desc) 
            {
            // Click on Edit Buttonto make changes to type Code
            Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]")).Click();
                IWebElement LastRecordEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                LastRecordEdit.Click();
               

                //Identify Code Text Box and clear last record
                driver.FindElement(By.XPath("//*[@id=\"Code\"]")).Clear();
                

                //Identify Code Text Box and Write New Record
                IWebElement CodeTextBox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
                CodeTextBox.SendKeys(code);
                
                IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id=\"Price\"]"));
                CodeTextBox.SendKeys(price);
                
                IWebElement descriptionTextBox = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
                CodeTextBox.SendKeys(desc);
            //Identify and Click on Save Button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
                SaveButton.Click();


            //Identify and Click on Last Page Button Page
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]")).Click();
            Thread.Sleep(1000); 
            IWebElement LastEditedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                
                //Validate if Record is edited Successfully or not
                if (LastEditedRecord.Text == "123456")
                {
                    Console.WriteLine("Record Modified Successfully");
                }
                else
                {
                    Console.WriteLine("Record Modification Unsuccessfull");
                }

            }
            public void DeleteTMPage(IWebDriver driver)
            {
            //Wait.WaitToBeClickable(driver, "XPath", 3, "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span");
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
                //Identify and Click on Last Page Button Page
                //Wait.WaitToBeClickable(driver, "XPath", 3, "//*[@id=\"tmsGrid\"]/div[4]/a[4]");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();

                //Find and click on delete button for last record
                //driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]")).Click();
                Thread.Sleep(1000);
                //IWebElement LastRecordDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                //LastRecordDelete.Click();
                
                //Acceptance on Pop up to delete record
                driver.SwitchTo().Alert().Accept();
                
                //Identify and validate if last record is deleted successfully and print output
                //if (LastRecordDelete.Text != "123456")
                //{
                //    Console.WriteLine("Record Deleted Successfully");
                //}
                //else
                //{
                 //   Console.WriteLine("Record Deletion Unsuccessfull");
                //}
            }
    }

}
