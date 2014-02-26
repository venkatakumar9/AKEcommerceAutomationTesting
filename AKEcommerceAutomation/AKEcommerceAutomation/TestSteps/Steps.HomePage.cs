<<<<<<< HEAD
﻿//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
=======
﻿using System;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
>>>>>>> 96a2f7404843823718131901ddb12f7fe9963032

namespace AKEcommerceAutomation.TestSteps
{
    using Framework;
    using PageObjects;
    using PageObjects.Object_Repository;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;

    [Binding]
<<<<<<< HEAD
    sealed class HomepageSteps : SeleniumTestBase
=======
    public class HOMEPAGESteps : SeleniumTestBase
>>>>>>> 96a2f7404843823718131901ddb12f7fe9963032
    {
        private HomePage _homePage;

     
        //Verify Footer High Level Links in the Homepage
        
        [When(@"I Navigate to Homepage")]
        public void WhenINavigateToHomepage()
        {
<<<<<<< HEAD
            _homePage = new HomePage(driver);
            ScenarioContext.Current.Set(_homePage);
=======
            homePage = new HomePage(driver);
            ScenarioContext.Current.Set(homePage); 
>>>>>>> 96a2f7404843823718131901ddb12f7fe9963032
        }

        [Then(@"Footer Links should Display")]
        public void ThenFooterLinksShouldDislay()
        {
<<<<<<< HEAD
            string[] headerValues = _homePage.GetHeaderValues();
            for (int i = 0; i < _homePage.GetHeaderNavigationCount(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], headerValues[i]);
            }
=======
            homePage.GetPreFooter_QuickLinks();
            homePage.GetPreFooter_CountryLinks();
            homePage.GetPreFooter_Sociallinks();
            homePage.GetPreFooter_SignUpforenews();
            homePage.FooterLinks();
            Assert.AreEqual(BasePage.CopyRightText, homePage.GetCopyRightText());
            Console.WriteLine("Sign up for news section displayed");

>>>>>>> 96a2f7404843823718131901ddb12f7fe9963032
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
<<<<<<< HEAD
            Assert.IsTrue(_homePage.GetRightHandSideBar());
=======
           
            Assert.IsTrue(homePage.GetRightHandSideBar());
>>>>>>> 96a2f7404843823718131901ddb12f7fe9963032
        }

        [Then(@"Middle Section of the Homepage Appears")]
        public void ThenCarouselMainImageDisplayed()
        {
<<<<<<< HEAD
            Assert.IsTrue(_homePage.HasElement(HomePageElements.HomepageCarouselMainImage));
        }

        //Header links in homepage
        [When(@"I am on the Homepage")]
        public void WhenIamOnTheHomepage()
=======
           Assert.AreEqual("Luxury travel with Abercrombie & Kent, celebrating over 50 years of inspiring experiences", homePage.GetHomepagemiddle_sectionText());
            Assert.IsTrue(homePage.GetGetHomePageMiddle_Section());
            Console.WriteLine("Middle Section Text and Images are Displayed");
        }

        [Then(@"Guided Group Journeys section Displays")]
        public void ThenGuidedGroupJourneysSectionDisplay()
>>>>>>> 96a2f7404843823718131901ddb12f7fe9963032
        {
            Assert.AreEqual("GUIDED GROUP JOURNEYS", homePage.GetGuidedgroupjourneys_Homepage());
            Assert.IsTrue(homePage.GetGuidedGroupJourneysInHomepage_Section());
            Console.WriteLine("Tailor Made Journeys section and Images Displayed");
        }

        [Then(@"Tailor Made Journeys section Displays")]
        public void ThenTailorMadeJourneysSectionDisplay()
        {
<<<<<<< HEAD
            string[] headerlinksValues = _homePage.GetHeaderLinksValues();
            for (int i = 0; i < _homePage.GetHeaderLinks(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], headerlinksValues[i]);
            }
=======
            Assert.AreEqual("TAILOR-MADE JOURNEYS", homePage.GetTailormadejourneys_Homepage());
            Assert.IsTrue(homePage.GetTailorMadeJourneysInHomepage_Section());
            Console.WriteLine("Tailor Made Journeys Section and Images Displayed");
>>>>>>> 96a2f7404843823718131901ddb12f7fe9963032
        }


      
        //Navigating to Destinations Homepage
        [When(@"I Click on Destinations Link")]
        public void WhenIClickOnDestinationsLink()
        {
<<<<<<< HEAD
            WhenIAmInTheAkHomepage();
            ScenarioContext.Current.Set(_homePage.GetDestinationsPage());
=======
            WhenINavigateToHomepage();
            ScenarioContext.Current.Set(homePage.GetDestinationsPage());
>>>>>>> 96a2f7404843823718131901ddb12f7fe9963032
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
