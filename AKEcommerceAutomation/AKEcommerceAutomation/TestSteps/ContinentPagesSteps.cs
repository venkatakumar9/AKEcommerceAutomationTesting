using System;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using AKEcommerceAutomation.TestSteps;
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

        [Given(@"I reach Africa Continent page")]
        public void GivenIReachAfricaContinentPage()
        {
            try
            {
               new HOMEPAGESteps().WhenINavigateToHomepage();
               homepage.mouseover(HomePageElements.Destinationlink);
               WhenIClickOnTheAfricaContinent();
               Assert.AreEqual("Africa", driver.Title);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
               
            }
        }

        [Then(@"Africa Country Vector map is present")]
        public void ThenAfricaCountryVectorMapIsPresent()
        {
            driver.FindElement(ContinentPageElements.Africacontinentmap);
        }

        [When(@"I click on SouthAfrica in Vector map")]
        public void WhenIClickOnSouthAfricaInVectorMap()
        {
           driver.FindElement(ContinentPageElements.southAfrica).Click();
        }

        [Then(@"I reach South Africa Page")]
        public void ThenIReachSouthAfricaPage()
        {
            Assert.AreEqual("South Africa Luxury Holidays & Safaris 2013, 2014 - A&K", driver.Title);
        }

    }
}
