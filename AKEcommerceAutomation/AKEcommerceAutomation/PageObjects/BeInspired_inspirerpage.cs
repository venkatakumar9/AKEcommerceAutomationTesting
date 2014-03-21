using System.Collections.Generic;
using System.Linq;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using NUnit.Core;
using OpenQA.Selenium;
using System;

namespace AKEcommerceAutomation.PageObjects
{
      public class BeInspired_inspirerpage : BasePage
    {
          public BeInspired_inspirerpage(IWebDriver driver)
            : base(driver)
        {
           
        }

          public BeInspired_inspirerpage GetInspirerimagespage()
          {
              _driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div[1]/div/section/article/a/span[2]/span")).Click();
              driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
              return new BeInspired_inspirerpage(_driver);
          }

          public void GetGuidedGroupJourneys_SuggestedJourneysinlightbox()
          {
              int guidedgroupjourneys = _driver.FindElements(By.XPath("//*[@id='guidedGroupJourneys']/div/div/div/section/article/a/span[2]/span/span[1]")).Count;
              for (int i = 1; i <= guidedgroupjourneys; i++)
              {
                  Console.WriteLine(driver.FindElement(By.XPath("//*[@id='guidedGroupJourneys']/div/div[" + i + "]/div/section/article/a/span[2]/span/span")).Text);
              }
          }

          public bool GetguidedGroupJourneys_Section()
          {
              return _driver.FindElement(By.XPath("//*[@id='guidedGroupJourneys']/h2")).Displayed;
          }

          public bool GetTailorMadeJourneys_Section()
          {
              return _driver.FindElement(By.XPath("//*[@id='tailorMadeJourneys']")).Displayed;
          }

          public void GetTailorMadeJourneys_SuggestedJourneysinlightbox()
          {
              int tailormadejourneys =
                  _driver.FindElements(
                      By.XPath("//*[@id='tailorMadeJourneys']/div/div/div/section/article/a/span[2]/span/span[1]"))
                      .Count;
              for (int i = 1; i <= tailormadejourneys; i++)
              {
                  Console.WriteLine(driver.FindElement(By.XPath("//*[@id='tailorMadeJourneys']/div/div["+i+"]/div/section/article/a/span[2]/span/span[1]")).Text);
              }
          }

          public void CloseLightBox()
          {
              driver.FindElement(By.XPath("//article[@class = 'popup-overlay']/div/a")).Click();

          }
    }

}
