using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using System;

namespace AKEcommerceAutomation.PageObjects
{
    public class BeInspiredPage : BasePage
    {
        public BeInspiredPage(IWebDriver driver)
            : base(driver)
        {
        }

       public string title()
        {
            return driver.Title;
        }

        public bool GetInspirerInstructionalText()
        {
            return _driver.FindElement(By.XPath("//*[@id='inspirerInstructionalText']/div/p")).Displayed;
        }

       public int GetBeinspiredNavugationCount()
        {
            return _driver.FindElements(By.XPath("//div[@class = 'nav']/a")).Count;
        }
        public string[] GetBeinspiredNavigationValues()
        {
            var beinspirednavigationValues = new string[GetBeinspiredNavugationCount()];
            for (int i = 1; i < GetBeinspiredNavugationCount(); i++)
            {
                beinspirednavigationValues[i] = _driver.FindElement(By.XPath("//div[@class = 'nav']/a[" + (i+1) +"]")).Text;
            }
            return beinspirednavigationValues;
        }
    }
}