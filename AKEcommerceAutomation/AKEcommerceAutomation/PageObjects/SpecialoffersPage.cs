using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace AKEcommerceAutomation.PageObjects
{
   public class SpecialoffersPage : BasePage
   {
       public SpecialoffersPage(IWebDriver driver) : base(driver)
   {
       
   }
       public string title()
       {
           return driver.Title;
       }

      public void GetSpecialoffersnavigationValues()
       {
          int specialoffernavigationlinks = _driver.FindElements(By.XPath("//div[@class = 'page-nav']/ul")).Count;
          for (int i = 1; i <= specialoffernavigationlinks; i++)
          {
             Console.WriteLine(driver.FindElement(By.XPath("//div[@class = 'page-nav']/ul["+i+"]")).Text);
          }
           
          

       }
   }
}
