//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace AKEcommerceAutomation
{
    using Framework;
    using PageObjects;
    using TechTalk.SpecFlow;
    using PageObjects.Object_Repository;
    using NUnit.Framework;
    using OpenQA.Selenium;

    [Binding]
    sealed class DestinationpageSteps : SeleniumTestBase
    {
        // This Class Covers the Scenatios of the Destination Page.

        public HomePage homePage;

        [Given(@"I am on the HomePage")]
        public void GivenIAmOnTheHomePage()
        {
            homePage = new HomePage(driver);
            ScenarioContext.Current.Set(homePage);
        }
        
        [Given(@"I click on Destination Link")]
        public void GivenIClickOnDestinationLink()
        {
            homePage.GetDestinationsPage();
        }
      
        [Then(@"I reach the destination page")]
        public void ThenIReachTheDestinationPage()
        {
            var title = homePage.GetDestinationsPage().title();
            Assert.AreEqual("Destination",title);
        }
        
        [Then(@"The Vector map is present")]
        public void ThenTheVectorMapIsPresent()
        {
           IWebElement vectormap = driver.FindElement(DestinationsPageElements.VectorMap);
           Assert.AreEqual(vectormap.Text, "MAP VIEW");
        }

        [Given(@"I am on the destination page")]
        public void GivenIAmOnTheDestinationPage()
        {
            driver.Navigate().GoToUrl("http://akwebqa01/en-gb/destination");
        }

        [Given(@"The Vector Map is present")]
        public void GivenTheVectorMapIsPresent()
        {
            IWebElement vectormap =  driver.FindElement(DestinationsPageElements.VectorMap);
        }

        [When(@"I click on The Americas in Vector map")]
        public void WhenIClickOnTheAmericasInVectorMap()
        {
           homePage = new HomePage(driver);
           var title = homePage.GetDestinationsPage().vectormapclick_Americas();
        }

        [Then(@"I reach the Americas page")]
        public void ThenIReachTheAmericasPage()
        {
           Assert.AreEqual(driver.Title, "The Americas");
        }

        [When(@"I click on The Africa in Vector map")]
        public void WhenIClickOnTheAfricaInVectorMap()
        {
            homePage = new HomePage(driver);
            string title = homePage.GetDestinationsPage().vectormapclick_Africa();
        }

        [Then(@"I reach the Africa page")]
        public void ThenIReachTheAfricaPage()
        {
            Assert.AreEqual(driver.Title,"Africa");
        }

        [When(@"I click on The Europe in Vector map")]
        public void WhenIClickOnTheEuropeInVectorMap()
        {
            homePage = new HomePage(driver);
            string title = homePage.GetDestinationsPage().vectormapclick_Europe();
        }

        [Then(@"I reach the Europe page")]
        public void ThenIReachTheEuropePage()
        {
            Assert.AreEqual(driver.Title,"Europe");
        }

        [When(@"I click on The  Caribbean in Vector map")]
        public void WhenIClickOnTheCaribbeanInVectorMap()
        {
            homePage = new HomePage(driver);
            string title = homePage.GetDestinationsPage().vectormapclick_Carribean();
        }

        [Then(@"I reach the  Caribbean page")]
        public void ThenIReachTheCaribbeanPage()
        {
         Assert.AreEqual(driver.Title,"Caribbean Holidays 2013, 2014 - A&K");   
        }

        [When(@"I click on The Autralia and Newzealand in Vector map")]
        public void WhenIClickOnTheAutraliaAndNewzealandInVectorMap()
        {
            homePage = new HomePage(driver);
            string title = homePage.GetDestinationsPage().vectormapclick_AutraliaAndNewzealand();
        }

        [Then(@"I reach the Autralia and Newzealand page")]
        public void ThenIReachTheAutraliaAndNewzealandPage()
        {
           Assert.AreEqual(driver.Title,"Australia, New Zealand & South Pacific");
        }

        [When(@"I click on The Middle East And North Africa in Vector map")]
        public void WhenIClickOnTheMiddleEastAndNorthAfricaInVectorMap()
        {
            homePage = new HomePage(driver);
            string title = homePage.GetDestinationsPage().vectormapclick_Middleeast();
        }

        [Then(@"I reach the Middle East And North Africa page")]
        public void ThenIReachTheMiddleEastAndNorthAfricaPage()
        {
           Assert.AreEqual(driver.Title,"North Africa Holidays & Middle East Holidays - A&K");
        }

        [When(@"I click on The India And The Himalayas in Vector map")]
        public void WhenIClickOnTheIndiaAndTheHimalayasInVectorMap()
        {
            homePage = new HomePage(driver);
          string title =  homePage.GetDestinationsPage().vectormapclick_IndiaAndHimalayas();
        }

        [Then(@"I reach the India And The Himalayas page")]
        public void ThenIReachTheIndiaAndTheHimalayasPage()
        {
           Assert.AreEqual(driver.Title,"India Holidays 2013, 2014 - A&K");
        }

        [When(@"I click on The Indian ocean in Vector map")]
        public void WhenIClickOnTheIndianOceanInVectorMap()
        {
            homePage = new HomePage(driver);
            string title = homePage.GetDestinationsPage().vectormapclick_IndianOcean();
        }

        [Then(@"I reach the Indian ocean page")]
        public void ThenIReachTheIndianOceanPage()
        {
            Assert.AreEqual(driver.Title,"Indian Ocean");
        }
        [When(@"I click on The Arctic in Vector map")]
        public void WhenIClickOnTheArcticInVectorMap()
        {
             homePage = new HomePage(driver);
            string title = homePage.GetDestinationsPage().vectormapclick_Arctic();
        }

        [Then(@"I reach the Arctic page")]
        public void ThenIReachTheArcticPage()
        {
            Assert.AreEqual(driver.Title, "Antarctica Expeditions, Antarctic Expeditions - A&K");
        }

        [When(@"I click on The Antarctica in Vector map")]
        public void WhenIClickOnTheAntarcticaInVectorMap()
        {
            homePage = new HomePage(driver);
            string title = homePage.GetDestinationsPage().vectormapclick_Antarctica();
        }

        [Then(@"I reach the Antarctica page")]
        public void ThenIReachTheAntarcticaPage()
        {
            Assert.AreEqual(driver.Title, "Antarctica Expeditions, Antarctic Expeditions - A&K");
        }

    }
}
