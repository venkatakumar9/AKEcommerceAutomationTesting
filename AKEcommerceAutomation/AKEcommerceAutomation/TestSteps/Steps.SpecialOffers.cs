using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation.TestSteps
{
    [Binding]
    public class SpecialfferSteps : SeleniumTestBase
    {
        private readonly HomePage homePage = new HomePage(driver);
        private readonly SpecialoffersPage specialofferpage = new SpecialoffersPage(driver);

        /// <summary>
        /// Verifying the Special Offers Navigation links
        /// </summary>
        
        [When(@"I click on Special offers link in header")]
        public void WhenIClickOnSpecialOffersLinkInHeader()
        {
            homePage.GetSpecialoffersPage();
        }

        [Then(@"Special offers page appear")]
        public void ThenSpecialOffersPageAppear()
        {
            var title = driver.Title;
            Console.WriteLine(title);
        }

        [Then(@"special offers navigation exists")]
        public void ThenSpecialOffersNavigationExists()
        {
            specialofferpage.GetSpecialoffersnavigationValues();
            
        }

        /// <summary>
        ///  Verify special offers Search wrapper in Special offers page
        /// </summary>>
        
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
        /// Special offers related to Guided Group Journeys
        /// </summary>

        [When(@"I am in the Specialoffers page")]
        public void WhenIAmIntheSpecialoffersPage()
        {
            homePage.GetSpecialoffersPage();
        }

        [Then(@"Special offers related to Guided Group Journeys display")]
        public void ThenSpecialOffersRelatedToGuidedGroupJourneysDisplay()
        {
            specialofferpage.GetSpecialOffers_Guidedgroup();
        }

        

    }
}
