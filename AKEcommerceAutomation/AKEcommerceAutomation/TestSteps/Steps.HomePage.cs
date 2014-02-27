//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//  Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation.TestSteps
{
    [Binding]
    public class HOMEPAGESteps : SeleniumTestBase
    {
        public HomePage homePage;


        //Verify Footer High Level Links in the Homepage

        [When(@"I Navigate to Homepage")]
        public void WhenINavigateToHomepage()
        {
            homePage = new HomePage(driver);
            ScenarioContext.Current.Set(homePage);
        }

        [Then(@"Footer Links should Display")]
        public void ThenFooterLinksShouldDislay()
        {
            homePage.GetPreFooter_QuickLinks();
            homePage.GetPreFooter_CountryLinks();
            homePage.GetPreFooter_Sociallinks();
            homePage.GetPreFooter_SignUpforenews();
            homePage.FooterLinks();
            Assert.AreEqual(BasePage.CopyRightText, homePage.GetCopyRightText());
            Console.WriteLine("Sign up for news section displayed");
        }

        // Verifying the SideBar, 
        // Middlesection and 
        // Journeys  on the Homepage

        [Given(@"I am on the homepage")]
        public void GivenINavigateToHomepage()
        {
            WhenINavigateToHomepage();
        }

        [Then(@"SideBar Displays")]
        public void ThenSideBarDisplays()
        {
            Assert.IsTrue(homePage.GetRightHandSideBar());
        }

        [Then(@"Middle Section of the Homepage Appears")]
        public void ThenCarouselMainImageDisplayed()
        {
            Assert.AreEqual(
                "Luxury travel with Abercrombie & Kent, celebrating over 50 years of inspiring experiences",
                homePage.GetHomepagemiddle_sectionText());
            Assert.IsTrue(homePage.GetGetHomePageMiddle_Section());
            Console.WriteLine("Middle Section Text and Images are Displayed");
        }

        [Then(@"Guided Group Journeys section Displays")]
        public void ThenGuidedGroupJourneysSectionDisplay()
        {
            Assert.AreEqual("GUIDED GROUP JOURNEYS", homePage.GetGuidedgroupjourneys_Homepage());
            Assert.IsTrue(homePage.GetGuidedGroupJourneysInHomepage_Section());
            Console.WriteLine("Tailor Made Journeys section and Images Displayed");
        }

        [Then(@"Tailor Made Journeys section Displays")]
        public void ThenTailorMadeJourneysSectionDisplay()
        {
            Assert.AreEqual("TAILOR-MADE JOURNEYS", homePage.GetTailormadejourneys_Homepage());
            Assert.IsTrue(homePage.GetTailorMadeJourneysInHomepage_Section());
            Console.WriteLine("Tailor Made Journeys Section and Images Displayed");
        }


        //Navigating to Destinations Homepage
        [When(@"I Click on Destinations Link")]
        public void WhenIClickOnDestinationsLink()
        {
            WhenINavigateToHomepage();
            ScenarioContext.Current.Set(homePage.GetDestinationsPage());
        }

        [Then(@"I navigate to Destinations homepage")]
        public void ThenINavigateToDestinationsPage()
        {
            driver.PageSource.Contains("Destinations");
        }


        [BeforeScenario]
        public void InvokeBrowser()
        {
            Current().Navigate().GoToUrl(Url);
        }

        //[AfterScenario]
        //public void CloseBrowser()
        //{
        //    driver.Close();
        //}
    }
}