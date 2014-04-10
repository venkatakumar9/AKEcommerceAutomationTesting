using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

       public void Getspecialoffersearchwrapper()
       {
           var searchwrapper = driver.FindElement(By.XPath("//*[@id='page-wrapper']/div[4]/div")).Text;
           Console.WriteLine(searchwrapper);
           driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

       }

       public void GetGuidedgroup_SpecialOffers()
       {
           int guidedgroupimages = _driver.FindElements(By.XPath("//*[@id='guidedGroupJourneys']/div/div/div/div/section/article/a/span[3]/span")).Count;
           for (int i = 1; i <= guidedgroupimages; i++)
           {
               Console.WriteLine(driver.FindElement(By.XPath("//*[@id='guidedGroupJourneys']/div/div[" + i + "]/div/div/section/article/a/span[3]/span")).Text);
           }
       }

       public void GetTailormade_specialoffers()
       {
           
           int tailormadeoffers = _driver.FindElements(By.XPath("//*[@id='tailorMadeJourneys']/div/div/div/div/section/article/a/span[3]/span")).Count;
           for (int i = 1; i <= tailormadeoffers; i++)
           {
               Console.WriteLine(driver.FindElement(By.XPath("//*[@id='tailorMadeJourneys']/div/div["+i+"]/div/div/section/article/a/span[3]/span")).Text);
           }
       }

       public void GetAccommodations_Specialoffers()
       {
           int accommodations = _driver.FindElements(By.XPath("//*[@id='accommodations']/div/div/div/div/section/article/a/span[3]/span")).Count;
           for (int i = 1; i <= accommodations; i++)
           {
               Console.WriteLine(driver.FindElement(By.XPath("//*[@id='accommodations']/div/div["+i+"]/div/div/section/article/a/span[3]/span")).Text);
           }
       }
   }
}
