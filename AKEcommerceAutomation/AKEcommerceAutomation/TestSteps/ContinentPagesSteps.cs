//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace AKEcommerceAutomation
{
    using System;
    using Framework;
    using PageObjects;
    using PageObjects.Object_Repository;
    using TestSteps;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using TechTalk.SpecFlow;
    [Binding]
    sealed class ContinentPagesSteps : SeleniumTestBase
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

        [Then(@"The Navigation links are present")]
        public void ThenTheNavigationLinksArePresent(Table table)
        {
            string[] conitnetpagelinks = homepage.GetContinentPage().continentnavlinks();
            for (int i = 0; i < homepage.GetHeaderNavigationCount(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], conitnetpagelinks[i]);
            }
        }

        [When(@"I click on the navigation links")]
        public void WhenIClickOnTheNavigationLinks()
        {
            homepage.Navlink_pagetitles(ContinentPageElements.Navigation);
        }

        [Then(@"I reach the specific pages in the continent page")]
        public void ThenIReachTheSpecificPagesInTheContinentPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the carousel Image is present")]
        public void ThenTheCarouselImageIsPresent()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
