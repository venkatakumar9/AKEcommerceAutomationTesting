//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace AKEcommerceAutomation.TestSteps
{
    using Framework;
    using PageObjects;
    using PageObjects.Object_Repository;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;

    [Binding]
    sealed class HomepageSteps : SeleniumTestBase
    {
        private HomePage _homePage;

        //Verify Sub-Navigation-Menu 
        [When(@"I am in the AK Homepage")]
        public void WhenIAmInTheAkHomepage()
        {
            _homePage = new HomePage(driver);
            ScenarioContext.Current.Set(_homePage);
        }

        [Then(@"SubMenu Appears:")]
        public void ThenTheSubMenuAppears(Table table)
        {
            string[] headerValues = _homePage.GetHeaderValues();
            for (int i = 0; i < _homePage.GetHeaderNavigationCount(); i++)
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
            Assert.IsTrue(_homePage.GetRightHandSideBar());
        }

        [Then(@"Carousel Main image displays")]
        public void ThenCarouselMainImageDisplayed()
        {
            Assert.IsTrue(_homePage.HasElement(HomePageElements.HomepageCarouselMainImage));
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
            string[] headerlinksValues = _homePage.GetHeaderLinksValues();
            for (int i = 0; i < _homePage.GetHeaderLinks(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], headerlinksValues[i]);
            }
        }

        //Navigating to Destinations Homepage
        [When(@"I Click on Destinations Link")]
        public void WhenIClickOnDestinationsLink()
        {
            WhenIAmInTheAkHomepage();
            ScenarioContext.Current.Set(_homePage.GetDestinationsPage());
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