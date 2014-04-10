using System;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation.TestSteps
{
    [Binding]
    public class SpecialfferSteps : SeleniumTestBase
    {
        private readonly HomePage homePage = new HomePage(driver);
        private readonly SpecialoffersPage specialofferpage = new SpecialoffersPage(driver);

        /// <summary>
        ///     Verifying the Special Offers Navigation links
        /// </summary>
        [When(@"I click on Special offers link in header")]
        public void WhenIClickOnSpecialOffersLinkInHeader()
        {
            homePage.GetSpecialoffersPage();
        }

        [Then(@"Special offers page appear")]
        public void ThenSpecialOffersPageAppear()
        {
            string title = driver.Title;
            Console.WriteLine(title);
        }

        [Then(@"special offers navigation exists")]
        public void ThenSpecialOffersNavigationExists()
        {
            specialofferpage.GetSpecialoffersnavigationValues();
        }

        /// <summary>
        ///     Verify special offers Search wrapper in Special offers page
        /// </summary>
        /// >
        [When(@"I am in Specialoffers page")]
        public void WhenIAmInSpecialoffersPage()
        {
            homePage.GetSpecialoffersPage();
        }

        [Then(@"Special offer search wrapper appears")]
        public void ThenSpecialOfferSearchWrapperAppears()
        {
            specialofferpage.Getspecialoffersearchwrapper();
        }

        /// <summary>
        ///     Special offers related to Guided Group Journeys
        /// </summary>
        [When(@"I am in the Specialoffers page")]
        public void WhenIAmIntheSpecialoffersPage()
        {
            homePage.GetSpecialoffersPage();
        }

        [Then(@"Special offers related to Guided Group Journeys display")]
        public void ThenSpecialOffersRelatedToGuidedGroupJourneysDisplay()
        {
            specialofferpage.GetGuidedgroup_SpecialOffers();
        }

        /// <summary>
        ///     Special offers in Tailor Made Journeys
        /// </summary>
        [When(@"I click on Tailor Made Journeys tab")]
        public void WhenIClickOnTailorMadeJourneysTab()
        {
            homePage.GetSpecialoffersPage();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.FindElement(By.XPath("//div[@class = 'page-nav']/ul/li[2]")).Click();
        }

        [Then(@"special offers related to Tailor made journeys display")]
        public void ThenSpecialOffersRelatedToTailorMadeJourneysDisplay()
        {
            specialofferpage.GetTailormade_specialoffers();
        }

        /// <summary>
        ///     Accommodations in special offers
        /// </summary>
        [When(@"I click on Accommodation tab in special offer page")]
        public void WhenIClickOnAccommodationTabInSpecialOfferPage()
        {
            homePage.GetSpecialoffersPage();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.FindElement(By.XPath("//div[@class = 'page-nav']/ul/li[3]")).Click();
        }

        [Then(@"Accommodations in special offers display")]
        public void ThenAccommodationsInSpecialOffersDisplay()
        {
            specialofferpage.GetAccommodations_Specialoffers();
        }
    }
}