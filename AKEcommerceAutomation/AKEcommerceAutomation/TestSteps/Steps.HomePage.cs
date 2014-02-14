//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation.TestSteps
{
    [Binding]
    public class HOMEPAGESteps : SeleniumTestBase
    {
        public HomePage homePage;

        //Verify Sub-Navigation-Menu 
        [When(@"I am in the AK Homepage")]
        public void WhenIAmInTheAkHomepage()
        {
            homePage = new HomePage(driver);
            ScenarioContext.Current.Set(homePage);
        }

        [Then(@"SubMenu Appears:")]
        public void ThenTheSubMenuAppears(Table table)
        {
            string[] headerValues = homePage.GetHeaderValues();
            for (int i = 0; i < homePage.GetHeaderNavigationCount(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], headerValues[i]);
            }
        }


        //Verifying the SideBar on the Page
        [Given(@"I am on the homepage")]
        public void GivenINavigateToHomepage()
        {
            WhenIAmInTheAkHomepage();
        }

        [Then(@"SideBar Displays")]
        public void ThenSideBarDisplays()
        {
            Assert.IsTrue(homePage.GetRightHandSideBar());
        }

        [Then(@"Carousel Main image displays")]
        public void ThenCarouselMainImageDisplayed()
        {
            Assert.IsTrue(homePage.HasElement(HomePageElements.HomepageCarouselMainImage));
        }


        //Header links in homepage
        [When(@"I am on the Homepage")]
        public void WhenIamOnTheHomepage()
        {
            WhenIAmInTheAkHomepage();
        }

        [Then(@"Top Headerlinks displays")]
        public void ThenTopHeaderLinksDisplays(Table table)
        {
            string[] headerlinksValues = homePage.GetHeaderLinksValues();
            for (int i = 0; i < homePage.GetHeaderLinks(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], headerlinksValues[i]);
            }
        }

        //Navigating to Destinations Homepage
        [When(@"I Click on Destinations Link")]
        public void WhenIClickOnDestinationsLink()
        {
            WhenIAmInTheAkHomepage();
            ScenarioContext.Current.Set(homePage.GetDestinationsPage());
        }

        [Then(@"I navigate to Destinations homepage")]
        public void ThenINavigateToDestinationsPage()
        {
            driver.PageSource.Contains("Destinations");
        }

        //[AfterScenario]
        //public void CloseBrowser()
        //{
        //    driver.Close();
        //}

        [BeforeScenario]
        public void InvokeBrowser()
        {
            Current().Navigate().GoToUrl(Url);
        }
    }
}