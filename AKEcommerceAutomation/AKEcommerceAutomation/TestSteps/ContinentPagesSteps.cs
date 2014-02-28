using System;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation
{
    [Binding]
    public class ContinentPagesSteps : SeleniumTestBase
    {
        HomePage homepage = new HomePage(driver);
       
        [When(@"I click on The Africa Continent")]
        public void WhenIClickOnTheAfricaContinent()
        {
            string[] continetnames = homepage.Meganav_topcontinetnames();
            driver.FindElement(By.LinkText(continetnames[0])).Click();
        }
        
        [Then(@"I reach Africa Continent page")]
        public void ThenIReachAfricaContinentPage()
        {
            Assert.AreEqual("Africa",driver.Title);
        }
    }
}
